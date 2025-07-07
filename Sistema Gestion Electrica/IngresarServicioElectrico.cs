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
    public partial class IngresarServicioElectrico : Form
    {
        private readonly GISELEntities _bd; // Instancia de la clase agregarUsuarioTabla
        public IngresarServicioElectrico()
        {
            InitializeComponent();
            _bd = new GISELEntities(); // Inicializa la instancia de agregarUsuarioTabla
        }
        public IngresarServicioElectrico( IngresarServicioElectrico ingresarServicioElectrico)
        {
            InitializeComponent();
            llenarCampos(ingresarServicioElectrico);
        }
        private void llenarCampos(IngresarServicioElectrico ingresarServicioElectrico)
        {
            tbIngresarServicioEléctrico = ingresarServicioElectrico.tbCompañiaEléctrica; // Asignar valores a los campos de texto
            tbCompañiaEléctrica = ingresarServicioElectrico.tbCompañiaEléctrica;
            tbVoltajeServicio = ingresarServicioElectrico.tbVoltajeServicio;
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            var ingresarServicioElectrico = new agregarServicioEléctrico
            {
                nombredelServicio = tbIngresarServicioEléctrico.Text,
                // estadodelServicio eliminado
                compañiadelServicio = tbCompañiaEléctrica.Text,
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
