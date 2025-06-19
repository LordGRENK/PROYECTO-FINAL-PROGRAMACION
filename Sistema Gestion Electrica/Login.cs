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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private int intentos = 0;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsuario.Text))
            {
                MessageBox.Show("El campo de usuario está vacío. Por favor, ingrese un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbContraseña.Text))
            {
                MessageBox.Show("El campo de contraseña está vacío. Por favor, ingrese una contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            intentos++;

            if (tbUsuario.Text == "admin")
            {
                if (tbContraseña.Text == "password")
                {
                    var paginaPrincipal = new PaginaPrincipal();
                    paginaPrincipal.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (intentos >= 3)
            {
                MessageBox.Show("POR FAVOR INTENTE MÁS TARDE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                Environment.Exit(0);
            }
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
