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
    public partial class ConteoConsumoUsuario : Form
    {
        private readonly GISELEntities _bd; // Instancia de la clase agregarUsuarioTabla

        public ConteoConsumoUsuario()
        {
            InitializeComponent();
            _bd = new GISELEntities(); // Inicializa la instancia de agregarUsuarioTabla
        }
        public ConteoConsumoUsuario(ConteoConsumoUsuario conteoConsumoUsuario)
        {
            InitializeComponent();
            llenarCampos(conteoConsumoUsuario);
        }
        private void llenarCampos(ConteoConsumoUsuario conteoConsumoUsuario)
        {
            tbNIS = conteoConsumoUsuario.tbNIS; // Asignar valores a los campos de texto
            nudAño.Text = conteoConsumoUsuario.nudAño.Text;
            nudMes.Text = conteoConsumoUsuario.nudMes.Text;
            tbKiloWattsConsumidos.Text = conteoConsumoUsuario.tbKiloWattsConsumidos.Text;
        }




        private void btnBuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que el campo NIS no esté vacío y sea un número válido
            if (string.IsNullOrWhiteSpace(tbNIS.Text) || !int.TryParse(tbNIS.Text, out int nis))
            {
                MessageBox.Show("Por favor, ingrese un NIS válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar si existe el NIS en la tabla ingresarServicio
            var existeNIS = _bd.ingresarServicio.Any(s => s.id == nis);

            if (existeNIS)
            {
                MessageBox.Show("El NIS existe en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var conteoConsumo = new ConteoConsumoTabla()
            {
                NIS = Convert.ToInt32(tbNIS.Text),
                Año = Convert.ToInt32(nudAño.Text),
                Mes = Convert.ToInt32(nudMes.Text),
                KilowattsHora = Convert.ToDouble(tbKiloWattsConsumidos.Text) // Asegúrate de que el nombre esté correcto
            };

            _bd.ConteoConsumoTabla.Add(conteoConsumo);
            _bd.SaveChanges();

            MessageBox.Show("Conteo de consumo agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }
    }
}
