namespace Sistema_Gestion_Electrica
{
    partial class VerServiciosDeEmpresa
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gvServiciosGisel = new System.Windows.Forms.DataGridView();
            this.lblVerServicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiciosGisel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(496, 263);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(188, 43);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.Location = new System.Drawing.Point(103, 263);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(188, 43);
            this.btnAgregarServicio.TabIndex = 23;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(302, 263);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 43);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // gvServiciosGisel
            // 
            this.gvServiciosGisel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvServiciosGisel.Location = new System.Drawing.Point(61, 72);
            this.gvServiciosGisel.Margin = new System.Windows.Forms.Padding(4);
            this.gvServiciosGisel.Name = "gvServiciosGisel";
            this.gvServiciosGisel.RowHeadersWidth = 51;
            this.gvServiciosGisel.Size = new System.Drawing.Size(663, 185);
            this.gvServiciosGisel.TabIndex = 21;
            // 
            // lblVerServicio
            // 
            this.lblVerServicio.AutoSize = true;
            this.lblVerServicio.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerServicio.Location = new System.Drawing.Point(163, 9);
            this.lblVerServicio.Name = "lblVerServicio";
            this.lblVerServicio.Size = new System.Drawing.Size(468, 63);
            this.lblVerServicio.TabIndex = 20;
            this.lblVerServicio.Text = "Servicios Existentes";
            // 
            // VerServiciosDeEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gvServiciosGisel);
            this.Controls.Add(this.lblVerServicio);
            this.Name = "VerServiciosDeEmpresa";
            this.Text = "Servicios Existentes";
            ((System.ComponentModel.ISupportInitialize)(this.gvServiciosGisel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView gvServiciosGisel;
        private System.Windows.Forms.Label lblVerServicio;
    }
}