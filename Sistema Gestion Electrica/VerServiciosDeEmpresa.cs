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
            // 1. Cargar los datos en el DataGridView
            gvServiciosGisel.DataSource = _bd.agregarServicioEléctrico.ToList();

            // 2. Cambiar los nombres de las cabeceras de las columnas
            gvServiciosGisel.Columns["id"].HeaderText = "NIS";
            gvServiciosGisel.Columns["nombredelServicio"].HeaderText = "Servicio";
            gvServiciosGisel.Columns["voltajedelServicio"].HeaderText = "Voltaje (V)";
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            var ingresarServicioElectrico = new IngresarServicioElectrico();
            ingresarServicioElectrico.MdiParent = this.MdiParent; // Asigna el padre
            ingresarServicioElectrico.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que haya una fila seleccionada
            if (gvServiciosGisel.SelectedRows.Count > 0)
            {
                // Obtiene el ID (NIS) de la fila seleccionada
                int idServicio = Convert.ToInt32(gvServiciosGisel.SelectedRows[0].Cells["id"].Value);

                var servicio = _bd.ingresarServicio.Find(idServicio);
                if (servicio != null)
                {
                    _bd.ingresarServicio.Remove(servicio);
                    _bd.SaveChanges();
                    // Refresca la tabla para mostrar los cambios
                    gvServiciosGisel.DataSource = _bd.ingresarServicio.ToList();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        // --- Métodos sin cambios ---
        private void gvServiciosGisel_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblVerServicio_Click(object sender, EventArgs e) { }
    }
}