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
    public partial class IngresarServicioUsuario : Form
    {
        private readonly GISELEntities _bd; // Instancia de la clase GISELEntities para acceder a la base de datos
        public IngresarServicioUsuario()
        {
            InitializeComponent();
            _bd = new GISELEntities(); // Inicializa la instancia de GISELEntities

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbIdUsuario.Text.Trim(), out int idUsuario))
            {
                var usuario = _bd.agregarUsuarioTabla.FirstOrDefault(u => u.id == idUsuario);
                if (usuario != null)
                {
                    lblNombreUsuario.Text = usuario.nombreUsuario; // Muestra el nombre del usuario en el label
                }
                else
                {
                    lblNombreUsuario.Text = "Usuario no encontrado";
                }
            }
            else
            {
                lblNombreUsuario.Text = "ID inválido";
            }
        }
    }
}
