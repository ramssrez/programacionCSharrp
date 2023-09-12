namespace DSDPRN3RRP2302B1
{
    partial class PacientesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrbSexoRRP = new System.Windows.Forms.GroupBox();
            this.RgbMasculinoRRP = new System.Windows.Forms.RadioButton();
            this.RgbFemeninoRRP = new System.Windows.Forms.RadioButton();
            this.CbxEdoCivilRRP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreCRRP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtApellidoMaternoCRRP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtEdadCRRP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtApellidoPaternoCRRP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDireccionCRRP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtIdRRP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmailCRRP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTelefonoCelularCRRP = new System.Windows.Forms.TextBox();
            this.TxtTelefonoFijoCRRP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvPacientesRRP = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarRRP = new System.Windows.Forms.Button();
            this.TxtBuscarRRP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnGuardarRRP = new System.Windows.Forms.Button();
            this.BtnEliminarRRP = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnRegresarRRP = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.GrbSexoRRP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesRRP)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbSexoRRP
            // 
            this.GrbSexoRRP.Controls.Add(this.RgbMasculinoRRP);
            this.GrbSexoRRP.Controls.Add(this.RgbFemeninoRRP);
            this.GrbSexoRRP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbSexoRRP.Location = new System.Drawing.Point(519, 41);
            this.GrbSexoRRP.Name = "GrbSexoRRP";
            this.GrbSexoRRP.Size = new System.Drawing.Size(181, 100);
            this.GrbSexoRRP.TabIndex = 1;
            this.GrbSexoRRP.TabStop = false;
            this.GrbSexoRRP.Text = "Sexo";
            // 
            // RgbMasculinoRRP
            // 
            this.RgbMasculinoRRP.AutoSize = true;
            this.RgbMasculinoRRP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RgbMasculinoRRP.Location = new System.Drawing.Point(17, 47);
            this.RgbMasculinoRRP.Name = "RgbMasculinoRRP";
            this.RgbMasculinoRRP.Size = new System.Drawing.Size(135, 30);
            this.RgbMasculinoRRP.TabIndex = 1;
            this.RgbMasculinoRRP.TabStop = true;
            this.RgbMasculinoRRP.Text = "Masculino";
            this.RgbMasculinoRRP.UseVisualStyleBackColor = true;
            // 
            // RgbFemeninoRRP
            // 
            this.RgbFemeninoRRP.AutoSize = true;
            this.RgbFemeninoRRP.Checked = true;
            this.RgbFemeninoRRP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RgbFemeninoRRP.Location = new System.Drawing.Point(17, 21);
            this.RgbFemeninoRRP.Name = "RgbFemeninoRRP";
            this.RgbFemeninoRRP.Size = new System.Drawing.Size(133, 30);
            this.RgbFemeninoRRP.TabIndex = 0;
            this.RgbFemeninoRRP.TabStop = true;
            this.RgbFemeninoRRP.Text = "Femenino";
            this.RgbFemeninoRRP.UseVisualStyleBackColor = true;
            // 
            // CbxEdoCivilRRP
            // 
            this.CbxEdoCivilRRP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEdoCivilRRP.FormattingEnabled = true;
            this.CbxEdoCivilRRP.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)",
            "Viudo(a)",
            "Divorciado(a)",
            "Concubinato(a)"});
            this.CbxEdoCivilRRP.Location = new System.Drawing.Point(519, 177);
            this.CbxEdoCivilRRP.Name = "CbxEdoCivilRRP";
            this.CbxEdoCivilRRP.Size = new System.Drawing.Size(199, 34);
            this.CbxEdoCivilRRP.TabIndex = 2;
            this.CbxEdoCivilRRP.Text = "Estado Civil";
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
            // TxtNombreCRRP
            // 
            this.TxtNombreCRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCRRP.Location = new System.Drawing.Point(221, 41);
            this.TxtNombreCRRP.Name = "TxtNombreCRRP";
            this.TxtNombreCRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtNombreCRRP.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtApellidoMaternoCRRP);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtEdadCRRP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtApellidoPaternoCRRP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GrbSexoRRP);
            this.groupBox1.Controls.Add(this.TxtNombreCRRP);
            this.groupBox1.Controls.Add(this.CbxEdoCivilRRP);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 260);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre Completo";
            // 
            // TxtApellidoMaternoCRRP
            // 
            this.TxtApellidoMaternoCRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoMaternoCRRP.Location = new System.Drawing.Point(221, 148);
            this.TxtApellidoMaternoCRRP.Name = "TxtApellidoMaternoCRRP";
            this.TxtApellidoMaternoCRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtApellidoMaternoCRRP.TabIndex = 12;
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
            // TxtEdadCRRP
            // 
            this.TxtEdadCRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdadCRRP.Location = new System.Drawing.Point(221, 203);
            this.TxtEdadCRRP.Name = "TxtEdadCRRP";
            this.TxtEdadCRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtEdadCRRP.TabIndex = 10;
            this.TxtEdadCRRP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEdadCRRP_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "Edad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(514, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Seleccione";
            // 
            // TxtApellidoPaternoCRRP
            // 
            this.TxtApellidoPaternoCRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoPaternoCRRP.Location = new System.Drawing.Point(221, 93);
            this.TxtApellidoPaternoCRRP.Name = "TxtApellidoPaternoCRRP";
            this.TxtApellidoPaternoCRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtApellidoPaternoCRRP.TabIndex = 7;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDireccionCRRP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 160);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dirección";
            // 
            // TxtDireccionCRRP
            // 
            this.TxtDireccionCRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionCRRP.Location = new System.Drawing.Point(273, 50);
            this.TxtDireccionCRRP.Name = "TxtDireccionCRRP";
            this.TxtDireccionCRRP.Size = new System.Drawing.Size(545, 27);
            this.TxtDireccionCRRP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección completa:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtIdRRP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TxtEmailCRRP);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtTelefonoCelularCRRP);
            this.groupBox3.Controls.Add(this.TxtTelefonoFijoCRRP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(781, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 260);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacto";
            // 
            // TxtIdRRP
            // 
            this.TxtIdRRP.Enabled = false;
            this.TxtIdRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdRRP.Location = new System.Drawing.Point(107, 200);
            this.TxtIdRRP.Name = "TxtIdRRP";
            this.TxtIdRRP.Size = new System.Drawing.Size(66, 27);
            this.TxtIdRRP.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Id:";
            // 
            // TxtEmailCRRP
            // 
            this.TxtEmailCRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailCRRP.Location = new System.Drawing.Point(107, 143);
            this.TxtEmailCRRP.Name = "TxtEmailCRRP";
            this.TxtEmailCRRP.Size = new System.Drawing.Size(350, 27);
            this.TxtEmailCRRP.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email:";
            // 
            // TxtTelefonoCelularCRRP
            // 
            this.TxtTelefonoCelularCRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoCelularCRRP.Location = new System.Drawing.Point(214, 47);
            this.TxtTelefonoCelularCRRP.Name = "TxtTelefonoCelularCRRP";
            this.TxtTelefonoCelularCRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtTelefonoCelularCRRP.TabIndex = 11;
            this.TxtTelefonoCelularCRRP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoCelularCRRP_KeyPress);
            // 
            // TxtTelefonoFijoCRRP
            // 
            this.TxtTelefonoFijoCRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoFijoCRRP.Location = new System.Drawing.Point(214, 93);
            this.TxtTelefonoFijoCRRP.Name = "TxtTelefonoFijoCRRP";
            this.TxtTelefonoFijoCRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtTelefonoFijoCRRP.TabIndex = 8;
            this.TxtTelefonoFijoCRRP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoFijoCRRP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Teléfono Fijo:";
            // 
            // DgvPacientesRRP
            // 
            this.DgvPacientesRRP.AllowUserToAddRows = false;
            this.DgvPacientesRRP.AllowUserToDeleteRows = false;
            this.DgvPacientesRRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientesRRP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.Direccion,
            this.Celular,
            this.Telefono,
            this.Edad,
            this.Sexo,
            this.Email,
            this.EstadoCivil});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPacientesRRP.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvPacientesRRP.Location = new System.Drawing.Point(29, 506);
            this.DgvPacientesRRP.Name = "DgvPacientesRRP";
            this.DgvPacientesRRP.ReadOnly = true;
            this.DgvPacientesRRP.RowHeadersWidth = 45;
            this.DgvPacientesRRP.RowTemplate.Height = 24;
            this.DgvPacientesRRP.Size = new System.Drawing.Size(1224, 252);
            this.DgvPacientesRRP.TabIndex = 12;
            this.DgvPacientesRRP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPacientesRRP_CellClick);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarRRP);
            this.groupBox4.Controls.Add(this.TxtBuscarRRP);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(888, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 166);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda";
            // 
            // btnBuscarRRP
            // 
            this.btnBuscarRRP.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRRP.ForeColor = System.Drawing.Color.Snow;
            this.btnBuscarRRP.Location = new System.Drawing.Point(30, 98);
            this.btnBuscarRRP.Name = "btnBuscarRRP";
            this.btnBuscarRRP.Size = new System.Drawing.Size(307, 62);
            this.btnBuscarRRP.TabIndex = 18;
            this.btnBuscarRRP.Text = "Buscar";
            this.btnBuscarRRP.UseVisualStyleBackColor = false;
            this.btnBuscarRRP.Click += new System.EventHandler(this.btnBuscarRRP_Click);
            // 
            // TxtBuscarRRP
            // 
            this.TxtBuscarRRP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarRRP.Location = new System.Drawing.Point(107, 50);
            this.TxtBuscarRRP.Name = "TxtBuscarRRP";
            this.TxtBuscarRRP.Size = new System.Drawing.Size(243, 27);
            this.TxtBuscarRRP.TabIndex = 8;
            this.TxtBuscarRRP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscarRRP_KeyDown);
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
            // BtnGuardarRRP
            // 
            this.BtnGuardarRRP.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnGuardarRRP.Location = new System.Drawing.Point(2, 774);
            this.BtnGuardarRRP.Name = "BtnGuardarRRP";
            this.BtnGuardarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnGuardarRRP.TabIndex = 9;
            this.BtnGuardarRRP.Text = "Agregar";
            this.BtnGuardarRRP.UseVisualStyleBackColor = false;
            this.BtnGuardarRRP.Click += new System.EventHandler(this.BtnGuardarRRP_Click);
            // 
            // BtnEliminarRRP
            // 
            this.BtnEliminarRRP.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnEliminarRRP.Location = new System.Drawing.Point(655, 774);
            this.BtnEliminarRRP.Name = "BtnEliminarRRP";
            this.BtnEliminarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnEliminarRRP.TabIndex = 16;
            this.BtnEliminarRRP.Text = "Eliminar";
            this.BtnEliminarRRP.UseVisualStyleBackColor = false;
            this.BtnEliminarRRP.Click += new System.EventHandler(this.BtnEliminarRRP_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Gold;
            this.BtnActualizar.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.Snow;
            this.BtnActualizar.Location = new System.Drawing.Point(329, 774);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(307, 62);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnRegresarRRP
            // 
            this.BtnRegresarRRP.BackColor = System.Drawing.Color.DarkViolet;
            this.BtnRegresarRRP.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresarRRP.ForeColor = System.Drawing.Color.Snow;
            this.BtnRegresarRRP.Location = new System.Drawing.Point(968, 774);
            this.BtnRegresarRRP.Name = "BtnRegresarRRP";
            this.BtnRegresarRRP.Size = new System.Drawing.Size(307, 62);
            this.BtnRegresarRRP.TabIndex = 18;
            this.BtnRegresarRRP.Text = "Regresar";
            this.BtnRegresarRRP.UseVisualStyleBackColor = false;
            this.BtnRegresarRRP.Click += new System.EventHandler(this.BtnRegresarRRP_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 42);
            this.label11.TabIndex = 29;
            this.label11.Text = "Pacientes";
            // 
            // PacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1312, 872);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnRegresarRRP);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminarRRP);
            this.Controls.Add(this.BtnGuardarRRP);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DgvPacientesRRP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PacientesForm";
            this.Text = "Pacientes";
            this.GrbSexoRRP.ResumeLayout(false);
            this.GrbSexoRRP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesRRP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GrbSexoRRP;
        private System.Windows.Forms.RadioButton RgbMasculinoRRP;
        private System.Windows.Forms.RadioButton RgbFemeninoRRP;
        private System.Windows.Forms.ComboBox CbxEdoCivilRRP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombreCRRP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtApellidoPaternoCRRP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccionCRRP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelefonoCelularCRRP;
        private System.Windows.Forms.TextBox TxtTelefonoFijoCRRP;
        private System.Windows.Forms.TextBox TxtEdadCRRP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEmailCRRP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DgvPacientesRRP;
        private System.Windows.Forms.TextBox TxtApellidoMaternoCRRP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtBuscarRRP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnGuardarRRP;
        private System.Windows.Forms.Button BtnEliminarRRP;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button btnBuscarRRP;
        private System.Windows.Forms.Button BtnRegresarRRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.TextBox TxtIdRRP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
    }
}

