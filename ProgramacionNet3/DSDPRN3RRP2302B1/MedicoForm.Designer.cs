namespace DSDPRN3RRP2302B1
{
    partial class MedicoForm
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
            this.BtnRegresarRRP = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminarRRP = new System.Windows.Forms.Button();
            this.BtnGuardarRRP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtApellidoMaternoMedicoCRRP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCedulaRRP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtApellidoPaternoMedicoRRP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreMedicoRRP = new System.Windows.Forms.TextBox();
            this.DgvMedicosRRP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosRRP)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresarRRP
            // 
            this.BtnRegresarRRP.BackColor = System.Drawing.Color.DarkViolet;
            this.BtnRegresarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnRegresarRRP.Location = new System.Drawing.Point(974, 699);
            this.BtnRegresarRRP.Name = "BtnRegresarRRP";
            this.BtnRegresarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnRegresarRRP.TabIndex = 19;
            this.BtnRegresarRRP.Text = "Regresar";
            this.BtnRegresarRRP.UseVisualStyleBackColor = false;
            this.BtnRegresarRRP.Click += new System.EventHandler(this.BtnRegresarRRP_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Gold;
            this.BtnActualizar.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.Snow;
            this.BtnActualizar.Location = new System.Drawing.Point(335, 699);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(307, 62);
            this.BtnActualizar.TabIndex = 22;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarRRP
            // 
            this.BtnEliminarRRP.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnEliminarRRP.Location = new System.Drawing.Point(661, 699);
            this.BtnEliminarRRP.Name = "BtnEliminarRRP";
            this.BtnEliminarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnEliminarRRP.TabIndex = 21;
            this.BtnEliminarRRP.Text = "Eliminar";
            this.BtnEliminarRRP.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarRRP
            // 
            this.BtnGuardarRRP.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnGuardarRRP.Location = new System.Drawing.Point(8, 699);
            this.BtnGuardarRRP.Name = "BtnGuardarRRP";
            this.BtnGuardarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnGuardarRRP.TabIndex = 20;
            this.BtnGuardarRRP.Text = "Agregar";
            this.BtnGuardarRRP.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtApellidoMaternoMedicoCRRP);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtCedulaRRP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtApellidoPaternoMedicoRRP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNombreMedicoRRP);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 260);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre Completo";
            // 
            // TxtApellidoMaternoMedicoCRRP
            // 
            this.TxtApellidoMaternoMedicoCRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoMaternoMedicoCRRP.Location = new System.Drawing.Point(221, 148);
            this.TxtApellidoMaternoMedicoCRRP.Name = "TxtApellidoMaternoMedicoCRRP";
            this.TxtApellidoMaternoMedicoCRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtApellidoMaternoMedicoCRRP.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 26);
            this.label12.TabIndex = 11;
            this.label12.Text = "Apellido Materno:";
            // 
            // TxtCedulaRRP
            // 
            this.TxtCedulaRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedulaRRP.Location = new System.Drawing.Point(221, 203);
            this.TxtCedulaRRP.Name = "TxtCedulaRRP";
            this.TxtCedulaRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtCedulaRRP.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 33);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cedula:";
            // 
            // TxtApellidoPaternoMedicoRRP
            // 
            this.TxtApellidoPaternoMedicoRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoPaternoMedicoRRP.Location = new System.Drawing.Point(221, 93);
            this.TxtApellidoPaternoMedicoRRP.Name = "TxtApellidoPaternoMedicoRRP";
            this.TxtApellidoPaternoMedicoRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtApellidoPaternoMedicoRRP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // TxtNombreMedicoRRP
            // 
            this.TxtNombreMedicoRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreMedicoRRP.Location = new System.Drawing.Point(221, 41);
            this.TxtNombreMedicoRRP.Name = "TxtNombreMedicoRRP";
            this.TxtNombreMedicoRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtNombreMedicoRRP.TabIndex = 4;
            // 
            // DgvMedicosRRP
            // 
            this.DgvMedicosRRP.AllowUserToAddRows = false;
            this.DgvMedicosRRP.AllowUserToDeleteRows = false;
            this.DgvMedicosRRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMedicosRRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvMedicosRRP.Location = new System.Drawing.Point(40, 338);
            this.DgvMedicosRRP.Name = "DgvMedicosRRP";
            this.DgvMedicosRRP.ReadOnly = true;
            this.DgvMedicosRRP.RowHeadersWidth = 45;
            this.DgvMedicosRRP.RowTemplate.Height = 24;
            this.DgvMedicosRRP.Size = new System.Drawing.Size(733, 252);
            this.DgvMedicosRRP.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido Paterno";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Apellido Materno";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cedula";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Especialidad";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // MedicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1311, 773);
            this.Controls.Add(this.DgvMedicosRRP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminarRRP);
            this.Controls.Add(this.BtnGuardarRRP);
            this.Controls.Add(this.BtnRegresarRRP);
            this.Name = "MedicoForm";
            this.Text = "DoctoresForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosRRP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnRegresarRRP;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminarRRP;
        private System.Windows.Forms.Button BtnGuardarRRP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtApellidoMaternoMedicoCRRP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCedulaRRP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtApellidoPaternoMedicoRRP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombreMedicoRRP;
        private System.Windows.Forms.DataGridView DgvMedicosRRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}