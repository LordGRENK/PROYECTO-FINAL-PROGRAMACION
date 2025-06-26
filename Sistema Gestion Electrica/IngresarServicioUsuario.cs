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

            // Llenar ComboBox de servicios
            var servicios = _bd.agregarServicioEléctrico
                .Select(s => s.nombredelServicio)
                .ToList();
            cbServicios.DataSource = servicios;

            cbServicios.SelectedIndexChanged += cbServicios_SelectedIndexChanged;
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

        private void btnSubiryGuardar_Click(object sender, EventArgs e)
        {
            var agregarServicio = new ingresarServicio
            {

                usuarioServicio = lblNombreUsuario.Text,
                servicioAnexado = cbServicios.SelectedItem.ToString(), 
                voltajeServicio = lblEscrituraVoltaje.Text
            }; 
            _bd.ingresarServicio.Add(agregarServicio); // Agrega el nuevo servicio a la base de datos
            _bd.SaveChanges();
            MessageBox.Show("Usuario agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nombreServicio = cbServicios.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(nombreServicio))
            {
                var servicio = _bd.agregarServicioEléctrico
                    .FirstOrDefault(s => s.nombredelServicio == nombreServicio);

                if (servicio != null && servicio.voltajedelServicio.HasValue)
                {
                    lblEscrituraVoltaje.Text = servicio.voltajedelServicio.Value + "V";
                }
                else
                {
                    lblEscrituraVoltaje.Text = "N/A";
                }
            }
            else
            {
                lblEscrituraVoltaje.Text = "";
            }
        }

        private void IngresarServicioUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
