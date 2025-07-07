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
    public partial class CostoAlumbradoPublico : Form
    {
        private readonly GISELEntities _bd; // Instancia de la clase agregarUsuarioTabla
        public CostoAlumbradoPublico()
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
        public CostoAlumbradoPublico(CostoAlumbradoPublico costoAlumbradoPublico)
        {
            InitializeComponent();
            llenarCampos(costoAlumbradoPublico);
        }
        private void llenarCampos(CostoAlumbradoPublico costoAlumbradoPublico)
        {
            nudAño = costoAlumbradoPublico.nudAño; // Asignar valores a los campos de texto
            nudMes = costoAlumbradoPublico.nudMes;
            tb0a25kWh = costoAlumbradoPublico.tb0a25kWh;
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
            var costoKw_h = new PrecioKwhPorMes
            {
                Año = (int)nudAño.Value,
                Mes = (int)nudMes.Value,
                Primeros25kWh = decimal.Parse(tb0a25kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                Siguientes25kWh = decimal.Parse(tb26a60kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                Siguientes50kWh1 = decimal.Parse(tb51s100kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                Siguientes50kWh2 = decimal.Parse(tb101a150kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                Siguientes350kWh = decimal.Parse(tb151a500kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                Siguientes500kWh = decimal.Parse(tb501a1000kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                Adicionalesa1000kWh = decimal.Parse(tbMayorde1000kWh.Text.Replace(',', '.'), CultureInfo.InvariantCulture),
                Compañia = cbEmpresa.SelectedItem.ToString()
            };
            _bd.PrecioKwhPorMes.Add(costoKw_h);
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
