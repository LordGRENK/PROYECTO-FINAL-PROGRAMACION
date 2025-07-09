using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class VerServiciosDelUsuario : Form
    {
        private readonly GISELEntities _bd; 
        public VerServiciosDelUsuario()
        {
            InitializeComponent();
            _bd = new GISELEntities();
        }

        private void dgvUsuariosGisel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            var servicios = _bd.ingresarServicio.ToList(); 
            gvServiciosGisel.DataSource = servicios; 
            gvServiciosGisel.Columns["id"].HeaderText = "NIS";
            gvServiciosGisel.Columns["usuarioServicio"].HeaderText = "Usuario";
            gvServiciosGisel.Columns["servicioAnexado"].HeaderText = "Servicio";
            gvServiciosGisel.Columns["voltajeServicio"].HeaderText = "Voltaje (V)";
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = gvServiciosGisel.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (filaSeleccionada != null)
            {
                int idServicio = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                var servicio = _bd.ingresarServicio.Find(idServicio);

                if (servicio != null)
                {
                    _bd.ingresarServicio.Remove(servicio);
                    _bd.SaveChanges();
                    MessageBox.Show("Servicio eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gvServiciosGisel.DataSource = _bd.ingresarServicio.ToList();
                }
                else
                {
                    MessageBox.Show("Servicio no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblVerUsuario_Click(object sender, EventArgs e)
        {

        }



        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            var ingresarServicio = new IngresarServicioUsuario();
            ingresarServicio.MdiParent = PaginaPrincipal.ActiveForm; 
            ingresarServicio.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
