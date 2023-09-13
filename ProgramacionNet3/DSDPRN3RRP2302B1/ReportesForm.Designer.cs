namespace DSDPRN3RRP2302B1
{
    partial class ReportesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbxMedicosRRP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvDatosRRP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxEspecialidadRRP = new System.Windows.Forms.ComboBox();
            this.DgvDatosEspecialidadRRP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegresarRRP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosRRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEspecialidadRRP)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxMedicosRRP
            // 
            this.CbxMedicosRRP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxMedicosRRP.FormattingEnabled = true;
            this.CbxMedicosRRP.Location = new System.Drawing.Point(52, 48);
            this.CbxMedicosRRP.Name = "CbxMedicosRRP";
            this.CbxMedicosRRP.Size = new System.Drawing.Size(199, 34);
            this.CbxMedicosRRP.TabIndex = 5;
            this.CbxMedicosRRP.Text = "Médicos";
            this.CbxMedicosRRP.SelectedIndexChanged += new System.EventHandler(this.CbxMedicosRRP_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Seleccione al médico";
            // 
            // DgvDatosRRP
            // 
            this.DgvDatosRRP.AllowUserToAddRows = false;
            this.DgvDatosRRP.AllowUserToDeleteRows = false;
            this.DgvDatosRRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosRRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosRRP.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatosRRP.Location = new System.Drawing.Point(52, 88);
            this.DgvDatosRRP.Name = "DgvDatosRRP";
            this.DgvDatosRRP.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosRRP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDatosRRP.RowHeadersWidth = 45;
            this.DgvDatosRRP.RowTemplate.Height = 24;
            this.DgvDatosRRP.Size = new System.Drawing.Size(465, 252);
            this.DgvDatosRRP.TabIndex = 13;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Pacientes";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccione la especialidad";
            // 
            // CbxEspecialidadRRP
            // 
            this.CbxEspecialidadRRP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEspecialidadRRP.FormattingEnabled = true;
            this.CbxEspecialidadRRP.Location = new System.Drawing.Point(565, 48);
            this.CbxEspecialidadRRP.Name = "CbxEspecialidadRRP";
            this.CbxEspecialidadRRP.Size = new System.Drawing.Size(199, 34);
            this.CbxEspecialidadRRP.TabIndex = 15;
            this.CbxEspecialidadRRP.Text = "Especialidad";
            this.CbxEspecialidadRRP.SelectedIndexChanged += new System.EventHandler(this.CbxEspecialidadRRP_SelectedIndexChanged);
            // 
            // DgvDatosEspecialidadRRP
            // 
            this.DgvDatosEspecialidadRRP.AllowUserToAddRows = false;
            this.DgvDatosEspecialidadRRP.AllowUserToDeleteRows = false;
            this.DgvDatosEspecialidadRRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatosEspecialidadRRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosEspecialidadRRP.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDatosEspecialidadRRP.Location = new System.Drawing.Point(565, 88);
            this.DgvDatosEspecialidadRRP.Name = "DgvDatosEspecialidadRRP";
            this.DgvDatosEspecialidadRRP.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosEspecialidadRRP.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvDatosEspecialidadRRP.RowHeadersWidth = 45;
            this.DgvDatosEspecialidadRRP.RowTemplate.Height = 24;
            this.DgvDatosEspecialidadRRP.Size = new System.Drawing.Size(465, 252);
            this.DgvDatosEspecialidadRRP.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "Medico";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // BtnRegresarRRP
            // 
            this.BtnRegresarRRP.BackColor = System.Drawing.Color.DarkViolet;
            this.BtnRegresarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnRegresarRRP.Location = new System.Drawing.Point(696, 376);
            this.BtnRegresarRRP.Name = "BtnRegresarRRP";
            this.BtnRegresarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnRegresarRRP.TabIndex = 19;
            this.BtnRegresarRRP.Text = "Regresar";
            this.BtnRegresarRRP.UseVisualStyleBackColor = false;
            this.BtnRegresarRRP.Click += new System.EventHandler(this.BtnRegresarRRP_Click);
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.BtnRegresarRRP);
            this.Controls.Add(this.DgvDatosEspecialidadRRP);
            this.Controls.Add(this.CbxEspecialidadRRP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvDatosRRP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxMedicosRRP);
            this.Name = "ReportesForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosRRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEspecialidadRRP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbxMedicosRRP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvDatosRRP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxEspecialidadRRP;
        private System.Windows.Forms.DataGridView DgvDatosEspecialidadRRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button BtnRegresarRRP;
    }
}