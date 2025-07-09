using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class FacturaConsumo : Form
    {
        private readonly TablaFacturas _factura;
        private readonly string _direccion; 

        public FacturaConsumo(TablaFacturas factura, string direccion)
        {
            InitializeComponent();
            _factura = factura;
            _direccion = direccion; 
            CargarDatosFactura();
        }

        private void CargarDatosFactura()
        {
            if (_factura != null)
            {
                lblNumeroDeServicioAQUI.Text = _factura.NIS.ToString();
                lblNombreDeUsuarioAQUI.Text = _factura.NombreUsuario;
                lblDireccionUsuarioAQUI.Text = _direccion; 
                

                decimal kwhConsumidos = _factura.KwhTotalAPagar ?? 0;
                decimal precioPorKwh = _factura.PrecioKwhPorMes ?? 0;
                decimal costoAlumbrado = _factura.PrecioAlumbradoPublicoTotal ?? 0;
                decimal costoComercializacion = _factura.PrecioFijoComercialicación ?? 0;

                lblkWhConsumidosAQUI.Text = kwhConsumidos.ToString("N2") + " kWh";
                lblkWhMesAQUI.Text = precioPorKwh.ToString("N2");
                lblAlumbradoPublicoAQUI.Text = costoAlumbrado.ToString("N2");
                lblComercializaciónAQUI.Text = costoComercializacion.ToString("N2");
                lblFechaAQUI.Text = DateTime.Now.ToString("dd/MM/yyyy");

                decimal costoConsumoKwh = kwhConsumidos * precioPorKwh;
                decimal subtotal_1 = costoConsumoKwh + costoAlumbrado + costoComercializacion;

                decimal subsidio = 0;
                if (kwhConsumidos > 0 && kwhConsumidos <= 50) { subsidio = costoConsumoKwh * 0.50m; }
                else if (kwhConsumidos > 50 && kwhConsumidos <= 100) { subsidio = costoConsumoKwh * 0.45m; }
                else if (kwhConsumidos > 100 && kwhConsumidos <= 150) { subsidio = costoConsumoKwh * 0.25m; }
                lblSubsidioAQUI.Text = subsidio.ToString("N2");

                decimal subtotal_2 = subtotal_1 - subsidio;
                decimal impuestoINE = subtotal_2 * 0.00064m;
                label4.Text = impuestoINE.ToString("N2");

                decimal totalAPagar = subtotal_2 + impuestoINE;
                TotalAQUI.Text = totalAPagar.ToString("N2");
            }
        }
        public void GuardarComoImagen(string rutaArchivo)
        {
            Control panel = this.panel1;

            using (Bitmap bmp = new Bitmap(panel.Width, panel.Height))
            {
                panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.Width, panel.Height));

                bmp.Save(rutaArchivo, ImageFormat.Png);
            }
        }

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