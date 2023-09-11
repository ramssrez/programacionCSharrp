namespace DSDPRN3RRP2302B1
{
    partial class MenuForm
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
            this.BtnPacientesRRP = new System.Windows.Forms.Button();
            this.BtnDoctoresRRP = new System.Windows.Forms.Button();
            this.BtnEspecialidadesRRP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExportarTxtRRP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPacientesRRP
            // 
            this.BtnPacientesRRP.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPacientesRRP.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPacientesRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnPacientesRRP.Location = new System.Drawing.Point(158, 113);
            this.BtnPacientesRRP.Name = "BtnPacientesRRP";
            this.BtnPacientesRRP.Size = new System.Drawing.Size(491, 71);
            this.BtnPacientesRRP.TabIndex = 0;
            this.BtnPacientesRRP.Text = "Pacientes";
            this.BtnPacientesRRP.UseVisualStyleBackColor = false;
            this.BtnPacientesRRP.Click += new System.EventHandler(this.BtnPacientesRRP_Click);
            // 
            // BtnDoctoresRRP
            // 
            this.BtnDoctoresRRP.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnDoctoresRRP.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctoresRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnDoctoresRRP.Location = new System.Drawing.Point(158, 214);
            this.BtnDoctoresRRP.Name = "BtnDoctoresRRP";
            this.BtnDoctoresRRP.Size = new System.Drawing.Size(491, 71);
            this.BtnDoctoresRRP.TabIndex = 2;
            this.BtnDoctoresRRP.Text = "Doctores";
            this.BtnDoctoresRRP.UseVisualStyleBackColor = false;
            this.BtnDoctoresRRP.Click += new System.EventHandler(this.BtnDoctoresRRP_Click);
            // 
            // BtnEspecialidadesRRP
            // 
            this.BtnEspecialidadesRRP.BackColor = System.Drawing.Color.Tan;
            this.BtnEspecialidadesRRP.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEspecialidadesRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnEspecialidadesRRP.Location = new System.Drawing.Point(158, 316);
            this.BtnEspecialidadesRRP.Name = "BtnEspecialidadesRRP";
            this.BtnEspecialidadesRRP.Size = new System.Drawing.Size(491, 71);
            this.BtnEspecialidadesRRP.TabIndex = 3;
            this.BtnEspecialidadesRRP.Text = "Especialidades";
            this.BtnEspecialidadesRRP.UseVisualStyleBackColor = false;
            this.BtnEspecialidadesRRP.Click += new System.EventHandler(this.BtnEspecialidadesRRP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccióna una opcion";
            // 
            // BtnExportarTxtRRP
            // 
            this.BtnExportarTxtRRP.BackColor = System.Drawing.Color.Crimson;
            this.BtnExportarTxtRRP.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportarTxtRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnExportarTxtRRP.Location = new System.Drawing.Point(158, 418);
            this.BtnExportarTxtRRP.Name = "BtnExportarTxtRRP";
            this.BtnExportarTxtRRP.Size = new System.Drawing.Size(491, 71);
            this.BtnExportarTxtRRP.TabIndex = 5;
            this.BtnExportarTxtRRP.Text = "Exportar TXT";
            this.BtnExportarTxtRRP.UseVisualStyleBackColor = false;
            this.BtnExportarTxtRRP.Click += new System.EventHandler(this.BtnExportarTxtRRP_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.BtnExportarTxtRRP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEspecialidadesRRP);
            this.Controls.Add(this.BtnDoctoresRRP);
            this.Controls.Add(this.BtnPacientesRRP);
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPacientesRRP;
        private System.Windows.Forms.Button BtnDoctoresRRP;
        private System.Windows.Forms.Button BtnEspecialidadesRRP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExportarTxtRRP;
    }
}