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
            // --- 1. Validaciones iniciales (se mantienen igual) ---
            if (!int.TryParse(tbNIS.Text, out int nis))
            {
                MessageBox.Show("Por favor, ingrese un NIS válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbAño.SelectedItem == null || cbMes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un año y un mes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int año = Convert.ToInt32(cbAño.SelectedItem);
            int mes = Convert.ToInt32(cbMes.SelectedItem);

            using (var db = new GISELEntities())
            {
                // --- 2. Buscar la factura en la base de datos ---
                var factura = db.TablaFacturas.FirstOrDefault(f => f.NIS == nis && f.Año == año && f.Mes == mes);

                if (factura != null)
                {
                    // --- 3. Abrir el diálogo para guardar el archivo ---
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PNG Image|*.png|JPeg Image|*.jpg"; // Filtros para guardar como imagen
                    saveFileDialog.Title = "Guardar Factura como Imagen";
                    saveFileDialog.FileName = $"Factura_{factura.NIS}_{año}_{mes}.png"; // Nombre de archivo sugerido

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // --- 4. Crear la factura en segundo plano y guardarla ---
                        // Se crea el formulario de la factura, pero nunca se muestra.
                        using (var facturaForm = new FacturaConsumo(factura))
                        {
                            // Llamamos a un nuevo método para guardar la imagen del formulario.
                            var handle = facturaForm.Handle;
                            facturaForm.GuardarComoImagen(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Factura guardada exitosamente en: " + saveFileDialog.FileName, "Guardado Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró una factura para los datos seleccionados. Asegúrese de haber añadido el consumo primero.", "Factura no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
            // Validaciones iniciales
            if (!int.TryParse(tbNIS.Text, out int nis))
            {
                MessageBox.Show("Ingrese un NIS válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbAño.SelectedItem == null || cbMes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un año y un mes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int año = Convert.ToInt32(cbAño.SelectedItem);
            int mes = Convert.ToInt32(cbMes.SelectedItem);

            using (var db = new GISELEntities())
            {
                var consumo = db.ConteoConsumoTabla.FirstOrDefault(c => c.NIS == nis && c.Año == año && c.Mes == mes);
                if (consumo == null)
                {
                    MessageBox.Show("No se encontró consumo para el NIS, año y mes seleccionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // --- Inician los cálculos de costos ---
                decimal kwhTotal = Convert.ToDecimal(consumo.KilowattsHora);
                var kwh = consumo.KilowattsHora ?? 0;

                // **CÁLCULO REAL DE ALUMBRADO PÚBLICO**
                decimal precioAlumbradoTotal = 0;
                var precioAlumbrado = db.PrecioAlumbradoPublico.FirstOrDefault(p => p.Año == año && p.Mes == mes);
                if (precioAlumbrado != null)
                {
                    if (kwh <= 25) precioAlumbradoTotal = precioAlumbrado.De0a25kWh ?? 0;
                    else if (kwh <= 50) precioAlumbradoTotal = precioAlumbrado.De26a50kWh ?? 0;
                    else if (kwh <= 100) precioAlumbradoTotal = precioAlumbrado.De51a100kWh ?? 0;
                    else if (kwh <= 150) precioAlumbradoTotal = precioAlumbrado.De101a150kWh ?? 0;
                    else if (kwh <= 500) precioAlumbradoTotal = precioAlumbrado.De151a500kWh ?? 0;
                    else if (kwh <= 1000) precioAlumbradoTotal = precioAlumbrado.De501a1000kWh ?? 0;
                    else precioAlumbradoTotal = precioAlumbrado.Mayorde1000kWh ?? 0;
                }

                // **CÁLCULO REAL DE COMERCIALIZACIÓN**
                decimal precioFijoComercializacion = 0;
                var precioFijo = db.PrecioFijoComercialización.FirstOrDefault(p => p.Año == año && p.Mes == mes);
                if (precioFijo != null)
                {
                    if (kwh <= 25) precioFijoComercializacion = precioFijo.De0a25kWh ?? 0;
                    else if (kwh <= 50) precioFijoComercializacion = precioFijo.De26a50kWh ?? 0;
                    else if (kwh <= 100) precioFijoComercializacion = precioFijo.De51a100kWh ?? 0;
                    else if (kwh <= 500) precioFijoComercializacion = precioFijo.De101a150kWh ?? 0;
                    else if (kwh <= 1000) precioFijoComercializacion = precioFijo.De501a1000kWh ?? 0;
                    else precioFijoComercializacion = precioFijo.Mayorde1000kWh ?? 0;
                }

                // **CÁLCULO REAL DE PRECIO POR KWH**
                decimal precioFijokwh = 0;
                var kwhPrecio = db.PrecioKwhPorMes.FirstOrDefault(p => p.Año == año && p.Mes == mes);
                if (kwhPrecio != null)
                {
                    if (kwh <= 25) precioFijokwh = kwhPrecio.Primeros25kWh ?? 0;
                    else if (kwh <= 50) precioFijokwh = kwhPrecio.Siguientes25kWh ?? 0;
                    else if (kwh <= 100) precioFijokwh = kwhPrecio.Siguientes50kWh1 ?? 0;
                    else if (kwh <= 150) precioFijokwh = kwhPrecio.Siguientes50kWh2 ?? 0;
                    else if (kwh <= 500) precioFijokwh = kwhPrecio.Siguientes350kWh ?? 0;
                    else if (kwh <= 1000) precioFijokwh = kwhPrecio.Siguientes500kWh ?? 0;
                    else precioFijokwh = kwhPrecio.Adicionalesa1000kWh ?? 0;
                }

                // --- Búsqueda y guardado de la factura ---
                var facturaExistente = db.TablaFacturas.FirstOrDefault(f => f.NIS == nis && f.Año == año && f.Mes == mes);

                if (facturaExistente != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Ya existe una factura para este NIS en el mes y año seleccionados. ¿Desea sobrescribirla?", "Factura Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        facturaExistente.KwhTotalAPagar = kwhTotal;
                        facturaExistente.PrecioAlumbradoPublicoTotal = precioAlumbradoTotal;
                        facturaExistente.PrecioFijoComercialicación = precioFijoComercializacion;
                        facturaExistente.PrecioKwhPorMes = precioFijokwh;
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    facturaExistente = new TablaFacturas
                    {
                        NIS = nis,
                        Año = año,
                        Mes = mes,
                        NombreUsuario = lblUsuarioCAMBIA.Text,
                        Compañia = lblCompañíaCAMBIA.Text,
                        KwhTotalAPagar = kwhTotal,
                        PrecioAlumbradoPublicoTotal = precioAlumbradoTotal,
                        PrecioFijoComercialicación = precioFijoComercializacion,
                        PrecioKwhPorMes = precioFijokwh
                    };
                    db.TablaFacturas.Add(facturaExistente);
                }

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Factura guardada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
