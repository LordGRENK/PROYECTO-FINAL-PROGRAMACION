namespace Sistema_Gestion_Electrica
{
    partial class IngresarServicioUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubiryGuardar = new System.Windows.Forms.Button();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.lblEscrituraVoltaje = new System.Windows.Forms.Label();
            this.cbServicios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(64, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(550, 58);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Asignar Servicio a Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese su ID:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(239, 137);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(114, 33);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Qué servicio desea anexar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "Voltaje:";
            // 
            // btnSubiryGuardar
            // 
            this.btnSubiryGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubiryGuardar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubiryGuardar.Location = new System.Drawing.Point(136, 294);
            this.btnSubiryGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubiryGuardar.Name = "btnSubiryGuardar";
            this.btnSubiryGuardar.Size = new System.Drawing.Size(427, 43);
            this.btnSubiryGuardar.TabIndex = 18;
            this.btnSubiryGuardar.Text = "SUBIR Y GUARDAR";
            this.btnSubiryGuardar.UseVisualStyleBackColor = true;
            this.btnSubiryGuardar.Click += new System.EventHandler(this.btnSubiryGuardar_Click);
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Location = new System.Drawing.Point(375, 89);
            this.tbIdUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(132, 22);
            this.tbIdUsuario.TabIndex = 19;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(368, 137);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(105, 33);
            this.lblNombreUsuario.TabIndex = 24;
            this.lblNombreUsuario.Text = "Usuario";
            this.lblNombreUsuario.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarId.Location = new System.Drawing.Point(529, 82);
            this.btnBuscarId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(139, 34);
            this.btnBuscarId.TabIndex = 26;
            this.btnBuscarId.Text = "BUSCAR";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // lblEscrituraVoltaje
            // 
            this.lblEscrituraVoltaje.AutoSize = true;
            this.lblEscrituraVoltaje.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscrituraVoltaje.Location = new System.Drawing.Point(368, 236);
            this.lblEscrituraVoltaje.Name = "lblEscrituraVoltaje";
            this.lblEscrituraVoltaje.Size = new System.Drawing.Size(0, 33);
            this.lblEscrituraVoltaje.TabIndex = 27;
            // 
            // cbServicios
            // 
            this.cbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicios.FormattingEnabled = true;
            this.cbServicios.Location = new System.Drawing.Point(375, 196);
            this.cbServicios.Margin = new System.Windows.Forms.Padding(4);
            this.cbServicios.Name = "cbServicios";
            this.cbServicios.Size = new System.Drawing.Size(160, 24);
            this.cbServicios.TabIndex = 22;
            // 
            // IngresarServicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 374);
            this.Controls.Add(this.lblEscrituraVoltaje);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.cbServicios);
            this.Controls.Add(this.tbIdUsuario);
            this.Controls.Add(this.btnSubiryGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IngresarServicioUsuario";
            this.Text = "AsignarServicioUsuario";
            this.Load += new System.EventHandler(this.IngresarServicioUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubiryGuardar;
        private System.Windows.Forms.TextBox tbIdUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Label lblEscrituraVoltaje;
        private System.Windows.Forms.ComboBox cbServicios;
    }
}