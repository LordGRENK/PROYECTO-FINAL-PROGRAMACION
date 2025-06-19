using System;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class AgregarUsuario : Form
    { 
        private readonly agregarUsuarioTabla _bd; // Instancia de la clase agregarUsuarioTabla
        public AgregarUsuario()
        {
            InitializeComponent();
            lbTitulo.Text = "AGREGAR USUARIO GISEL";
            _bd = new agregarUsuarioTabla(); // Inicializa la instancia de agregarUsuarioTabla
        }
        public AgregarUsuario(agregarUsuarioTabla agregarUsuario)
        {
            InitializeComponent();
            lbTitulo.Text = "AGREGAR USUARIO GISEL";
            llenarCampos(agregarUsuario);
        }
        private void llenarCampos(agregarUsuarioTabla agregarUsuario)
        {
            tbNombreUsuario.Text = agregarUsuario.nombreUsuario; // Corregido: Asignar valores a los campos de texto
            tbDireccionUsuario.Text = agregarUsuario.direccionUsuario;
            tbTelefonoUsuario.Text = agregarUsuario.telefonoUsuario;
            tbEmailUsuario.Text = agregarUsuario.emailUsuario;
        }
        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            var agregarUsuario = new agregarUsuarioTabla
            {
                nombreUsuario = tbNombreUsuario.Text,
                direccionUsuario = tbDireccionUsuario.Text,
                telefonoUsuario = tbTelefonoUsuario.Text,
                emailUsuario = tbEmailUsuario.Text
            };
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }
    }
}
