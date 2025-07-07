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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUsuarioCAMBIA = new System.Windows.Forms.Label();
            this.lblCompañíaCAMBIA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Calculadora de Consumo Eléctrico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "NIS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Compañía:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Seleccione Mes:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 20;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(177, 266);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(167, 43);
            this.btnIniciarSesion.TabIndex = 25;
            this.btnIniciarSesion.Text = "Calcular";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enero",
            "",
            "",
            "Febrero",
            "",
            "",
            "Marzo",
            "",
            "",
            "Abril",
            "",
            "",
            "Mayo",
            "",
            "",
            "Junio",
            "",
            "",
            "Julio",
            "",
            "",
            "Agosto",
            "",
            "",
            "Septiembre",
            "",
            "",
            "Octubre",
            "",
            "",
            "Noviembre",
            "",
            "",
            "Diciembre"});
            this.comboBox1.Location = new System.Drawing.Point(232, 201);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 27;
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
            // 
            // CalcularCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 428);
            this.Controls.Add(this.lblCompañíaCAMBIA);
            this.Controls.Add(this.lblUsuarioCAMBIA);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalcularCostos";
            this.Text = "CalcularCostos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblUsuarioCAMBIA;
        private System.Windows.Forms.Label lblCompañíaCAMBIA;
    }
}