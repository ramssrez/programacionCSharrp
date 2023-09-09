using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDPRN3RRP2302B1
{
    public partial class ImportarTxt : Form
    {
        private LeerTxt LeerTxtRRP;
        public string ArchivoRRP = "";
        private List<Paciente> PacienteListRRP;
        public ImportarTxt()
        {
            InitializeComponent();
            LeerTxtRRP = new LeerTxt();
        }

        private void BtnAbrirTxtRRP_Click(object sender, EventArgs e)
        {
            CargarArchivo();
        }

        private void CargarArchivo()
        {
            try
            {
                //this.Opacity
                this.openFileDialog1.ShowDialog();
                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                {
                    ArchivoRRP = this.openFileDialog1.FileName;
                    LeerTxtRRP.LecturaArchivo(DgvDatosTxtRRP,',',ArchivoRRP);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menú principal?", "Regresar al menú", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
