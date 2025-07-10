namespace Sistema_Gestion_Electrica
{
    partial class VerConsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerConsumos));
            this.lblHistorialConsumos = new System.Windows.Forms.Label();
            this.gvConsumosGisel = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbNIS = new System.Windows.Forms.TextBox();
            this.btnAgregarNuevoConsumo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsumosGisel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistorialConsumos
            // 
            this.lblHistorialConsumos.AutoSize = true;
            this.lblHistorialConsumos.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialConsumos.Location = new System.Drawing.Point(87, 6);
            this.lblHistorialConsumos.Name = "lblHistorialConsumos";
            this.lblHistorialConsumos.Size = new System.Drawing.Size(468, 63);
            this.lblHistorialConsumos.TabIndex = 12;
            this.lblHistorialConsumos.Text = "Lecturas de Servicio";
            this.lblHistorialConsumos.Click += new System.EventHandler(this.lblVerUsuario_Click);
            // 
            // gvConsumosGisel
            // 
            this.gvConsumosGisel.AllowUserToAddRows = false;
            this.gvConsumosGisel.AllowUserToDeleteRows = false;
            this.gvConsumosGisel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvConsumosGisel.Location = new System.Drawing.Point(25, 117);
            this.gvConsumosGisel.Margin = new System.Windows.Forms.Padding(4);
            this.gvConsumosGisel.Name = "gvConsumosGisel";
            this.gvConsumosGisel.ReadOnly = true;
            this.gvConsumosGisel.RowHeadersWidth = 51;
            this.gvConsumosGisel.Size = new System.Drawing.Size(592, 185);
            this.gvConsumosGisel.TabIndex = 13;
            this.gvConsumosGisel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosGisel_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(360, 72);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 38);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbNIS
            // 
            this.tbNIS.Location = new System.Drawing.Point(176, 79);
            this.tbNIS.Margin = new System.Windows.Forms.Padding(4);
            this.tbNIS.Name = "tbNIS";
            this.tbNIS.Size = new System.Drawing.Size(150, 22);
            this.tbNIS.TabIndex = 21;
            this.tbNIS.TextChanged += new System.EventHandler(this.tbNIS_TextChanged);
            this.tbNIS.Enter += new System.EventHandler(this.tbNIS_Enter);
            this.tbNIS.Leave += new System.EventHandler(this.tbNIS_Leave);
            // 
            // btnAgregarNuevoConsumo
            // 
            this.btnAgregarNuevoConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarNuevoConsumo.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevoConsumo.Location = new System.Drawing.Point(69, 308);
            this.btnAgregarNuevoConsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarNuevoConsumo.Name = "btnAgregarNuevoConsumo";
            this.btnAgregarNuevoConsumo.Size = new System.Drawing.Size(257, 43);
            this.btnAgregarNuevoConsumo.TabIndex = 22;
            this.btnAgregarNuevoConsumo.Text = "Nuevo Consumo";
            this.btnAgregarNuevoConsumo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoConsumo.Click += new System.EventHandler(this.btnAgregarNuevoConsumo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(360, 308);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(239, 43);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // VerConsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 378);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarNuevoConsumo);
            this.Controls.Add(this.tbNIS);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gvConsumosGisel);
            this.Controls.Add(this.lblHistorialConsumos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerConsumos";
            this.Text = "LECTURAS DE SERVICIOS";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvConsumosGisel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistorialConsumos;
        private System.Windows.Forms.DataGridView gvConsumosGisel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbNIS;
        private System.Windows.Forms.Button btnAgregarNuevoConsumo;
        private System.Windows.Forms.Button btnCancelar;
    }
}