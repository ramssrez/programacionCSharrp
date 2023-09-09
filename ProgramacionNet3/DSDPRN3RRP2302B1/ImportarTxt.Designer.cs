namespace DSDPRN3RRP2302B1
{
    partial class ImportarTxt
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
            this.BtnAbrirTxtRRP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvDatosTxtRRP = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnRegresarRRP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosTxtRRP)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAbrirTxtRRP
            // 
            this.BtnAbrirTxtRRP.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAbrirTxtRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirTxtRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnAbrirTxtRRP.Location = new System.Drawing.Point(248, 12);
            this.BtnAbrirTxtRRP.Name = "BtnAbrirTxtRRP";
            this.BtnAbrirTxtRRP.Size = new System.Drawing.Size(591, 61);
            this.BtnAbrirTxtRRP.TabIndex = 0;
            this.BtnAbrirTxtRRP.Text = "Abrir Txt";
            this.BtnAbrirTxtRRP.UseVisualStyleBackColor = false;
            this.BtnAbrirTxtRRP.Click += new System.EventHandler(this.BtnAbrirTxtRRP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvDatosTxtRRP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 344);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Txt";
            // 
            // DgvDatosTxtRRP
            // 
            this.DgvDatosTxtRRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosTxtRRP.Location = new System.Drawing.Point(6, 33);
            this.DgvDatosTxtRRP.Name = "DgvDatosTxtRRP";
            this.DgvDatosTxtRRP.RowHeadersWidth = 51;
            this.DgvDatosTxtRRP.RowTemplate.Height = 24;
            this.DgvDatosTxtRRP.Size = new System.Drawing.Size(955, 293);
            this.DgvDatosTxtRRP.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnRegresarRRP
            // 
            this.BtnRegresarRRP.BackColor = System.Drawing.Color.DarkViolet;
            this.BtnRegresarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnRegresarRRP.Location = new System.Drawing.Point(687, 480);
            this.BtnRegresarRRP.Name = "BtnRegresarRRP";
            this.BtnRegresarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnRegresarRRP.TabIndex = 19;
            this.BtnRegresarRRP.Text = "Regresar";
            this.BtnRegresarRRP.UseVisualStyleBackColor = false;
            this.BtnRegresarRRP.Click += new System.EventHandler(this.BtnRegresarRRP_Click);
            // 
            // ImportarTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1023, 585);
            this.Controls.Add(this.BtnRegresarRRP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAbrirTxtRRP);
            this.Name = "ImportarTxt";
            this.Text = "ImportarTxt";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosTxtRRP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrirTxtRRP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvDatosTxtRRP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnRegresarRRP;
    }
}