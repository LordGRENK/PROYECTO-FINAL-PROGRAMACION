using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    public partial class IngresarServicioUsuario : Form
    {
        private readonly GISELEntities _bd; 
        public IngresarServicioUsuario()
        {
            InitializeComponent();
            _bd = new GISELEntities(); 

            var servicios = _bd.agregarServicioEléctrico
                .Select(s => s.nombredelServicio)
                .ToList();
            cbServicios.DataSource = servicios;

            cbServicios.SelectedIndexChanged += cbServicios_SelectedIndexChanged;
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbIdUsuario.Text.Trim(), out int idUsuario))
            {
                var usuario = _bd.agregarUsuarioTabla.FirstOrDefault(u => u.id == idUsuario);
                if (usuario != null)
                {
                    lblNombreUsuario.Text = usuario.nombreUsuario; 
                }
                else
                {
                    lblNombreUsuario.Text = "Usuario no encontrado";
                }
            }
            else
            {
                lblNombreUsuario.Text = "ID inválido";
            }
        }

        private void btnSubiryGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdUsuario.Text.Trim(), out int idUsuario))
            {
                MessageBox.Show("Por favor, ingrese un ID de usuario válido y numérico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioExistente = _bd.agregarUsuarioTabla.FirstOrDefault(u => u.id == idUsuario);
            if (usuarioExistente == null)
            {
                MessageBox.Show("El usuario con el ID proporcionado no existe. Por favor, verifique el ID.", "Usuario no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblNombreUsuario.Text = "Usuario no encontrado"; 
                return; 
            }

            if (cbServicios.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un servicio eléctrico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string voltajeTexto = lblEscrituraVoltaje.Text.Replace("V", "").Trim();
            if (!int.TryParse(voltajeTexto, out int voltaje))
            {
                MessageBox.Show("No se pudo obtener un voltaje válido para el servicio seleccionado.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var agregarServicio = new ingresarServicio
            {
                id = idUsuario, 
                usuarioServicio = usuarioExistente.nombreUsuario,
                servicioAnexado = cbServicios.SelectedItem.ToString(),
                voltajeServicio = voltaje
            };

            _bd.ingresarServicio.Add(agregarServicio);
            _bd.SaveChanges();
            MessageBox.Show("Servicio con NIS " + idUsuario + " asignado al usuario '" + usuarioExistente.nombreUsuario + "' correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); 
        }

        private void cbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nombreServicio = cbServicios.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(nombreServicio))
            {
                var servicio = _bd.agregarServicioEléctrico
                    .FirstOrDefault(s => s.nombredelServicio == nombreServicio);

                if (servicio != null && servicio.voltajedelServicio.HasValue)
                {
                    lblEscrituraVoltaje.Text = servicio.voltajedelServicio.Value + "V";
                }
                else
                {
                    lblEscrituraVoltaje.Text = "N/A";
                }
            }
            else
            {
                lblEscrituraVoltaje.Text = "";
            }
        }

        private void label7_Click(object sender, EventArgs e) { }
        private void IngresarServicioUsuario_Load(object sender, EventArgs e) { }
    }
}