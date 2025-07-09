using System;
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
            var verServiciosDeEmpresa = new VerServiciosDeEmpresa();
           verServiciosDeEmpresa.MdiParent = this;
            verServiciosDeEmpresa.Show();
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
            Application.Exit();
            Environment.Exit(0); 
        }

        private void verServiciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var verServicios = new VerServiciosDelUsuario();
            verServicios.MdiParent = this;
            verServicios.Show();
        }

        private void agregarCostoAlumbradoPublicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var costoAlumbrado = new CostoAlumbradoPublico();
            costoAlumbrado.MdiParent = this;
            costoAlumbrado.Show();
        }

        private void agregarCostoComercializaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var costoComercializacion = new CostoPorComercialización();
            costoComercializacion.MdiParent = this;
            costoComercializacion.Show();
        }

        private void verHistorialDeConsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var verHistorialConsumos = new VerConsumos();
            verHistorialConsumos.MdiParent = this;
            verHistorialConsumos.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


    }
}
