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
            this.tbVoltajeServicio = new System.Windows.Forms.TextBox();
            this.lblVoltaje = new System.Windows.Forms.Label();
            this.tbIngresarServicioEléctrico = new System.Windows.Forms.TextBox();
            this.tbCompañiaEléctrica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompañiaEléctrica = new System.Windows.Forms.Label();
            this.gbEstadodelServicio = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnGuardarServicio = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbEstadodelServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbVoltajeServicio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblVoltaje, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbIngresarServicioEléctrico, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbCompañiaEléctrica, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCompañiaEléctrica, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbEstadodelServicio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 210);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbVoltajeServicio
            // 
            this.tbVoltajeServicio.Location = new System.Drawing.Point(192, 159);
            this.tbVoltajeServicio.Name = "tbVoltajeServicio";
            this.tbVoltajeServicio.Size = new System.Drawing.Size(100, 20);
            this.tbVoltajeServicio.TabIndex = 13;
            // 
            // lblVoltaje
            // 
            this.lblVoltaje.AutoSize = true;
            this.lblVoltaje.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltaje.Location = new System.Drawing.Point(2, 156);
            this.lblVoltaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoltaje.Name = "lblVoltaje";
            this.lblVoltaje.Size = new System.Drawing.Size(72, 23);
            this.lblVoltaje.TabIndex = 12;
            this.lblVoltaje.Text = "Voltaje:";
            // 
            // tbIngresarServicioEléctrico
            // 
            this.tbIngresarServicioEléctrico.Location = new System.Drawing.Point(192, 3);
            this.tbIngresarServicioEléctrico.Name = "tbIngresarServicioEléctrico";
            this.tbIngresarServicioEléctrico.Size = new System.Drawing.Size(100, 20);
            this.tbIngresarServicioEléctrico.TabIndex = 10;
            // 
            // tbCompañiaEléctrica
            // 
            this.tbCompañiaEléctrica.Location = new System.Drawing.Point(192, 107);
            this.tbCompañiaEléctrica.Name = "tbCompañiaEléctrica";
            this.tbCompañiaEléctrica.Size = new System.Drawing.Size(100, 20);
            this.tbCompañiaEléctrica.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Servicio:";
            // 
            // lblCompañiaEléctrica
            // 
            this.lblCompañiaEléctrica.AutoSize = true;
            this.lblCompañiaEléctrica.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompañiaEléctrica.Location = new System.Drawing.Point(2, 104);
            this.lblCompañiaEléctrica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompañiaEléctrica.Name = "lblCompañiaEléctrica";
            this.lblCompañiaEléctrica.Size = new System.Drawing.Size(171, 23);
            this.lblCompañiaEléctrica.TabIndex = 7;
            this.lblCompañiaEléctrica.Text = "Compañía Eléctrica:";
            // 
            // gbEstadodelServicio
            // 
            this.gbEstadodelServicio.Controls.Add(this.rbInactivo);
            this.gbEstadodelServicio.Controls.Add(this.rbActivo);
            this.gbEstadodelServicio.Location = new System.Drawing.Point(192, 55);
            this.gbEstadodelServicio.Name = "gbEstadodelServicio";
            this.gbEstadodelServicio.Size = new System.Drawing.Size(136, 46);
            this.gbEstadodelServicio.TabIndex = 11;
            this.gbEstadodelServicio.TabStop = false;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(67, 22);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbInactivo.TabIndex = 1;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(6, 22);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado del Servicio:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(57, 9);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(313, 35);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "Añadir Servicio Eléctrico";
            // 
            // btnGuardarServicio
            // 
            this.btnGuardarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarServicio.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarServicio.Location = new System.Drawing.Point(105, 262);
            this.btnGuardarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(236, 49);
            this.btnGuardarServicio.TabIndex = 14;
            this.btnGuardarServicio.Text = "Aceptar y Guardar";
            this.btnGuardarServicio.UseVisualStyleBackColor = true;
            this.btnGuardarServicio.Click += new System.EventHandler(this.btnGuardarServicio_Click);
            // 
            // IngresarServicioElectrico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 334);
            this.Controls.Add(this.btnGuardarServicio);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IngresarServicioElectrico";
            this.Text = "AñadirServicioEléctrico";
            this.Load += new System.EventHandler(this.IngresarServicioElectrico_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbEstadodelServicio.ResumeLayout(false);
            this.gbEstadodelServicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCompañiaEléctrica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompañiaEléctrica;
        private System.Windows.Forms.TextBox tbIngresarServicioEléctrico;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnGuardarServicio;
        private System.Windows.Forms.GroupBox gbEstadodelServicio;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label lblVoltaje;
        private System.Windows.Forms.TextBox tbVoltajeServicio;
    }
}