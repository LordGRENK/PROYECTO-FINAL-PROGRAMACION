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
    public partial class VerConsumos : Form
    {
        private readonly GISELEntities _bd; // Instancia de la clase agregarUsuarioTabla
        public VerConsumos()
        {
            InitializeComponent();
            _bd = new GISELEntities();
        }

        private void dgvUsuariosGisel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            var consumos = _bd.ConteoConsumoTabla.ToList(); // Obtiene la lista de servicios eléctricos
            gvConsumosGisel.DataSource = consumos; // Asigna la lista de servicios al DataGridView
            if (gvConsumosGisel.Columns["id"] != null)
            {
                gvConsumosGisel.Columns["id"].Visible = false;
            }
            tbNIS.Text = "Ingresar NIS";
            tbNIS.ForeColor = Color.Gray;
            /*
            gvUsuariosGisel.DataSource = usuarios;
            gvUsuariosGisel.Columns["id"].HeaderText = "ID"; 
            gvUsuariosGisel.Columns["nombreUsuario"].HeaderText = "Nombre de Usuario";
            gvUsuariosGisel.Columns["direccionUsuario"].HeaderText = "Dirección";
            gvUsuariosGisel.Columns["telefonoUsuario"].HeaderText = "Teléfono";
            gvUsuariosGisel.Columns["emailUsuario"].HeaderText = "Email";*/
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var agregarUsuario = new AgregarUsuario();
            agregarUsuario.MdiParent = PaginaPrincipal.ActiveForm; // Establece el formulario padre como la página principal
            agregarUsuario.Show();
           
        }
        private void lblVerUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void tbNIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNIS_Enter(object sender, EventArgs e)
        {
            if (tbNIS.Text == "Ingresar NIS")
            {
                tbNIS.Text = "";
                tbNIS.ForeColor = Color.Black; // Opcional si el texto inicial es gris
            }
        }

        private void tbNIS_Leave(object sender, EventArgs e)
        {
            if (tbNIS.Text == "")
            {
                tbNIS.Text = "Ingresar NIS";
                tbNIS.ForeColor = Color.Gray; // Para que se note que es texto de ayuda
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que el NIS ingresado sea un número válido
            if (int.TryParse(tbNIS.Text, out int nis))
            {
                var consumosFiltrados = _bd.ConteoConsumoTabla
                    .Where(c => c.NIS == nis)
                    .ToList();

                gvConsumosGisel.DataSource = consumosFiltrados;

                // Oculta la columna 'id' si existe
                if (gvConsumosGisel.Columns["id"] != null)
                {
                    gvConsumosGisel.Columns["id"].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un NIS válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var conteoConsumo = new ConteoConsumoUsuario();
            conteoConsumo.Show();
        }
    }
}
