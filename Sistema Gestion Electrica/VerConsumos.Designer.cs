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
            this.lblHistorialConsumos = new System.Windows.Forms.Label();
            this.gvConsumosGisel = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbNIS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsumosGisel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistorialConsumos
            // 
            this.lblHistorialConsumos.AutoSize = true;
            this.lblHistorialConsumos.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialConsumos.Location = new System.Drawing.Point(112, 9);
            this.lblHistorialConsumos.Name = "lblHistorialConsumos";
            this.lblHistorialConsumos.Size = new System.Drawing.Size(533, 63);
            this.lblHistorialConsumos.TabIndex = 12;
            this.lblHistorialConsumos.Text = "VER CONSUMOS SIGEL";
            this.lblHistorialConsumos.Click += new System.EventHandler(this.lblVerUsuario_Click);
            // 
            // gvConsumosGisel
            // 
            this.gvConsumosGisel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvConsumosGisel.Location = new System.Drawing.Point(55, 132);
            this.gvConsumosGisel.Margin = new System.Windows.Forms.Padding(4);
            this.gvConsumosGisel.Name = "gvConsumosGisel";
            this.gvConsumosGisel.RowHeadersWidth = 51;
            this.gvConsumosGisel.Size = new System.Drawing.Size(663, 185);
            this.gvConsumosGisel.TabIndex = 13;
            this.gvConsumosGisel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosGisel_CellContentClick);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(247, 323);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(415, 79);
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
            this.tbNIS.Location = new System.Drawing.Point(257, 87);
            this.tbNIS.Margin = new System.Windows.Forms.Padding(4);
            this.tbNIS.Name = "tbNIS";
            this.tbNIS.Size = new System.Drawing.Size(150, 22);
            this.tbNIS.TabIndex = 21;
            this.tbNIS.TextChanged += new System.EventHandler(this.tbNIS_TextChanged);
            this.tbNIS.Enter += new System.EventHandler(this.tbNIS_Enter);
            this.tbNIS.Leave += new System.EventHandler(this.tbNIS_Leave);
            // 
            // VerConsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 391);
            this.Controls.Add(this.tbNIS);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gvConsumosGisel);
            this.Controls.Add(this.lblHistorialConsumos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerConsumos";
            this.Text = "VER CONSUMO SIGEL";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvConsumosGisel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistorialConsumos;
        private System.Windows.Forms.DataGridView gvConsumosGisel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbNIS;
    }
}