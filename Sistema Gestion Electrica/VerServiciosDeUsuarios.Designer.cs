namespace Sistema_Gestion_Electrica
{
    partial class VerServiciosDelUsuario
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
            this.gvServiciosGisel = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiciosGisel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerUsuario
            // 
            this.lblVerUsuario.AutoSize = true;
            this.lblVerUsuario.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerUsuario.Location = new System.Drawing.Point(64, 9);
            this.lblVerUsuario.Name = "lblVerUsuario";
            this.lblVerUsuario.Size = new System.Drawing.Size(497, 63);
            this.lblVerUsuario.TabIndex = 12;
            this.lblVerUsuario.Text = "Servicios de Usuarios";
            this.lblVerUsuario.Click += new System.EventHandler(this.lblVerUsuario_Click);
            // 
            // gvServiciosGisel
            // 
            this.gvServiciosGisel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvServiciosGisel.Location = new System.Drawing.Point(23, 76);
            this.gvServiciosGisel.Margin = new System.Windows.Forms.Padding(4);
            this.gvServiciosGisel.Name = "gvServiciosGisel";
            this.gvServiciosGisel.RowHeadersWidth = 51;
            this.gvServiciosGisel.Size = new System.Drawing.Size(576, 185);
            this.gvServiciosGisel.TabIndex = 13;
            this.gvServiciosGisel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosGisel_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(217, 267);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 43);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.Location = new System.Drawing.Point(23, 267);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(188, 43);
            this.btnAgregarServicio.TabIndex = 18;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(411, 267);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(188, 43);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // VerServiciosDelUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 334);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gvServiciosGisel);
            this.Controls.Add(this.lblVerUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerServiciosDelUsuario";
            this.Text = "Servicios de Usuarios";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvServiciosGisel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerUsuario;
        private System.Windows.Forms.DataGridView gvServiciosGisel;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button btnCancelar;
    }
}