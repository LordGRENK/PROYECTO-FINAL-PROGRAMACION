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
    public partial class CostoPorComercialización : Form
    {
        private readonly GISELEntities _bd; // Instancia de la clase agregarUsuarioTabla
        public CostoPorComercialización()
        {
            InitializeComponent();
            _bd = new GISELEntities(); // Inicializa la instancia de agregarUsuarioTabla

            // Llenar cbEmpresa con los nombres de servicio eléctrico
            using (var db = new GISELEntities())
            {
                var servicios = db.agregarServicioEléctrico
                    .Select(s => s.nombredelServicio)
                    .ToList();
                cbEmpresa.DataSource = servicios;
            }
        }
        public CostoPorComercialización(CostoPorComercialización costoAlumbradoPublico)
        {
            InitializeComponent();
            llenarCampos(costoAlumbradoPublico);
        }
        private void llenarCampos(CostoPorComercialización costoAlumbradoPublico)
        {
            nudAño = costoAlumbradoPublico.nudAño; 
            nudMes = costoAlumbradoPublico.nudMes;
            tb0a25kWh = costoAlumbradoPublico.tb0a25kWh;
            tb26a60kWh = costoAlumbradoPublico.tb26a60kWh;
            tb51s100kWh = costoAlumbradoPublico.tb51s100kWh;
            tb101a150kWh = costoAlumbradoPublico.tb101a150kWh;
            tb151a500kWh = costoAlumbradoPublico.tb151a500kWh;
            tb501a1000kWh = costoAlumbradoPublico.tb501a1000kWh;
            tbMayorde1000kWh = costoAlumbradoPublico.tbMayorde1000kWh;
            cbEmpresa = costoAlumbradoPublico.cbEmpresa;
        }
        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            var precioAlumbradoPublico = new PrecioAlumbradoPublico
            {
                Año = (int)nudAño.Value,
                Mes = (int)nudMes.Value,
                De0a25kWh = decimal.Parse(tb0a25kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                De101a150kWh = decimal.Parse(tb26a60kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                De151a500kWh = decimal.Parse(tb51s100kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                De26a50kWh = decimal.Parse(tb101a150kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                De501a1000kWh = decimal.Parse(tb151a500kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                De51a100kWh = decimal.Parse(tb501a1000kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                Mayorde1000kWh = decimal.Parse(tbMayorde1000kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                Compañia = cbEmpresa.SelectedItem.ToString()
            };
            _bd.PrecioAlumbradoPublico.Add(precioAlumbradoPublico);
            _bd.SaveChanges();
            MessageBox.Show("Costo por kWh agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void tbPrimeros25kWh_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb500kWh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
