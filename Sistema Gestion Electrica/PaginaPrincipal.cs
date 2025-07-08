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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        private void agregarCostoKwhDelMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var costoKw = new CostoKw_h();
            costoKw.MdiParent = this;
            costoKw.Show();
        }

        private void agregarConteoConsumoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conteoConsumo = new ConteoConsumoUsuario();
            conteoConsumo.MdiParent = this;
            conteoConsumo.Show();
        }

        private void ingresarServicioElectricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ingresarServicio = new IngresarServicioElectrico();
            ingresarServicio.MdiParent = this;
            ingresarServicio.Show();
        }



        private void ingresarServicioAUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ingresarServicio = new IngresarServicioUsuario();
            ingresarServicio.MdiParent = this;
            ingresarServicio.Show();
        }

        private void calcularCostoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calcular = new CalcularCostos();
            calcular.MdiParent = this;
            calcular.Show();
        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editarUsuario = new VerUsuarios();
            editarUsuario.MdiParent = this;
            editarUsuario.Show();
        }

        private void gESTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
            Environment.Exit(0); // Asegura que la aplicación se cierre completamente
        }

        private void verServiciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var verServicios = new VerServicios();
            verServicios.MdiParent = this;
            verServicios.Show();
        }

        private void agregarCostoAlumbradoPublicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var costoAlumbrado = new CostoAlumbradoPublico();
            costoAlumbrado.MdiParent = this;
            costoAlumbrado.Show();
        }
    }
}
