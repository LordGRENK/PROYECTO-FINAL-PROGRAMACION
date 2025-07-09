using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class VerServiciosDeEmpresa : Form
    {
        private readonly GISELEntities _bd;
        public VerServiciosDeEmpresa()
        {
            InitializeComponent();
            _bd = new GISELEntities();
        }

        private void VerServiciosDeEmpresa_Load(object sender, EventArgs e)
        {
            gvServiciosGisel.DataSource = _bd.agregarServicioEléctrico.ToList();

            gvServiciosGisel.Columns["id"].HeaderText = "NIS";
            gvServiciosGisel.Columns["nombredelServicio"].HeaderText = "Servicio";
            gvServiciosGisel.Columns["voltajedelServicio"].HeaderText = "Voltaje (V)";
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            var ingresarServicioElectrico = new IngresarServicioElectrico();
            ingresarServicioElectrico.MdiParent = this.MdiParent; 
            ingresarServicioElectrico.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvServiciosGisel.SelectedRows.Count > 0)
            {
                int idServicio = Convert.ToInt32(gvServiciosGisel.SelectedRows[0].Cells["id"].Value);

                var servicio = _bd.agregarServicioEléctrico.Find(idServicio);
                if (servicio != null)
                {
                    _bd.agregarServicioEléctrico.Remove(servicio);
                    _bd.SaveChanges();
                    gvServiciosGisel.DataSource = _bd.agregarServicioEléctrico.ToList();
                    MessageBox.Show("Servicio eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();         }

        private void gvServiciosGisel_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblVerServicio_Click(object sender, EventArgs e) { }
    }
}