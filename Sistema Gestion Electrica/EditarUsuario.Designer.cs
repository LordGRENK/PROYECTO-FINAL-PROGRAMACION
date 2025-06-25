namespace Sistema_Gestion_Electrica
{
    partial class EditarUsuario
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
            this.lblVerUsuario = new System.Windows.Forms.Label();
            this.gvUsuariosGisel = new System.Windows.Forms.DataGridView();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuariosGisel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerUsuario
            // 
            this.lblVerUsuario.AutoSize = true;
            this.lblVerUsuario.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerUsuario.Location = new System.Drawing.Point(113, 9);
            this.lblVerUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerUsuario.Name = "lblVerUsuario";
            this.lblVerUsuario.Size = new System.Drawing.Size(342, 50);
            this.lblVerUsuario.TabIndex = 12;
            this.lblVerUsuario.Text = "Ver Usuario GISEL";
            // 
            // gvUsuariosGisel
            // 
            this.gvUsuariosGisel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsuariosGisel.Location = new System.Drawing.Point(33, 62);
            this.gvUsuariosGisel.Name = "gvUsuariosGisel";
            this.gvUsuariosGisel.Size = new System.Drawing.Size(497, 150);
            this.gvUsuariosGisel.TabIndex = 13;
            this.gvUsuariosGisel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosGisel_CellContentClick);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(65, 217);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(141, 35);
            this.btnIniciarSesion.TabIndex = 14;
            this.btnIniciarSesion.Text = "Agregar";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(355, 217);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.gvUsuariosGisel);
            this.Controls.Add(this.lblVerUsuario);
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuariosGisel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerUsuario;
        private System.Windows.Forms.DataGridView gvUsuariosGisel;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}