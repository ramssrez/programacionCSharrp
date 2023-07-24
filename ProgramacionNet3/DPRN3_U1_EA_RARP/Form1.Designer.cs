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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedores)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProvedores);
            this.Controls.Add(this.btnProveedor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.DataGridView dgvProvedores;
    }
}

