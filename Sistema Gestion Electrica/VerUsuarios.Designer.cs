namespace Sistema_Gestion_Electrica
{
    partial class VerUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUsuarios));
            this.lblVerUsuario = new System.Windows.Forms.Label();
            this.gvUsuariosGisel = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuariosGisel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerUsuario
            // 
            this.lblVerUsuario.AutoSize = true;
            this.lblVerUsuario.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerUsuario.Location = new System.Drawing.Point(185, 9);
            this.lblVerUsuario.Name = "lblVerUsuario";
            this.lblVerUsuario.Size = new System.Drawing.Size(508, 63);
            this.lblVerUsuario.TabIndex = 12;
            this.lblVerUsuario.Text = "VER USUARIOS GISEL";
            this.lblVerUsuario.Click += new System.EventHandler(this.lblVerUsuario_Click);
            // 
            // gvUsuariosGisel
            // 
            this.gvUsuariosGisel.AllowUserToAddRows = false;
            this.gvUsuariosGisel.AllowUserToDeleteRows = false;
            this.gvUsuariosGisel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsuariosGisel.Location = new System.Drawing.Point(69, 76);
            this.gvUsuariosGisel.Margin = new System.Windows.Forms.Padding(4);
            this.gvUsuariosGisel.Name = "gvUsuariosGisel";
            this.gvUsuariosGisel.ReadOnly = true;
            this.gvUsuariosGisel.RowHeadersWidth = 51;
            this.gvUsuariosGisel.Size = new System.Drawing.Size(733, 191);
            this.gvUsuariosGisel.TabIndex = 13;
            this.gvUsuariosGisel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosGisel_CellContentClick);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(142, 286);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(188, 43);
            this.btnAgregarUsuario.TabIndex = 14;
            this.btnAgregarUsuario.Text = "AGREGAR";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(529, 285);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(329, 333);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "CANCELAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 402);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.gvUsuariosGisel);
            this.Controls.Add(this.lblVerUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerUsuarios";
            this.Text = "VER USUARIOS GISEL";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuariosGisel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerUsuario;
        private System.Windows.Forms.DataGridView gvUsuariosGisel;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}