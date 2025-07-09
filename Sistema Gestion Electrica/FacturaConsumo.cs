using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class FacturaConsumo : Form
    {
        private readonly TablaFacturas _factura;

        public FacturaConsumo(TablaFacturas factura)
        {
            InitializeComponent();
            _factura = factura;
            CargarDatosFactura();
        }

        private void CargarDatosFactura()
        {
            if (_factura != null)
            {
                // --- 0. Obtener valores base de la factura ---
                decimal kwhConsumidos = _factura.KwhTotalAPagar ?? 0;
                decimal precioPorKwh = _factura.PrecioKwhPorMes ?? 0;
                decimal costoAlumbrado = _factura.PrecioAlumbradoPublicoTotal ?? 0;
                decimal costoComercializacion = _factura.PrecioFijoComercialicación ?? 0;

                // --- Rellenar información básica de la factura ---
                lblNumeroDeServicioAQUI.Text = _factura.NIS.ToString();
                lblNombreDeUsuarioAQUI.Text = _factura.NombreUsuario;
                lblTitulo.Text = _factura.Compañia;
                lblkWhConsumidosAQUI.Text = kwhConsumidos.ToString("N2") + " kWh";
                lblkWhMesAQUI.Text = precioPorKwh.ToString("N2");
                lblAlumbradoPublicoAQUI.Text = costoAlumbrado.ToString("N2");
                lblComercializaciónAQUI.Text = costoComercializacion.ToString("N2");
                lblFechaAQUI.Text = DateTime.Now.ToString("dd/MM/yyyy");

                // --- Inician los cálculos según tu fórmula ---

                // 1. Total de kWh consumidos * precio del kWh del mes
                decimal costoConsumoKwh = kwhConsumidos * precioPorKwh;

                // 2. Sumatoria inicial
                decimal subtotal_1 = costoConsumoKwh + costoAlumbrado + costoComercializacion;

                // 3. Cálculo del subsidio
                decimal subsidio = 0;
                if (kwhConsumidos > 0 && kwhConsumidos <= 50)
                {
                    subsidio = costoConsumoKwh * 0.50m; // 50% de subsidio
                }
                else if (kwhConsumidos > 50 && kwhConsumidos <= 100)
                {
                    subsidio = costoConsumoKwh * 0.45m; // 45% de subsidio
                }
                else if (kwhConsumidos > 100 && kwhConsumidos <= 150)
                {
                    subsidio = costoConsumoKwh * 0.25m; // 25% de subsidio
                }
                lblSubsidioAQUI.Text = subsidio.ToString("N2");

                // 4. Resta del subsidio
                decimal subtotal_2 = subtotal_1 - subsidio;

                // 5. Cálculo del Impuesto INE (0.00064%)
                decimal impuestoINE = subtotal_2 * 0.00064m;
                label4.Text = impuestoINE.ToString("N2"); // 'label4' es el valor del Impuesto INE

                // 6. Suma del impuesto para obtener el total final
                decimal totalAPagar = subtotal_2 + impuestoINE;
                TotalAQUI.Text = totalAPagar.ToString("N2");
            }
        }
        public void GuardarComoImagen(string rutaArchivo)
        {
            // Identificamos el panel que contiene toda la información.
            Control panel = this.panel1;

            // Creamos una imagen (Bitmap) con el tamaño exacto del panel.
            using (Bitmap bmp = new Bitmap(panel.Width, panel.Height))
            {
                // Dibujamos el panel y todo su contenido en la imagen.
                panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.Width, panel.Height));

                // Guardamos la imagen final.
                bmp.Save(rutaArchivo, ImageFormat.Png);
            }
        }

        // --- Mantén los otros métodos de tu formulario aquí ---
        private void lblAlumbradoPublicoTotal_Click(object sender, EventArgs e) { }
        private void lblNumeroDeServicioAQUI_Click(object sender, EventArgs e) { }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void FacturaConsumo_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccionUsuarioAQUI_Click(object sender, EventArgs e)
        {

        }
    }
}