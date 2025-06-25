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
    public partial class EditarUsuario : Form
    {
        private readonly GISELEntities _bd;
        public EditarUsuario()
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
            agregarUsuario.MdiParent = PaginaPrincipal.ActiveForm; // Establece el formulario padre como la página principal
            agregarUsuario.Show();
            gvUsuariosGisel.DataSource = _bd.agregarUsuarioTabla.ToList(); // Actualiza la lista de usuarios después de agregar uno nuevo
        }
    }
}
