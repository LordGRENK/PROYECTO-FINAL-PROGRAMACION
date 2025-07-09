using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class ConteoConsumoUsuario : Form
    {
        private readonly GISELEntities _bd; 

        public ConteoConsumoUsuario()
        {
            InitializeComponent();
            _bd = new GISELEntities(); 
        }
        public ConteoConsumoUsuario(ConteoConsumoUsuario conteoConsumoUsuario)
        {
            InitializeComponent();
            llenarCampos(conteoConsumoUsuario);
        }
        private void llenarCampos(ConteoConsumoUsuario conteoConsumoUsuario)
        {
            tbNIS = conteoConsumoUsuario.tbNIS; 
            nudAño.Text = conteoConsumoUsuario.nudAño.Text;
            nudMes.Text = conteoConsumoUsuario.nudMes.Text;
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

            if (!int.TryParse(tbNIS.Text, out int nis) || !double.TryParse(tbKiloWattsConsumidos.Text, out double kilowatts))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para NIS y KiloWatts.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var año = Convert.ToInt32(nudAño.Text);
            var mes = Convert.ToInt32(nudMes.Text);

           
            var conteoExistente = _bd.ConteoConsumoTabla.FirstOrDefault(c => c.NIS == nis && c.Año == año && c.Mes == mes);

            if (conteoExistente != null)
            {
           
                var resultado = MessageBox.Show("Ya existe un registro para este NIS, año y mes. ¿Desea reemplazarlo?", "Registro Duplicado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
           
                    conteoExistente.KilowattsHora = kilowatts;
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
                    KilowattsHora = kilowatts 
                };

                _bd.ConteoConsumoTabla.Add(conteoConsumo);
                _bd.SaveChanges();

                MessageBox.Show("Conteo de consumo agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}