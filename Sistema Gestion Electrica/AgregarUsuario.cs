using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class AgregarUsuario : Form
    {
        private readonly GISELEntities _bd; // Instancia de la clase agregarUsuarioTabla
        private agregarUsuarioTabla _usuarioExistente; // Campo para almacenar el usuario a editar

        public AgregarUsuario()
        {
            InitializeComponent();
            lbTitulo.Text = "AGREGAR USUARIO GISEL";
            _bd = new GISELEntities(); // Inicializa la instancia de agregarUsuarioTabla
        }

        public AgregarUsuario(agregarUsuarioTabla agregarUsuario)
        {
            InitializeComponent();
            lbTitulo.Text = "EDITAR USUARIO GISEL";
            _bd = new GISELEntities();
            _usuarioExistente = agregarUsuario;
            llenarCampos(agregarUsuario);
        }

        private void llenarCampos(agregarUsuarioTabla agregarUsuario)
        {
            tbNombreUsuario.Text = agregarUsuario.nombreUsuario;
            tbDireccionUsuario.Text = agregarUsuario.direccionUsuario;
            tbTelefonoUsuario.Text = agregarUsuario.telefonoUsuario;
            tbEmailUsuario.Text = agregarUsuario.emailUsuario;
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            // Validaciones con Regex
            if (!Regex.IsMatch(tbNombreUsuario.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚ\s]+$"))
            {
                MessageBox.Show("El nombre de usuario solo puede contener letras y acentos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(tbDireccionUsuario.Text, @"^[a-zA-Z0-9\s.]+$"))
            {
                MessageBox.Show("La dirección solo puede contener letras, números y puntos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(tbTelefonoUsuario.Text, @"^\d{8}$"))
            {
                MessageBox.Show("El teléfono debe contener exactamente 8 dígitos numéricos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(tbEmailUsuario.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_usuarioExistente != null)
            {
                // Editar usuario existente
                var usuario = _bd.agregarUsuarioTabla.Find(_usuarioExistente.id);
                if (usuario != null)
                {
                    usuario.nombreUsuario = tbNombreUsuario.Text;
                    usuario.direccionUsuario = tbDireccionUsuario.Text;
                    usuario.telefonoUsuario = tbTelefonoUsuario.Text;
                    usuario.emailUsuario = tbEmailUsuario.Text;
                    _bd.SaveChanges();
                    MessageBox.Show("Usuario editado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Agregar nuevo usuario
                var agregarUsuario = new agregarUsuarioTabla
                {
                    nombreUsuario = tbNombreUsuario.Text,
                    direccionUsuario = tbDireccionUsuario.Text,
                    telefonoUsuario = tbTelefonoUsuario.Text,
                    emailUsuario = tbEmailUsuario.Text
                };
                _bd.agregarUsuarioTabla.Add(agregarUsuario);
                _bd.SaveChanges();
                MessageBox.Show("Usuario agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void tbNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDireccionUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTelefonoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmailUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}