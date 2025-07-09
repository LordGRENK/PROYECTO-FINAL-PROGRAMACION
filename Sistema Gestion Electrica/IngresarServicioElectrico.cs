using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class IngresarServicioElectrico : Form
    {
        private readonly GISELEntities _bd;
        public IngresarServicioElectrico()
        {
            InitializeComponent();
            _bd = new GISELEntities();
        }
        public IngresarServicioElectrico(IngresarServicioElectrico ingresarServicioElectrico)
        {
            InitializeComponent();
            llenarCampos(ingresarServicioElectrico);
        }
        private void llenarCampos(IngresarServicioElectrico ingresarServicioElectrico)
        {
            tbIngresarServicioEléctrico = ingresarServicioElectrico.tbCompañiaEléctrica;
            tbCompañiaEléctrica = ingresarServicioElectrico.tbCompañiaEléctrica;
            tbVoltajeServicio = ingresarServicioElectrico.tbVoltajeServicio;
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            var soloLetras = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s]+$");

            if (!soloLetras.IsMatch(tbIngresarServicioEléctrico.Text))
            {
                MessageBox.Show("El nombre del servicio solo puede contener letras y acentos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!soloLetras.IsMatch(tbCompañiaEléctrica.Text))
            {
                MessageBox.Show("El nombre de la compañía solo puede contener letras y acentos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string voltaje = tbVoltajeServicio.Text;
            if (voltaje != "110" && voltaje != "120" && voltaje != "240")
            {
                MessageBox.Show("El voltaje del servicio debe ser 110, 120 o 240.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ingresarServicioElectrico = new agregarServicioEléctrico
            {
                nombredelServicio = tbIngresarServicioEléctrico.Text,
                voltajedelServicio = Convert.ToInt32(tbVoltajeServicio.Text)
            };
            _bd.agregarServicioEléctrico.Add(ingresarServicioElectrico);
            _bd.SaveChanges();
            MessageBox.Show("Servicio agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IngresarServicioElectrico_Load(object sender, EventArgs e)
        {

        }

        private void gbEstadodelServicio_Enter(object sender, EventArgs e)
        {

        }

        private void tbIngresarServicioEléctrico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}