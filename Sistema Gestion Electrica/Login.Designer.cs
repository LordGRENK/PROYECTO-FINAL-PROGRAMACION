namespace Sistema_Gestion_Electrica
{
    partial class Login
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(23, 26);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(297, 28);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "SISTEMA GESTOR ELÉCTRICO";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(121, 67);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(77, 21);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "USUARIO";
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.LightBlue;
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(95, 92);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(129, 23);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.Color.LightBlue;
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.Location = new System.Drawing.Point(95, 151);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(129, 23);
            this.tbContraseña.TabIndex = 4;
            this.tbContraseña.TextChanged += new System.EventHandler(this.tbContraseña_TextChanged);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(104, 128);
            this.lbContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(111, 21);
            this.lbContraseña.TabIndex = 3;
            this.lbContraseña.Text = "CONTRASEÑA";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(103, 199);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(105, 35);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "ENTRAR";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 271);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "SIGEL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}