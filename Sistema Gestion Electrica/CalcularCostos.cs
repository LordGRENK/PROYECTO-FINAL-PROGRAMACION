using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Sistema_Gestion_Electrica
{
    public partial class CalcularCostos : Form
    {
        public CalcularCostos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void lblCompañíaCAMBIA_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nis = tbNIS.Text.Trim();
            if (string.IsNullOrEmpty(nis))
            {
                MessageBox.Show("Por favor, ingrese un NIS válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(nis, out int nisInt))
            {
                MessageBox.Show("El NIS debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new GISELEntities())
            {
                // 1. Llenar cbAño y cbMes desde ConteoConsumoTabla
                var consumos = db.ConteoConsumoTabla
                    .Where(c => c.NIS == nisInt)
                    .ToList();

                if (consumos.Count == 0)
                {
                    MessageBox.Show("No se encontraron consumos para el NIS ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbAño.DataSource = null;
                    cbMes.DataSource = null;
                    lblUsuarioCAMBIA.Text = "";
                    lblCompañíaCAMBIA.Text = "";
                    return;
                }

                cbAño.DataSource = consumos
                    .Select(c => c.Año)
                    .Distinct()
                    .OrderBy(a => a)
                    .ToList();

                cbMes.DataSource = consumos
                    .Select(c => c.Mes)
                    .Distinct()
                    .OrderBy(m => m)
                    .ToList();

                // 2. Buscar usuario y compañía en ingresarServicio
                var servicio = db.ingresarServicio
                    .FirstOrDefault(s => s.id == nisInt); // Cambiado de "NIS" a "id"

                if (servicio != null)
                {
                    lblUsuarioCAMBIA.Text = servicio.usuarioServicio;
                    lblCompañíaCAMBIA.Text = servicio.servicioAnexado;
                }
                else
                {
                    lblUsuarioCAMBIA.Text = "No encontrado";
                    lblCompañíaCAMBIA.Text = "No encontrado";
                }
            }
        }

        private void btnAñadirConsumo_Click(object sender, EventArgs e)
        {

        }
    }
}
