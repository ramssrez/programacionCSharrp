namespace DPRN3_U1_EA_RARP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProveedor = new System.Windows.Forms.Button();
            this.dgvProvedores = new System.Windows.Forms.DataGridView();
            this.btnAutoPartes = new System.Windows.Forms.Button();
            this.dgvAutoPartes = new System.Windows.Forms.DataGridView();
            this.btnDetalleCompra = new System.Windows.Forms.Button();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoPartes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(301, 28);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(181, 47);
            this.btnProveedor.TabIndex = 0;
            this.btnProveedor.Text = "Obtener Provedores";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // dgvProvedores
            // 
            this.dgvProvedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvedores.Location = new System.Drawing.Point(12, 81);
            this.dgvProvedores.Name = "dgvProvedores";
            this.dgvProvedores.RowHeadersWidth = 51;
            this.dgvProvedores.RowTemplate.Height = 24;
            this.dgvProvedores.Size = new System.Drawing.Size(762, 158);
            this.dgvProvedores.TabIndex = 1;
            // 
            // btnAutoPartes
            // 
            this.btnAutoPartes.Location = new System.Drawing.Point(301, 245);
            this.btnAutoPartes.Name = "btnAutoPartes";
            this.btnAutoPartes.Size = new System.Drawing.Size(181, 47);
            this.btnAutoPartes.TabIndex = 2;
            this.btnAutoPartes.Text = "Obtener Auto Partes";
            this.btnAutoPartes.UseVisualStyleBackColor = true;
            this.btnAutoPartes.Click += new System.EventHandler(this.btnAutoPartes_Click);
            // 
            // dgvAutoPartes
            // 
            this.dgvAutoPartes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoPartes.Location = new System.Drawing.Point(12, 298);
            this.dgvAutoPartes.Name = "dgvAutoPartes";
            this.dgvAutoPartes.RowHeadersWidth = 51;
            this.dgvAutoPartes.RowTemplate.Height = 24;
            this.dgvAutoPartes.Size = new System.Drawing.Size(762, 158);
            this.dgvAutoPartes.TabIndex = 3;
            // 
            // btnDetalleCompra
            // 
            this.btnDetalleCompra.Location = new System.Drawing.Point(301, 462);
            this.btnDetalleCompra.Name = "btnDetalleCompra";
            this.btnDetalleCompra.Size = new System.Drawing.Size(181, 47);
            this.btnDetalleCompra.TabIndex = 4;
            this.btnDetalleCompra.Text = "Obtener Detalle Compra";
            this.btnDetalleCompra.UseVisualStyleBackColor = true;
            this.btnDetalleCompra.Click += new System.EventHandler(this.btnDetalleCompra_Click);
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(12, 515);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.RowHeadersWidth = 51;
            this.dgvDetalleCompra.RowTemplate.Height = 24;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(762, 158);
            this.dgvDetalleCompra.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 832);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.btnDetalleCompra);
            this.Controls.Add(this.dgvAutoPartes);
            this.Controls.Add(this.btnAutoPartes);
            this.Controls.Add(this.dgvProvedores);
            this.Controls.Add(this.btnProveedor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoPartes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.DataGridView dgvProvedores;
        private System.Windows.Forms.Button btnAutoPartes;
        private System.Windows.Forms.DataGridView dgvAutoPartes;
        private System.Windows.Forms.Button btnDetalleCompra;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
    }
}

