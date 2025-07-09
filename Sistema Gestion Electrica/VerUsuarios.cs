using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class VerUsuarios : Form
    {
        private readonly GISELEntities _bd; 
        public VerUsuarios()
        {
            InitializeComponent();
            _bd = new GISELEntities();
        }

        private void dgvUsuariosGisel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            var usuarios = _bd.agregarUsuarioTabla.ToList();
            gvUsuariosGisel.DataSource = usuarios;
            gvUsuariosGisel.Columns["id"].HeaderText = "ID"; 
            gvUsuariosGisel.Columns["nombreUsuario"].HeaderText = "Nombre de Usuario";
            gvUsuariosGisel.Columns["direccionUsuario"].HeaderText = "Dirección";
            gvUsuariosGisel.Columns["telefonoUsuario"].HeaderText = "Teléfono";
            gvUsuariosGisel.Columns["emailUsuario"].HeaderText = "Email";
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var agregarUsuario = new AgregarUsuario();
            agregarUsuario.MdiParent = PaginaPrincipal.ActiveForm; 
            agregarUsuario.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var eliminarUsuario = gvUsuariosGisel.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (eliminarUsuario != null)
            {
                int idUsuario = Convert.ToInt32(eliminarUsuario.Cells["id"].Value);
                var usuario = _bd.agregarUsuarioTabla.Find(idUsuario);
                if (usuario != null)
                {
                    _bd.agregarUsuarioTabla.Remove(usuario);
                    _bd.SaveChanges();
                    MessageBox.Show("Usuario eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvUsuariosGisel.DataSource = _bd.agregarUsuarioTabla.ToList();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var editarUsuario = gvUsuariosGisel.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (editarUsuario != null)
            {
                int idUsuario = Convert.ToInt32(editarUsuario.Cells["id"].Value);
                var usuario = _bd.agregarUsuarioTabla.Find(idUsuario);
                if (usuario != null)
                {
                    var agregarUsuario = new AgregarUsuario(usuario); 
                    agregarUsuario.MdiParent = PaginaPrincipal.ActiveForm; 
                    agregarUsuario.Show();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblVerUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
