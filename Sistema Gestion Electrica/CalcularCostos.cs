using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Sistema_Gestion_Electrica
{
    public partial class CalcularCostos : Form
    {
        private int cantMesesPendientes = 0;

        public CalcularCostos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void lblCompañíaCAMBIA_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nis = tbNIS.Text.Trim();
            if (string.IsNullOrEmpty(nis))
            {
                MessageBox.Show("Por favor, ingrese un NIS válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(nis, out int nisInt))
            {
                MessageBox.Show("El NIS debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new GISELEntities())
            {
                // 1. Llenar cbAño y cbMes desde ConteoConsumoTabla
                var consumos = db.ConteoConsumoTabla
                    .Where(c => c.NIS == nisInt)
                    .ToList();

                if (consumos.Count == 0)
                {
                    MessageBox.Show("No se encontraron consumos para el NIS ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbAño.DataSource = null;
                    cbMes.DataSource = null;
                    lblUsuarioCAMBIA.Text = "";
                    lblCompañíaCAMBIA.Text = "";
                    return;
                }

                cbAño.DataSource = consumos
                    .Select(c => c.Año)
                    .Distinct()
                    .OrderBy(a => a)
                    .ToList();

                cbMes.DataSource = consumos
                    .Select(c => c.Mes)
                    .Distinct()
                    .OrderBy(m => m)
                    .ToList();

                // 2. Buscar usuario y compañía en ingresarServicio
                var servicio = db.ingresarServicio
                    .FirstOrDefault(s => s.id == nisInt); // Cambiado de "NIS" a "id"

                if (servicio != null)
                {
                    lblUsuarioCAMBIA.Text = servicio.usuarioServicio;
                    lblCompañíaCAMBIA.Text = servicio.servicioAnexado;
                }
                else
                {
                    lblUsuarioCAMBIA.Text = "No encontrado";
                    lblCompañíaCAMBIA.Text = "No encontrado";
                }
            }
        }

        private void btnAñadirConsumo_Click(object sender, EventArgs e)
        {
            // Validar NIS
            if (!int.TryParse(tbNIS.Text, out int nis))
            {
                MessageBox.Show("Ingrese un NIS válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar selección de año y mes
            if (cbAño.SelectedItem == null || cbMes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un año y un mes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int año = Convert.ToInt32(cbAño.SelectedItem);
            int mes = Convert.ToInt32(cbMes.SelectedItem);

            // Incrementar el contador de meses pendientes
            cantMesesPendientes++;

            using (var db = new GISELEntities())
            {
                // Buscar el consumo correspondiente
                var consumo = db.ConteoConsumoTabla.FirstOrDefault(c => c.NIS == nis && c.Año == año && c.Mes == mes);
                if (consumo == null)
                {
                    MessageBox.Show("No se encontró consumo para el NIS, año y mes seleccionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal kwh = Convert.ToDecimal(consumo.KilowattsHora);

                // Buscar si ya existe una factura para este NIS
                var facturaExistente = db.TablaFacturas.FirstOrDefault(f => f.NIS == nis);
                if (facturaExistente != null)
                {
                    // Sumar el consumo al total existente
                    facturaExistente.KwhTotalAPagar += kwh;
                    facturaExistente.CantMesesPendientes = cantMesesPendientes;
                }
                else
                {
                    // Crear nueva factura
                    facturaExistente = new TablaFacturas
                    {
                        NIS = nis,
                        NombreUsuario = lblUsuarioCAMBIA.Text,
                        Compañia = lblCompañíaCAMBIA.Text,
                        CantMesesPendientes = cantMesesPendientes,
                        KwhTotalAPagar = kwh
                        // Los otros campos se agregan abajo
                    };
                    db.TablaFacturas.Add(facturaExistente);
                }

                // --- Precio Alumbrado Público ---
                var precioAlumbrado = db.PrecioAlumbradoPublico.FirstOrDefault(p => p.Año == año && p.Mes == mes && p.Compañia == lblCompañíaCAMBIA.Text);
                if (precioAlumbrado != null)
                {
                    if (kwh <= 25)
                        facturaExistente.PrecioAlumbradoPublicoTotal = precioAlumbrado.De0a25kWh;
                    else if (kwh <= 50)
                        facturaExistente.PrecioAlumbradoPublicoTotal = precioAlumbrado.De26a50kWh;
                    else if (kwh <= 100)
                        facturaExistente.PrecioAlumbradoPublicoTotal = precioAlumbrado.De51a100kWh;
                    else if (kwh <= 150)
                        facturaExistente.PrecioAlumbradoPublicoTotal = precioAlumbrado.De101a150kWh;
                    else if (kwh <= 500)
                        facturaExistente.PrecioAlumbradoPublicoTotal = precioAlumbrado.De151a500kWh;
                    else if (kwh <= 1000)
                        facturaExistente.PrecioAlumbradoPublicoTotal = precioAlumbrado.De501a1000kWh;
                    else
                        facturaExistente.PrecioAlumbradoPublicoTotal = precioAlumbrado.Mayorde1000kWh;
                }

                // --- Precio Fijo Comercialización ---
                var precioComercializacion = db.PrecioFijoComercialización.FirstOrDefault(p => p.Año == año && p.Mes == mes && p.Compañia == lblCompañíaCAMBIA.Text);
                if (precioComercializacion != null)
                {
                    if (kwh <= 25)
                        facturaExistente.PrecioFijoComercialicación = precioComercializacion.De0a25kWh;
                    else if (kwh <= 50)
                        facturaExistente.PrecioFijoComercialicación = precioComercializacion.De26a50kWh;
                    else if (kwh <= 100)
                        facturaExistente.PrecioFijoComercialicación = precioComercializacion.De51a100kWh;
                    else if (kwh <= 150)
                        facturaExistente.PrecioFijoComercialicación = precioComercializacion.De101a150kWh;
                    else if (kwh <= 500)
                        facturaExistente.PrecioFijoComercialicación = precioComercializacion.De151a500kWh;
                    else if (kwh <= 1000)
                        facturaExistente.PrecioFijoComercialicación = precioComercializacion.De501a1000kWh;
                    else
                        facturaExistente.PrecioFijoComercialicación = precioComercializacion.Mayorde1000kWh;
                }

                // --- Precio kWh por Mes ---
                var precioKwhMes = db.PrecioKwhPorMes.FirstOrDefault(p => p.Año == año && p.Mes == mes && p.Compañia == lblCompañíaCAMBIA.Text);
                if (precioKwhMes != null)
                {
                    if (kwh <= 25)
                        facturaExistente.PrecioKwhPorMes = precioKwhMes.Primeros25kWh;
                    else if (kwh <= 50)
                        facturaExistente.PrecioKwhPorMes = precioKwhMes.Siguientes25kWh;
                    else if (kwh <= 100)
                        facturaExistente.PrecioKwhPorMes = precioKwhMes.Siguientes50kWh1;
                    else if (kwh <= 150)
                        facturaExistente.PrecioKwhPorMes = precioKwhMes.Siguientes50kWh2;
                    else if (kwh <= 500)
                        facturaExistente.PrecioKwhPorMes = precioKwhMes.Siguientes350kWh;
                    else if (kwh <= 1000)
                        facturaExistente.PrecioKwhPorMes = precioKwhMes.Siguientes500kWh;
                    else
                        facturaExistente.PrecioKwhPorMes = precioKwhMes.Adicionalesa1000kWh;
                }

                db.SaveChanges();
            }

            MessageBox.Show("Consumo añadido a la tabla de facturas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
