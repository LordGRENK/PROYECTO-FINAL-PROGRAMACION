namespace Sistema_Gestion_Electrica
{
    partial class CalcularCostos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNIS = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCompañía = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.tbNIS = new System.Windows.Forms.TextBox();
            this.lblUsuarioCAMBIA = new System.Windows.Forms.Label();
            this.lblCompañíaCAMBIA = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAñadirConsumo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalcularFacturacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(59, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(401, 33);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Facturación de Consumo Eléctrico";
            // 
            // lblNIS
            // 
            this.lblNIS.AutoSize = true;
            this.lblNIS.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIS.Location = new System.Drawing.Point(99, 70);
            this.lblNIS.Name = "lblNIS";
            this.lblNIS.Size = new System.Drawing.Size(65, 33);
            this.lblNIS.TabIndex = 14;
            this.lblNIS.Text = "NIS:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(99, 111);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(114, 33);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblCompañía
            // 
            this.lblCompañía.AutoSize = true;
            this.lblCompañía.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompañía.Location = new System.Drawing.Point(75, 154);
            this.lblCompañía.Name = "lblCompañía";
            this.lblCompañía.Size = new System.Drawing.Size(138, 33);
            this.lblCompañía.TabIndex = 16;
            this.lblCompañía.Text = "Compañía:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(19, 253);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(194, 33);
            this.lblMes.TabIndex = 17;
            this.lblMes.Text = "Seleccione Mes:";
            this.lblMes.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbNIS
            // 
            this.tbNIS.Location = new System.Drawing.Point(202, 80);
            this.tbNIS.Margin = new System.Windows.Forms.Padding(4);
            this.tbNIS.Name = "tbNIS";
            this.tbNIS.Size = new System.Drawing.Size(132, 22);
            this.tbNIS.TabIndex = 20;
            // 
            // lblUsuarioCAMBIA
            // 
            this.lblUsuarioCAMBIA.AutoSize = true;
            this.lblUsuarioCAMBIA.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCAMBIA.Location = new System.Drawing.Point(230, 111);
            this.lblUsuarioCAMBIA.Name = "lblUsuarioCAMBIA";
            this.lblUsuarioCAMBIA.Size = new System.Drawing.Size(105, 33);
            this.lblUsuarioCAMBIA.TabIndex = 28;
            this.lblUsuarioCAMBIA.Text = "Usuario";
            // 
            // lblCompañíaCAMBIA
            // 
            this.lblCompañíaCAMBIA.AutoSize = true;
            this.lblCompañíaCAMBIA.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompañíaCAMBIA.Location = new System.Drawing.Point(230, 154);
            this.lblCompañíaCAMBIA.Name = "lblCompañíaCAMBIA";
            this.lblCompañíaCAMBIA.Size = new System.Drawing.Size(129, 33);
            this.lblCompañíaCAMBIA.TabIndex = 29;
            this.lblCompañíaCAMBIA.Text = "Compañía";
            this.lblCompañíaCAMBIA.Click += new System.EventHandler(this.lblCompañíaCAMBIA_Click);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(20, 203);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(193, 33);
            this.lblAño.TabIndex = 31;
            this.lblAño.Text = "Seleccione Año:";
            // 
            // cbAño
            // 
            this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(236, 213);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(132, 24);
            this.cbAño.TabIndex = 32;
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(236, 263);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(132, 24);
            this.cbMes.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(353, 70);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 37);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAñadirConsumo
            // 
            this.btnAñadirConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirConsumo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirConsumo.Location = new System.Drawing.Point(379, 203);
            this.btnAñadirConsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirConsumo.Name = "btnAñadirConsumo";
            this.btnAñadirConsumo.Size = new System.Drawing.Size(130, 81);
            this.btnAñadirConsumo.TabIndex = 35;
            this.btnAñadirConsumo.Text = "Añadir Consumo";
            this.btnAñadirConsumo.UseVisualStyleBackColor = true;
            this.btnAñadirConsumo.Click += new System.EventHandler(this.btnAñadirConsumo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(300, 311);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 43);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalcularFacturacion
            // 
            this.btnCalcularFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularFacturacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFacturacion.Location = new System.Drawing.Point(25, 311);
            this.btnCalcularFacturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcularFacturacion.Name = "btnCalcularFacturacion";
            this.btnCalcularFacturacion.Size = new System.Drawing.Size(217, 43);
            this.btnCalcularFacturacion.TabIndex = 25;
            this.btnCalcularFacturacion.Text = "Calcular y Guardar";
            this.btnCalcularFacturacion.UseVisualStyleBackColor = true;
            this.btnCalcularFacturacion.Click += new System.EventHandler(this.btnCalcularFacturacion_Click);
            // 
            // CalcularCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 374);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAñadirConsumo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbAño);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblCompañíaCAMBIA);
            this.Controls.Add(this.lblUsuarioCAMBIA);
            this.Controls.Add(this.btnCalcularFacturacion);
            this.Controls.Add(this.tbNIS);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblCompañía);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNIS);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalcularCostos";
            this.Text = "Facturación de Consumo Eléctrico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNIS;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCompañía;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox tbNIS;
        private System.Windows.Forms.Label lblUsuarioCAMBIA;
        private System.Windows.Forms.Label lblCompañíaCAMBIA;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAñadirConsumo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcularFacturacion;
    }
}