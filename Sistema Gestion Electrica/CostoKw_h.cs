using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace Sistema_Gestion_Electrica
{
    public partial class CostoKw_h : Form
    {
        private readonly GISELEntities _bd; 

        public CostoKw_h()
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

            
            tbPrimeros25kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tbSig25kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tbSig50kWh1.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tbSig50kWh2.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tbSig350kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tb500kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
            tbAdi1000kWh.KeyPress += new KeyPressEventHandler(textBox_KeyPress_Decimal);
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
            
            var campos = new[] { tbPrimeros25kWh, tbSig25kWh, tbSig50kWh1, tbSig50kWh2, tbSig350kWh, tb500kWh, tbAdi1000kWh };
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

            
            var costoExistente = _bd.PrecioKwhPorMes.FirstOrDefault(p => p.Año == año && p.Mes == mes && p.Compañia == compañia);

            if (costoExistente != null)
            {
            
                var result = MessageBox.Show("Ya existe un registro de costos para este mes, año y compañía. ¿Desea reemplazarlo?", "Registro Duplicado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
            
                    costoExistente.Primeros25kWh = decimal.Parse(tbPrimeros25kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.Siguientes25kWh = decimal.Parse(tbSig25kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.Siguientes50kWh1 = decimal.Parse(tbSig50kWh1.Text, CultureInfo.InvariantCulture);
                    costoExistente.Siguientes50kWh2 = decimal.Parse(tbSig50kWh2.Text, CultureInfo.InvariantCulture);
                    costoExistente.Siguientes350kWh = decimal.Parse(tbSig350kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.Siguientes500kWh = decimal.Parse(tb500kWh.Text, CultureInfo.InvariantCulture);
                    costoExistente.Adicionalesa1000kWh = decimal.Parse(tbAdi1000kWh.Text, CultureInfo.InvariantCulture);

                    _bd.SaveChanges();
                    MessageBox.Show("Costo por kWh actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
            
                var costoKw_h = new PrecioKwhPorMes
                {
                    Año = año,
                    Mes = mes,
                    Primeros25kWh = decimal.Parse(tbPrimeros25kWh.Text, CultureInfo.InvariantCulture),
                    Siguientes25kWh = decimal.Parse(tbSig25kWh.Text, CultureInfo.InvariantCulture),
                    Siguientes50kWh1 = decimal.Parse(tbSig50kWh1.Text, CultureInfo.InvariantCulture),
                    Siguientes50kWh2 = decimal.Parse(tbSig50kWh2.Text, CultureInfo.InvariantCulture),
                    Siguientes350kWh = decimal.Parse(tbSig350kWh.Text, CultureInfo.InvariantCulture),
                    Siguientes500kWh = decimal.Parse(tb500kWh.Text, CultureInfo.InvariantCulture),
                    Adicionalesa1000kWh = decimal.Parse(tbAdi1000kWh.Text, CultureInfo.InvariantCulture),
                    Compañia = compañia
                };
                _bd.PrecioKwhPorMes.Add(costoKw_h);
                _bd.SaveChanges();
                MessageBox.Show("Costo por kWh agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        
        private void lbTitulo_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void tbPrimeros25kWh_TextChanged(object sender, EventArgs e) { }
        private void tb500kWh_TextChanged(object sender, EventArgs e) { }
        private void tbSig25kWh_TextChanged(object sender, EventArgs e) { }
        private void tbSig50kWh1_TextChanged(object sender, EventArgs e) { }
        private void tbSig50kWh2_TextChanged(object sender, EventArgs e) { }
        private void tbSig350kWh_TextChanged(object sender, EventArgs e) { }
        private void tbAdi1000kWh_TextChanged(object sender, EventArgs e) { }
    }
}