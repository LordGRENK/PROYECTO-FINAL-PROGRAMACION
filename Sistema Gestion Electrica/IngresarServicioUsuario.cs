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
    public partial class IngresarServicioUsuario : Form
    {
        private readonly GISELEntities _bd; // Instancia para acceder a la base de datos

        public IngresarServicioUsuario()
        {
            InitializeComponent();
            _bd = new GISELEntities(); // Inicializa la instancia de GISELEntities

            // Llenar ComboBox de servicios desde la base de datos
            var servicios = _bd.agregarServicioEléctrico
                .Select(s => s.nombredelServicio)
                .ToList();
            cbServicios.DataSource = servicios;

            // Asignar el evento para actualizar el voltaje cuando cambia la selección
            cbServicios.SelectedIndexChanged += cbServicios_SelectedIndexChanged;
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbIdUsuario.Text.Trim(), out int idUsuario))
            {
                var usuario = _bd.agregarUsuarioTabla.FirstOrDefault(u => u.id == idUsuario);
                if (usuario != null)
                {
                    lblNombreUsuario.Text = usuario.nombreUsuario; // Muestra el nombre del usuario
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
            // 1. Validar que el ID del usuario sea un número válido.
            if (!int.TryParse(tbIdUsuario.Text.Trim(), out int idUsuario))
            {
                MessageBox.Show("Por favor, ingrese un ID de usuario válido y numérico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Verificar que el usuario exista en la base de datos.
            var usuarioExistente = _bd.agregarUsuarioTabla.FirstOrDefault(u => u.id == idUsuario);
            if (usuarioExistente == null)
            {
                MessageBox.Show("El usuario con el ID proporcionado no existe. Por favor, verifique el ID.", "Usuario no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblNombreUsuario.Text = "Usuario no encontrado"; // Actualiza la UI
                return; // Detiene la ejecución para no guardar.
            }

            // 3. Validar que se haya seleccionado un servicio.
            if (cbServicios.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un servicio eléctrico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Validar y convertir el voltaje.
            string voltajeTexto = lblEscrituraVoltaje.Text.Replace("V", "").Trim();
            if (!int.TryParse(voltajeTexto, out int voltaje))
            {
                MessageBox.Show("No se pudo obtener un voltaje válido para el servicio seleccionado.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Si todo es correcto, crear y guardar el nuevo servicio.
            var agregarServicio = new ingresarServicio
            {
                id = idUsuario, // Se asigna el ID del usuario como NIS.
                usuarioServicio = usuarioExistente.nombreUsuario,
                servicioAnexado = cbServicios.SelectedItem.ToString(),
                voltajeServicio = voltaje
            };

            _bd.ingresarServicio.Add(agregarServicio);
            _bd.SaveChanges();
            MessageBox.Show("Servicio con NIS " + idUsuario + " asignado al usuario '" + usuarioExistente.nombreUsuario + "' correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Cierra el formulario tras guardar.
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

        // --- Métodos de eventos no utilizados ---
        private void label7_Click(object sender, EventArgs e) { }
        private void IngresarServicioUsuario_Load(object sender, EventArgs e) { }
    }
}