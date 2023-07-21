namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tableAlumnos = new DataGridView();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            ((System.ComponentModel.ISupportInitialize)tableAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 28);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 0;
            label1.Text = "Lista de Alumnos";
            // 
            // tableAlumnos
            // 
            tableAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableAlumnos.Location = new Point(55, 135);
            tableAlumnos.Name = "tableAlumnos";
            tableAlumnos.RowHeadersWidth = 51;
            tableAlumnos.RowTemplate.Height = 29;
            tableAlumnos.Size = new Size(691, 275);
            tableAlumnos.TabIndex = 1;
            // 
            // btnUno
            // 
            btnUno.Location = new Point(104, 65);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(138, 48);
            btnUno.TabIndex = 2;
            btnUno.Text = "Listar sin sp";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += btnUno_Click;
            // 
            // btnDos
            // 
            btnDos.Location = new Point(260, 65);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(163, 48);
            btnDos.TabIndex = 3;
            btnDos.Text = "Listar con sp";
            btnDos.UseVisualStyleBackColor = true;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(451, 66);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(169, 48);
            btnTres.TabIndex = 4;
            btnTres.Text = "Listar median un list";
            btnTres.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(tableAlumnos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tableAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView tableAlumnos;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
    }
}