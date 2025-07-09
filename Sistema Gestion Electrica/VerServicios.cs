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
    public partial class VerServicios : Form
    {
        private readonly GISELEntities _bd; // Instancia de la clase agregarUsuarioTabla
        public VerServicios()
        {
            InitializeComponent();
            _bd = new GISELEntities();
        }

        private void dgvUsuariosGisel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            var servicios = _bd.ingresarServicio.ToList(); // Obtiene la lista de servicios eléctricos
            gvServiciosGisel.DataSource = servicios; // Asigna la lista de servicios al DataGridView

            /*
            gvUsuariosGisel.DataSource = usuarios;
            gvUsuariosGisel.Columns["id"].HeaderText = "ID"; 
            gvUsuariosGisel.Columns["nombreUsuario"].HeaderText = "Nombre de Usuario";
            gvUsuariosGisel.Columns["direccionUsuario"].HeaderText = "Dirección";
            gvUsuariosGisel.Columns["telefonoUsuario"].HeaderText = "Teléfono";
            gvUsuariosGisel.Columns["emailUsuario"].HeaderText = "Email";*/
        }

        

        // Reemplaza este método en tu archivo VerServicios.cs
        private void button2_Click(object sender, EventArgs e)
        {
            // ELIMINAR SERVICIO
            var filaSeleccionada = gvServiciosGisel.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (filaSeleccionada != null)
            {
                // Se obtiene el ID del servicio (NIS) de la fila seleccionada.
                int idServicio = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                // Se busca el servicio en la tabla 'ingresarServicio'.
                var servicio = _bd.ingresarServicio.Find(idServicio);

                if (servicio != null)
                {
                    _bd.ingresarServicio.Remove(servicio);
                    _bd.SaveChanges();
                    MessageBox.Show("Servicio eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar la tabla para mostrar los cambios
                    gvServiciosGisel.DataSource = _bd.ingresarServicio.ToList();
                }
                else
                {
                    // Este mensaje ya no debería aparecer, pero es una buena práctica mantenerlo.
                    MessageBox.Show("Servicio no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Reemplaza este método también.
        private void lblVerUsuario_Click(object sender, EventArgs e)
        {

        }



        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            var ingresarServicio = new IngresarServicioUsuario();
            ingresarServicio.Show();
        }
    }
}
