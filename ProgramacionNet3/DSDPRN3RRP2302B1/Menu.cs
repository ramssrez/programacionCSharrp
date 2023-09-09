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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnPacientesRRP_Click(object sender, EventArgs e)
        {
            PacientesForm pacientesFormRRP = new PacientesForm();
            pacientesFormRRP.ShowDialog();
        }

        private void BtnDoctoresRRP_Click(object sender, EventArgs e)
        {
            MedicoForm doctoresFormRRP = new MedicoForm();
            doctoresFormRRP.ShowDialog();
        }

        private void BtnEspecialidadesRRP_Click(object sender, EventArgs e)
        {
            EspecialidadesForm especialidadesFormRRP = new EspecialidadesForm();
            especialidadesFormRRP.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportarTxt importarTxtRRP = new ImportarTxt();
            importarTxtRRP.ShowDialog();
        }
    }
}
