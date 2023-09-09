using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDPRN3RRP2302B1
{
    internal class LeerTxt
    {
        public List<Paciente> pacientesRRP = new List<Paciente>();
        public void LecturaArchivo(DataGridView tablaRRP, char characterRRP, string rutaRRP)
        {
            StreamReader StreamReaderRRP = new StreamReader(rutaRRP);
            string sLineRRP = "";
            int filaRRP = 0;
            tablaRRP.Rows.Clear();
            tablaRRP.AllowUserToAddRows = false;
            tablaRRP.RowTemplate.Height = 25;
            do
            {
                sLineRRP=StreamReaderRRP.ReadLine();
                if (sLineRRP!=null)
                {
                    if (filaRRP == 0)
                    {
                        tablaRRP.ColumnCount = sLineRRP.Split(characterRRP).Length;
                        nombrarTitulo(tablaRRP, sLineRRP.Split(characterRRP));
                        filaRRP += 1;
                    }
                    else
                    {
                        agregarFilaDataGridView(tablaRRP, sLineRRP,characterRRP);
                        filaRRP += 1;
                    }
                }
            }
            while (!(sLineRRP == null));
            StreamReaderRRP.Close();
        }

        private void agregarFilaDataGridView(DataGridView tablaRRP, string sLineRRP, char characterRRP)
        {
            string[] arregloRRP = sLineRRP.Split(characterRRP);
            tablaRRP.Rows.Add(arregloRRP);
        }
        private void nombrarTitulo(DataGridView tablaRRP, string[] titulosRRP)
        {
            for (int i = 0; i <= tablaRRP.ColumnCount - 1; i++)
            {
                tablaRRP.Columns[i].HeaderText = titulosRRP[i];
            }
        }
    }
}
