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
            this.TxtIdEspecialidaRRP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdDoctorRRP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidoMaternoMedicoCRRP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCedulaRRP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtApellidoPaternoMedicoRRP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreMedicoRRP = new System.Windows.Forms.TextBox();
            this.DgvMedicosRRP = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvEspcialidadesRRP = new System.Windows.Forms.DataGridView();
            this.idEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescipcionEs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelEs = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarMedicoRRP = new System.Windows.Forms.Button();
            this.TxtBuscarRRP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosRRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEspcialidadesRRP)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
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
            this.BtnEliminarRRP.Click += new System.EventHandler(this.BtnEliminarRRP_Click);
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
            this.BtnGuardarRRP.Click += new System.EventHandler(this.BtnGuardarRRP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtIdEspecialidaRRP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtIdDoctorRRP);
            this.groupBox1.Controls.Add(this.label3);
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
            this.groupBox1.Size = new System.Drawing.Size(660, 260);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del médico";
            // 
            // TxtIdEspecialidaRRP
            // 
            this.TxtIdEspecialidaRRP.Enabled = false;
            this.TxtIdEspecialidaRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdEspecialidaRRP.Location = new System.Drawing.Point(524, 152);
            this.TxtIdEspecialidaRRP.Name = "TxtIdEspecialidaRRP";
            this.TxtIdEspecialidaRRP.Size = new System.Drawing.Size(104, 27);
            this.TxtIdEspecialidaRRP.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Id Especialidad";
            // 
            // TxtIdDoctorRRP
            // 
            this.TxtIdDoctorRRP.Enabled = false;
            this.TxtIdDoctorRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdDoctorRRP.Location = new System.Drawing.Point(524, 74);
            this.TxtIdDoctorRRP.Name = "TxtIdDoctorRRP";
            this.TxtIdDoctorRRP.Size = new System.Drawing.Size(104, 27);
            this.TxtIdDoctorRRP.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Id Médico";
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
            this.label8.Size = new System.Drawing.Size(89, 26);
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
            this.Id,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.Cedula,
            this.Especialidad});
            this.DgvMedicosRRP.Location = new System.Drawing.Point(499, 365);
            this.DgvMedicosRRP.Name = "DgvMedicosRRP";
            this.DgvMedicosRRP.ReadOnly = true;
            this.DgvMedicosRRP.RowHeadersWidth = 45;
            this.DgvMedicosRRP.RowTemplate.Height = 24;
            this.DgvMedicosRRP.Size = new System.Drawing.Size(755, 324);
            this.DgvMedicosRRP.TabIndex = 24;
            this.DgvMedicosRRP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicosRRP_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ApellidoPaterno.MinimumWidth = 6;
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            this.ApellidoPaterno.Width = 125;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Apellido Materno";
            this.ApellidoMaterno.MinimumWidth = 6;
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            this.ApellidoMaterno.Width = 125;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 125;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 125;
            // 
            // DgvEspcialidadesRRP
            // 
            this.DgvEspcialidadesRRP.AllowUserToAddRows = false;
            this.DgvEspcialidadesRRP.AllowUserToDeleteRows = false;
            this.DgvEspcialidadesRRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEspcialidadesRRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEspecialidad,
            this.NombreEs,
            this.DescipcionEs});
            this.DgvEspcialidadesRRP.Location = new System.Drawing.Point(743, 54);
            this.DgvEspcialidadesRRP.Name = "DgvEspcialidadesRRP";
            this.DgvEspcialidadesRRP.ReadOnly = true;
            this.DgvEspcialidadesRRP.RowHeadersWidth = 45;
            this.DgvEspcialidadesRRP.RowTemplate.Height = 24;
            this.DgvEspcialidadesRRP.Size = new System.Drawing.Size(556, 237);
            this.DgvEspcialidadesRRP.TabIndex = 25;
            this.DgvEspcialidadesRRP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEspcialidadesRRP_CellClick);
            // 
            // idEspecialidad
            // 
            this.idEspecialidad.HeaderText = "Id";
            this.idEspecialidad.MinimumWidth = 6;
            this.idEspecialidad.Name = "idEspecialidad";
            this.idEspecialidad.ReadOnly = true;
            this.idEspecialidad.Width = 50;
            // 
            // NombreEs
            // 
            this.NombreEs.HeaderText = "Nombre";
            this.NombreEs.MinimumWidth = 6;
            this.NombreEs.Name = "NombreEs";
            this.NombreEs.ReadOnly = true;
            this.NombreEs.Width = 125;
            // 
            // DescipcionEs
            // 
            this.DescipcionEs.HeaderText = "Descripción";
            this.DescipcionEs.MinimumWidth = 6;
            this.DescipcionEs.Name = "DescipcionEs";
            this.DescipcionEs.ReadOnly = true;
            this.DescipcionEs.Width = 300;
            // 
            // labelEs
            // 
            this.labelEs.AutoSize = true;
            this.labelEs.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEs.Location = new System.Drawing.Point(736, 9);
            this.labelEs.Name = "labelEs";
            this.labelEs.Size = new System.Drawing.Size(436, 42);
            this.labelEs.TabIndex = 26;
            this.labelEs.Text = "Selección especialidades";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarMedicoRRP);
            this.groupBox4.Controls.Add(this.TxtBuscarRRP);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(53, 343);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 166);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda";
            // 
            // btnBuscarMedicoRRP
            // 
            this.btnBuscarMedicoRRP.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscarMedicoRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMedicoRRP.ForeColor = System.Drawing.Color.Snow;
            this.btnBuscarMedicoRRP.Location = new System.Drawing.Point(30, 98);
            this.btnBuscarMedicoRRP.Name = "btnBuscarMedicoRRP";
            this.btnBuscarMedicoRRP.Size = new System.Drawing.Size(307, 62);
            this.btnBuscarMedicoRRP.TabIndex = 18;
            this.btnBuscarMedicoRRP.Text = "Buscar";
            this.btnBuscarMedicoRRP.UseVisualStyleBackColor = false;
            this.btnBuscarMedicoRRP.Click += new System.EventHandler(this.btnBuscarMedicoRRP_Click);
            // 
            // TxtBuscarRRP
            // 
            this.TxtBuscarRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarRRP.Location = new System.Drawing.Point(107, 50);
            this.TxtBuscarRRP.Name = "TxtBuscarRRP";
            this.TxtBuscarRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtBuscarRRP.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 26);
            this.label16.TabIndex = 3;
            this.label16.Text = "Buscar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 53);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tabla de médicos";
            // 
            // MedicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1311, 773);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelEs);
            this.Controls.Add(this.DgvEspcialidadesRRP);
            this.Controls.Add(this.DgvMedicosRRP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminarRRP);
            this.Controls.Add(this.BtnGuardarRRP);
            this.Controls.Add(this.BtnRegresarRRP);
            this.Name = "MedicoForm";
            this.Text = "Doctores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosRRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEspcialidadesRRP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox TxtIdDoctorRRP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvEspcialidadesRRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescipcionEs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdEspecialidaRRP;
        private System.Windows.Forms.Label labelEs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuscarMedicoRRP;
        private System.Windows.Forms.TextBox TxtBuscarRRP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
    }
}