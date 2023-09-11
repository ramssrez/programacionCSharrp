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
    //Clase para crear un form para importar un txt
    public partial class ImportarTxtForm : Form
    {
        //Variables para realizar las actividades necesarias para el form
        private LeerTxt LeerTxtRRP;
        public string ArchivoRRP = "";
        //Constructor del form de importar txt.
        public ImportarTxtForm()
        {
            InitializeComponent();
            LeerTxtRRP = new LeerTxt();
        }
        //Método que llama al metodo que se encarga de abrir el open dialog
        private void BtnAbrirTxtRRP_Click(object sender, EventArgs e)
        {
            CargarArchivo();
        }
        //Método que abre un opendialog, para seleccionar el archivo txt
        private void CargarArchivo()
        {
            try
            {
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
        //Método que permite regresar al menu principal
        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menú principal?", "Regresar al menú", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
