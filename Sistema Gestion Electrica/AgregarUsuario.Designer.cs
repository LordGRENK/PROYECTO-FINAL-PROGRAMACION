namespace Sistema_Gestion_Electrica
{
    partial class AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbEmailUsuario = new System.Windows.Forms.TextBox();
            this.tbDireccionUsuario = new System.Windows.Forms.TextBox();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.tbEmailUsuario, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbDireccionUsuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNombreUsuario, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbTelefonoUsuario, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 64);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 160);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tbEmailUsuario
            // 
            this.tbEmailUsuario.Location = new System.Drawing.Point(164, 124);
            this.tbEmailUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmailUsuario.Name = "tbEmailUsuario";
            this.tbEmailUsuario.Size = new System.Drawing.Size(471, 22);
            this.tbEmailUsuario.TabIndex = 12;
            this.tbEmailUsuario.TextChanged += new System.EventHandler(this.tbEmailUsuario_TextChanged);
            // 
            // tbDireccionUsuario
            // 
            this.tbDireccionUsuario.Location = new System.Drawing.Point(164, 44);
            this.tbDireccionUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbDireccionUsuario.Name = "tbDireccionUsuario";
            this.tbDireccionUsuario.Size = new System.Drawing.Size(471, 22);
            this.tbDireccionUsuario.TabIndex = 11;
            this.tbDireccionUsuario.TextChanged += new System.EventHandler(this.tbDireccionUsuario_TextChanged);
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(164, 4);
            this.tbNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(471, 22);
            this.tbNombreUsuario.TabIndex = 10;
            this.tbNombreUsuario.TextChanged += new System.EventHandler(this.tbNombreUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // tbTelefonoUsuario
            // 
            this.tbTelefonoUsuario.Location = new System.Drawing.Point(164, 84);
            this.tbTelefonoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefonoUsuario.Name = "tbTelefonoUsuario";
            this.tbTelefonoUsuario.Size = new System.Drawing.Size(471, 22);
            this.tbTelefonoUsuario.TabIndex = 9;
            this.tbTelefonoUsuario.TextChanged += new System.EventHandler(this.tbTelefonoUsuario_TextChanged);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(231, 27);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(240, 33);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "AGREGAR USUARIO";
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Location = new System.Drawing.Point(31, 249);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(317, 43);
            this.btnGuardarUsuario.TabIndex = 13;
            this.btnGuardarUsuario.Text = "Guardar Cambios";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(375, 249);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(317, 43);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 312);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTelefonoUsuario;
        private System.Windows.Forms.TextBox tbEmailUsuario;
        private System.Windows.Forms.TextBox tbDireccionUsuario;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Button btnCancelar;
    }
}