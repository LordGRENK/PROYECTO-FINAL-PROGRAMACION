namespace Sistema_Gestion_Electrica
{
    partial class IngresarServicioElectrico
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVoltaje = new System.Windows.Forms.Label();
            this.tbIngresarServicioEléctrico = new System.Windows.Forms.TextBox();
            this.tbCompañiaEléctrica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompañiaEléctrica = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnGuardarServicio = new System.Windows.Forms.Button();
            this.tbVoltajeServicio = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbIngresarServicioEléctrico, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCompañiaEléctrica, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbCompañiaEléctrica, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblVoltaje, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbVoltajeServicio, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 58);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 258);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblVoltaje
            // 
            this.lblVoltaje.AutoSize = true;
            this.lblVoltaje.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltaje.Location = new System.Drawing.Point(3, 172);
            this.lblVoltaje.Name = "lblVoltaje";
            this.lblVoltaje.Size = new System.Drawing.Size(90, 29);
            this.lblVoltaje.TabIndex = 12;
            this.lblVoltaje.Text = "Voltaje:";
            // 
            // tbIngresarServicioEléctrico
            // 
            this.tbIngresarServicioEléctrico.Location = new System.Drawing.Point(256, 4);
            this.tbIngresarServicioEléctrico.Margin = new System.Windows.Forms.Padding(4);
            this.tbIngresarServicioEléctrico.Name = "tbIngresarServicioEléctrico";
            this.tbIngresarServicioEléctrico.Size = new System.Drawing.Size(132, 22);
            this.tbIngresarServicioEléctrico.TabIndex = 10;
            this.tbIngresarServicioEléctrico.TextChanged += new System.EventHandler(this.tbIngresarServicioEléctrico_TextChanged);
            // 
            // tbCompañiaEléctrica
            // 
            this.tbCompañiaEléctrica.Location = new System.Drawing.Point(256, 90);
            this.tbCompañiaEléctrica.Margin = new System.Windows.Forms.Padding(4);
            this.tbCompañiaEléctrica.Name = "tbCompañiaEléctrica";
            this.tbCompañiaEléctrica.Size = new System.Drawing.Size(132, 22);
            this.tbCompañiaEléctrica.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Servicio:";
            // 
            // lblCompañiaEléctrica
            // 
            this.lblCompañiaEléctrica.AutoSize = true;
            this.lblCompañiaEléctrica.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompañiaEléctrica.Location = new System.Drawing.Point(3, 86);
            this.lblCompañiaEléctrica.Name = "lblCompañiaEléctrica";
            this.lblCompañiaEléctrica.Size = new System.Drawing.Size(212, 29);
            this.lblCompañiaEléctrica.TabIndex = 7;
            this.lblCompañiaEléctrica.Text = "Compañía Eléctrica:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(76, 11);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(388, 43);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "Añadir Servicio Eléctrico";
            // 
            // btnGuardarServicio
            // 
            this.btnGuardarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarServicio.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarServicio.Location = new System.Drawing.Point(140, 322);
            this.btnGuardarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(315, 60);
            this.btnGuardarServicio.TabIndex = 14;
            this.btnGuardarServicio.Text = "Aceptar y Guardar";
            this.btnGuardarServicio.UseVisualStyleBackColor = true;
            this.btnGuardarServicio.Click += new System.EventHandler(this.btnGuardarServicio_Click);
            // 
            // tbVoltajeServicio
            // 
            this.tbVoltajeServicio.CausesValidation = false;
            this.tbVoltajeServicio.Location = new System.Drawing.Point(256, 176);
            this.tbVoltajeServicio.Margin = new System.Windows.Forms.Padding(4);
            this.tbVoltajeServicio.Name = "tbVoltajeServicio";
            this.tbVoltajeServicio.Size = new System.Drawing.Size(132, 22);
            this.tbVoltajeServicio.TabIndex = 13;
            // 
            // IngresarServicioElectrico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 411);
            this.Controls.Add(this.btnGuardarServicio);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IngresarServicioElectrico";
            this.Text = "AñadirServicioEléctrico";
            this.Load += new System.EventHandler(this.IngresarServicioElectrico_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCompañiaEléctrica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompañiaEléctrica;
        private System.Windows.Forms.TextBox tbIngresarServicioEléctrico;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnGuardarServicio;
        private System.Windows.Forms.Label lblVoltaje;
        private System.Windows.Forms.TextBox tbVoltajeServicio;
    }
}