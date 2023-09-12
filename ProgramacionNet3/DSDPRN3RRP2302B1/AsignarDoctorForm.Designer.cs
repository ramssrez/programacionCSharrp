namespace DSDPRN3RRP2302B1
{
    partial class AsignarDoctorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvMedicosRRP = new System.Windows.Forms.DataGridView();
            this.IdMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvPacientesRRP = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegresarRRP = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIdDoctorRRP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdPacienteRRP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAsignarRRP = new System.Windows.Forms.Button();
            this.DgvPacienteMedicoRRP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosRRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesRRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacienteMedicoRRP)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMedicosRRP
            // 
            this.DgvMedicosRRP.AllowUserToAddRows = false;
            this.DgvMedicosRRP.AllowUserToDeleteRows = false;
            this.DgvMedicosRRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMedicosRRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedico,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.Cedula,
            this.Especialidad});
            this.DgvMedicosRRP.Location = new System.Drawing.Point(56, 369);
            this.DgvMedicosRRP.Name = "DgvMedicosRRP";
            this.DgvMedicosRRP.ReadOnly = true;
            this.DgvMedicosRRP.RowHeadersWidth = 45;
            this.DgvMedicosRRP.RowTemplate.Height = 24;
            this.DgvMedicosRRP.Size = new System.Drawing.Size(895, 324);
            this.DgvMedicosRRP.TabIndex = 25;
            this.DgvMedicosRRP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicosRRP_CellClick);
            // 
            // IdMedico
            // 
            this.IdMedico.HeaderText = "Id";
            this.IdMedico.MinimumWidth = 6;
            this.IdMedico.Name = "IdMedico";
            this.IdMedico.ReadOnly = true;
            this.IdMedico.Width = 50;
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
            // DgvPacientesRRP
            // 
            this.DgvPacientesRRP.AllowUserToAddRows = false;
            this.DgvPacientesRRP.AllowUserToDeleteRows = false;
            this.DgvPacientesRRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientesRRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Direccion,
            this.Celular,
            this.Telefono,
            this.Edad,
            this.Sexo,
            this.Email,
            this.EstadoCivil});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPacientesRRP.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPacientesRRP.Location = new System.Drawing.Point(56, 54);
            this.DgvPacientesRRP.Name = "DgvPacientesRRP";
            this.DgvPacientesRRP.ReadOnly = true;
            this.DgvPacientesRRP.RowHeadersWidth = 45;
            this.DgvPacientesRRP.RowTemplate.Height = 24;
            this.DgvPacientesRRP.Size = new System.Drawing.Size(1224, 252);
            this.DgvPacientesRRP.TabIndex = 26;
            this.DgvPacientesRRP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPacientesRRP_CellClick);
            // 
            // IdPaciente
            // 
            this.IdPaciente.HeaderText = "Id";
            this.IdPaciente.MinimumWidth = 6;
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido Paterno";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido Materno";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 125;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 6;
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono Fijo";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 50;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 50;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.MinimumWidth = 6;
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            this.EstadoCivil.Width = 125;
            // 
            // BtnRegresarRRP
            // 
            this.BtnRegresarRRP.BackColor = System.Drawing.Color.DarkViolet;
            this.BtnRegresarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnRegresarRRP.Location = new System.Drawing.Point(1278, 722);
            this.BtnRegresarRRP.Name = "BtnRegresarRRP";
            this.BtnRegresarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnRegresarRRP.TabIndex = 27;
            this.BtnRegresarRRP.Text = "Regresar";
            this.BtnRegresarRRP.UseVisualStyleBackColor = false;
            this.BtnRegresarRRP.Click += new System.EventHandler(this.BtnRegresarRRP_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 42);
            this.label11.TabIndex = 30;
            this.label11.Text = "Pacientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 42);
            this.label5.TabIndex = 31;
            this.label5.Text = "Médicos";
            // 
            // TxtIdDoctorRRP
            // 
            this.TxtIdDoctorRRP.Enabled = false;
            this.TxtIdDoctorRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdDoctorRRP.Location = new System.Drawing.Point(1351, 191);
            this.TxtIdDoctorRRP.Name = "TxtIdDoctorRRP";
            this.TxtIdDoctorRRP.Size = new System.Drawing.Size(104, 27);
            this.TxtIdDoctorRRP.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1346, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id Médico";
            // 
            // TxtIdPacienteRRP
            // 
            this.TxtIdPacienteRRP.Enabled = false;
            this.TxtIdPacienteRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdPacienteRRP.Location = new System.Drawing.Point(1351, 115);
            this.TxtIdPacienteRRP.Name = "TxtIdPacienteRRP";
            this.TxtIdPacienteRRP.Size = new System.Drawing.Size(105, 27);
            this.TxtIdPacienteRRP.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1346, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Id Paciente";
            // 
            // BtnAsignarRRP
            // 
            this.BtnAsignarRRP.BackColor = System.Drawing.Color.Lime;
            this.BtnAsignarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsignarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnAsignarRRP.Location = new System.Drawing.Point(70, 722);
            this.BtnAsignarRRP.Name = "BtnAsignarRRP";
            this.BtnAsignarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnAsignarRRP.TabIndex = 36;
            this.BtnAsignarRRP.Text = "Asignar";
            this.BtnAsignarRRP.UseVisualStyleBackColor = false;
            this.BtnAsignarRRP.Click += new System.EventHandler(this.BtnAsignarRRP_Click);
            // 
            // DgvPacienteMedicoRRP
            // 
            this.DgvPacienteMedicoRRP.AllowUserToAddRows = false;
            this.DgvPacienteMedicoRRP.AllowUserToDeleteRows = false;
            this.DgvPacienteMedicoRRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacienteMedicoRRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9});
            this.DgvPacienteMedicoRRP.Location = new System.Drawing.Point(971, 369);
            this.DgvPacienteMedicoRRP.Name = "DgvPacienteMedicoRRP";
            this.DgvPacienteMedicoRRP.ReadOnly = true;
            this.DgvPacienteMedicoRRP.RowHeadersWidth = 45;
            this.DgvPacienteMedicoRRP.RowTemplate.Height = 24;
            this.DgvPacienteMedicoRRP.Size = new System.Drawing.Size(624, 324);
            this.DgvPacienteMedicoRRP.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Paciente";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Médico";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Especialidad";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(973, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 42);
            this.label2.TabIndex = 38;
            this.label2.Text = "Pacientes-Médicos";
            // 
            // AsignarDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1609, 796);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvPacienteMedicoRRP);
            this.Controls.Add(this.BtnAsignarRRP);
            this.Controls.Add(this.TxtIdPacienteRRP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdDoctorRRP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnRegresarRRP);
            this.Controls.Add(this.DgvPacientesRRP);
            this.Controls.Add(this.DgvMedicosRRP);
            this.Name = "AsignarDoctorForm";
            this.Text = "Asignación de doctores";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosRRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesRRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacienteMedicoRRP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMedicosRRP;
        private System.Windows.Forms.DataGridView DgvPacientesRRP;
        private System.Windows.Forms.Button BtnRegresarRRP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIdDoctorRRP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdPacienteRRP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.Button BtnAsignarRRP;
        private System.Windows.Forms.DataGridView DgvPacienteMedicoRRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label2;
    }
}