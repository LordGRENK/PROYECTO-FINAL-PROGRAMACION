using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class CalcularCostos : Form
    {

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
            var facturaconsumo = new FacturaConsumo();
            facturaconsumo.Show();
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

            using (var db = new GISELEntities())
            {
                // Buscar el consumo correspondiente
                var consumo = db.ConteoConsumoTabla.FirstOrDefault(c => c.NIS == nis && c.Año == año && c.Mes == mes);
                if (consumo == null)
                {
                    MessageBox.Show("No se encontró consumo para el NIS, año y mes seleccionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Buscar si ya existe una factura para este NIS
                var facturaExistente = db.TablaFacturas.FirstOrDefault(f => f.NIS == nis);
                decimal kwhTotal = Convert.ToDecimal(consumo.KilowattsHora);

                if (facturaExistente != null)
                {
                    // Sumar el consumo al total existente
                    facturaExistente.KwhTotalAPagar += kwhTotal;
                }
                else
                {
                    // Crear nueva factura
                    facturaExistente = new TablaFacturas
                    {
                        NIS = nis,
                        NombreUsuario = lblUsuarioCAMBIA.Text,
                        Compañia = lblCompañíaCAMBIA.Text,
                        KwhTotalAPagar = kwhTotal
                        // Los otros campos se agregan abajo
                    };
                    db.TablaFacturas.Add(facturaExistente);
                }

                // Buscar el precio de alumbrado público solo por año y mes
                var precioAlumbrado = db.PrecioAlumbradoPublico
                    .FirstOrDefault(p => p.Año == año && p.Mes == mes);

                decimal precioAlumbradoTotal = 0;

                if (precioAlumbrado != null)
                {
                    var kwh = consumo.KilowattsHora ?? 0;
                    if (kwh <= 25)
                        precioAlumbradoTotal = precioAlumbrado.De0a25kWh ?? 0;
                    else if (kwh <= 50)
                        precioAlumbradoTotal = precioAlumbrado.De26a50kWh ?? 0;
                    else if (kwh <= 100)
                        precioAlumbradoTotal = precioAlumbrado.De51a100kWh ?? 0;
                    else if (kwh <= 150)
                        precioAlumbradoTotal = precioAlumbrado.De101a150kWh ?? 0;
                    else if (kwh <= 500)
                        precioAlumbradoTotal = precioAlumbrado.De151a500kWh ?? 0;
                    else if (kwh <= 1000)
                        precioAlumbradoTotal = precioAlumbrado.De501a1000kWh ?? 0;
                    else
                        precioAlumbradoTotal = precioAlumbrado.Mayorde1000kWh ?? 0;
                }

                facturaExistente.PrecioAlumbradoPublicoTotal = precioAlumbradoTotal;
                // Buscar el precio fijo de comercialización solo por año y mes
                var precioFijo = db.PrecioFijoComercialización
                    .FirstOrDefault(p => p.Año == año && p.Mes == mes);

                decimal precioFijoComercializacion = 0;

                if (precioFijo != null)
                {
                    var kwh = consumo.KilowattsHora ?? 0;
                    if (kwh <= 25)
                        precioFijoComercializacion = precioFijo.De0a25kWh ?? 0;
                    else if (kwh <= 50)
                        precioFijoComercializacion = precioFijo.De26a50kWh ?? 0;
                    else if (kwh <= 100)
                        precioFijoComercializacion = precioFijo.De51a100kWh ?? 0;
                    else if (kwh <= 500)
                        precioFijoComercializacion = precioFijo.De101a150kWh ?? 0;
                    else if (kwh <= 1000)
                        precioFijoComercializacion = precioFijo.De501a1000kWh ?? 0;
                    else
                        precioFijoComercializacion = precioFijo.Mayorde1000kWh ?? 0;
                }

                facturaExistente.PrecioFijoComercialicación = precioFijoComercializacion;

                // Buscar el precio fijo de kWh solo por año y mes
                var precioFijokWh = db.PrecioKwhPorMes
                    .FirstOrDefault(p => p.Año == año && p.Mes == mes);

                decimal precioFijokwh = 0;

                if (precioFijokWh != null)
                {
                    var kwh = consumo.KilowattsHora ?? 0;
                    if (kwh <= 25)
                        precioFijokwh = precioFijokWh.Primeros25kWh ?? 0;
                    else if (kwh <= 50)
                        precioFijokwh = precioFijokWh.Siguientes25kWh ?? 0;
                    else if (kwh <= 100)
                        precioFijokwh = precioFijokWh.Siguientes50kWh1 ?? 0;
                    else if (kwh <= 150)
                        precioFijokwh = precioFijokWh.Siguientes50kWh2 ?? 0;
                    else if (kwh <= 500)
                        precioFijokwh = precioFijokWh.Siguientes350kWh ?? 0;
                    else if (kwh <= 1000)
                        precioFijokwh = precioFijokWh.Siguientes500kWh ?? 0;
                    else
                        precioFijokwh = precioFijokWh.Adicionalesa1000kWh ?? 0;
                }

                facturaExistente.PrecioKwhPorMes = precioFijokwh;
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Consumo añadido a la tabla de facturas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Error en la propiedad: {validationError.PropertyName}\nMensaje: {validationError.ErrorMessage}",
                                            "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
