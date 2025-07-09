using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace Sistema_Gestion_Electrica
{
    public partial class CostoAlumbradoPublico : Form
    {
        private readonly GISELEntities _bd;

        public CostoAlumbradoPublico()
        {
            InitializeComponent();
            _bd = new GISELEntities();


            using (var db = new GISELEntities())
            {
                var servicios = db.agregarServicioEléctrico
                    .Select(s => s.nombredelServicio)
                    .ToList();
                cbEmpresa.DataSource = servicios;
            }


            tb0a25kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tb26a60kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tb51s100kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tb101a150kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tb151a500kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tb501a1000kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tbMayorde1000kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
        }

        private void textBox_KeyPress_Decimal(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {

            var campos = new[] { tb0a25kWh, tb26a60kWh, tb51s100kWh, tb101a150kWh, tb151a500kWh, tb501a1000kWh, tbMayorde1000kWh };
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.Text) || !decimal.TryParse(campo.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor) || valor <= 0)
                {
                    MessageBox.Show($"El valor en el campo '{campo.Name}' no es válido. Debe ser un número positivo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var año = (int)nudAño.Value;
            var mes = (int)nudMes.Value;
            var compañia = cbEmpresa.SelectedItem.ToString();


            var costoExistente = _bd.PrecioAlumbradoPublico.FirstOrDefault(p => p.Año == año && p.Mes == mes && p.Compañia == compañia);

            if (costoExistente != null)
            {

                var result = MessageBox.Show("Ya existe un registro de alumbrado para este mes, año y compañía. ¿Desea reemplazarlo?", "Registro Duplicado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    costoExistente.De0a25kWh = decimal.Parse(tb0a25kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.De26a50kWh = decimal.Parse(tb26a60kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.De51a100kWh = decimal.Parse(tb51s100kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.De101a150kWh = decimal.Parse(tb101a150kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.De151a500kWh = decimal.Parse(tb151a500kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.De501a1000kWh = decimal.Parse(tb501a1000kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.Mayorde1000kWh = decimal.Parse(tbMayorde1000kWh.Text, CultureInfo.InvariantCulture);

                    _bd.SaveChanges();
                    MessageBox.Show("Costo de alumbrado público actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {

                var precioAlumbradoPublico = new PrecioAlumbradoPublico
                {
                    Año = año,
                    Mes = mes,
                    De0a25kWh = decimal.Parse(tb0a25kWh.Text, CultureInfo.InvariantCulture),
                    De26a50kWh = decimal.Parse(tb26a60kWh.Text, CultureInfo.InvariantCulture),
                    De51a100kWh = decimal.Parse(tb51s100kWh.Text, CultureInfo.InvariantCulture),
                    De101a150kWh = decimal.Parse(tb101a150kWh.Text, CultureInfo.InvariantCulture),
                    De151a500kWh = decimal.Parse(tb151a500kWh.Text, CultureInfo.InvariantCulture),
                    De501a1000kWh = decimal.Parse(tb501a1000kWh.Text, CultureInfo.InvariantCulture),
                    Mayorde1000kWh = decimal.Parse(tbMayorde1000kWh.Text, CultureInfo.InvariantCulture),
                    Compañia = compañia
                };
                _bd.PrecioAlumbradoPublico.Add(precioAlumbradoPublico);
                _bd.SaveChanges();
                MessageBox.Show("Costo de alumbrado público agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        public CostoAlumbradoPublico(CostoAlumbradoPublico costoAlumbradoPublico)
        {
            InitializeComponent();
            llenarCampos(costoAlumbradoPublico);
        }
        private void llenarCampos(CostoAlumbradoPublico costoAlumbradoPublico)
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

        private void lbTitulo_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void tbPrimeros25kWh_TextChanged(object sender, EventArgs e) { }
        private void tb500kWh_TextChanged(object sender, EventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}