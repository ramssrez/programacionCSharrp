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
            PacientesForm pacientesForm = new PacientesForm();
            pacientesForm.ShowDialog();
        }

        private void BtnDoctoresRRP_Click(object sender, EventArgs e)
        {
            MedicoForm doctoresForm = new MedicoForm();
            doctoresForm.ShowDialog();
        }

        private void BtnEspecialidadesRRP_Click(object sender, EventArgs e)
        {
            EspecialidadesForm especialidadesForm = new EspecialidadesForm();
            especialidadesForm.ShowDialog();
        }
    }
}
