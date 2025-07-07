using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class CostoKw_h : Form
    {
        private readonly GISELEntities _bd; // Instancia de la clase agregarUsuarioTabla
        public CostoKw_h()
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
        public CostoKw_h(CostoKw_h costoKw_h)
        {
            InitializeComponent();
            llenarCampos(costoKw_h);
        }
        private void llenarCampos(CostoKw_h costoKw_h)
        {
            nudAño = costoKw_h.nudAño; // Asignar valores a los campos de texto
            nudMes = costoKw_h.nudMes;
            tbPrimeros25kWh = costoKw_h.tbPrimeros25kWh;
            cbEmpresa = costoKw_h.cbEmpresa;
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
                Primeros25kWh = decimal.Parse(tbPrimeros25kWh.Text),
                Siguientes25kWh = decimal.Parse(tbSig25kWh.Text),
                Siguientes50kWh1 = decimal.Parse(tbSig50kWh1.Text),
                Siguientes50kWh2 = decimal.Parse(tbSig50kWh2.Text),
                Siguientes350kWh = decimal.Parse(tbSig350kWh.Text),
                Siguientes500kWh = decimal.Parse(tb500kWh.Text),
                Adicionalesa1000kWh = decimal.Parse(tbAdi1000kWh.Text),
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
