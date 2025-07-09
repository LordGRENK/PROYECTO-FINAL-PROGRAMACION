using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class VerConsumos : Form
    {
        private readonly GISELEntities _bd; 
        public VerConsumos()
        {
            InitializeComponent();
            _bd = new GISELEntities();
        }

        private void dgvUsuariosGisel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            var consumos = _bd.ConteoConsumoTabla.ToList(); 
            gvConsumosGisel.DataSource = consumos;
            if (gvConsumosGisel.Columns["id"] != null)
            {
                gvConsumosGisel.Columns["id"].Visible = false;
            }
            tbNIS.Text = "Filtrar Usuarios (NIS)";
            tbNIS.ForeColor = Color.Gray;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var agregarUsuario = new AgregarUsuario();
            agregarUsuario.MdiParent = PaginaPrincipal.ActiveForm;
            agregarUsuario.Show();
           
        }
        private void lblVerUsuario_Click(object sender, EventArgs e)
        {

        }



        private void tbNIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNIS_Enter(object sender, EventArgs e)
        {
            if (tbNIS.Text == "Filtrar Usuarios (NIS)")
            {
                tbNIS.Text = "";
                tbNIS.ForeColor = Color.Black; 
            }
        }

        private void tbNIS_Leave(object sender, EventArgs e)
        {
            if (tbNIS.Text == "")
            {
                tbNIS.Text = "Filtrar Usuarios (NIS)";
                tbNIS.ForeColor = Color.Gray; 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbNIS.Text, out int nis))
            {
                var consumosFiltrados = _bd.ConteoConsumoTabla
                    .Where(c => c.NIS == nis)
                    .ToList();

                gvConsumosGisel.DataSource = consumosFiltrados;

                if (gvConsumosGisel.Columns["id"] != null)
                {
                    gvConsumosGisel.Columns["id"].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un NIS válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var conteoConsumo = new ConteoConsumoUsuario();
            conteoConsumo.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarNuevoConsumo_Click(object sender, EventArgs e)
        {
            var conteoConsumo = new ConteoConsumoUsuario();
            conteoConsumo.MdiParent = PaginaPrincipal.ActiveForm; 
            conteoConsumo.Show();
        }
    }
}
