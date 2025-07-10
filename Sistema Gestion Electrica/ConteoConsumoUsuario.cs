using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace Sistema_Gestion_Electrica
{
    public partial class ConteoConsumoUsuario : Form
    {
        private readonly GISELEntities _bd;

        public ConteoConsumoUsuario()
        {
            InitializeComponent();
            _bd = new GISELEntities();
            tbKiloWattsConsumidos.KeyPress += new KeyPressEventHandler(tbKiloWattsConsumidos_KeyPress);
            tbNIS.KeyPress += new KeyPressEventHandler(tbNIS_KeyPress);
        }

        public ConteoConsumoUsuario(ConteoConsumoUsuario conteoConsumoUsuario)
        {
            InitializeComponent();
            llenarCampos(conteoConsumoUsuario);
        }
        private void llenarCampos(ConteoConsumoUsuario conteoConsumoUsuario)
        {
            tbNIS.Text = conteoConsumoUsuario.tbNIS.Text;
            nudAño.Value = conteoConsumoUsuario.nudAño.Value;
            nudMes.Value = conteoConsumoUsuario.nudMes.Value;
            tbKiloWattsConsumidos.Text = conteoConsumoUsuario.tbKiloWattsConsumidos.Text;
        }

        private void btnBuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNIS.Text) || !int.TryParse(tbNIS.Text, out int nis))
            {
                MessageBox.Show("Por favor, ingrese un NIS válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var servicio = _bd.ingresarServicio.FirstOrDefault(s => s.id == nis);

            if (servicio != null)
            {
                MessageBox.Show($"El NIS pertenece al usuario: {servicio.usuarioServicio}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El NIS no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNIS.Text) || string.IsNullOrWhiteSpace(tbKiloWattsConsumidos.Text))
            {
                MessageBox.Show("Los campos NIS y KiloWatts Consumidos no pueden estar vacíos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbNIS.Text, out int nis) || nis < 0)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico positivo y válido para NIS.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nisExistente = _bd.ingresarServicio.Any(s => s.id == nis);
            if (!nisExistente)
            {
                MessageBox.Show("El NIS ingresado no está registrado en la base de datos. Por favor, verifíquelo.", "NIS no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (!decimal.TryParse(tbKiloWattsConsumidos.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal kilowatts) || kilowatts < 0)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico positivo y válido para KiloWatts.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var año = Convert.ToInt32(nudAño.Value);
            var mes = Convert.ToInt32(nudMes.Value);

            var conteoExistente = _bd.ConteoConsumoTabla.FirstOrDefault(c => c.NIS == nis && c.Año == año && c.Mes == mes);

            if (conteoExistente != null)
            {
                var resultado = MessageBox.Show("Ya existe un registro para este NIS, año y mes. ¿Desea reemplazarlo?", "Registro Duplicado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    conteoExistente.KilowattsHora = (double?)kilowatts;
                    _bd.SaveChanges();
                    MessageBox.Show("Conteo de consumo actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                var conteoConsumo = new ConteoConsumoTabla()
                {
                    NIS = nis,
                    Año = año,
                    Mes = mes,
                    KilowattsHora = (double?)kilowatts
                };

                _bd.ConteoConsumoTabla.Add(conteoConsumo);
                _bd.SaveChanges();

                MessageBox.Show("Conteo de consumo agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbKiloWattsConsumidos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbNIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}