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
    //Clase para crear un form del menu
    public partial class MenuForm : Form
    {
        //Constructor del form del menu.
        public MenuForm()
        {
            InitializeComponent();
        }
        //Método que permite abrir el form de pacientes
        private void BtnPacientesRRP_Click(object sender, EventArgs e)
        {
            PacientesForm pacientesFormRRP = new PacientesForm();
            pacientesFormRRP.ShowDialog();
        }
        //Método que permite abrir el form de doctores
        private void BtnDoctoresRRP_Click(object sender, EventArgs e)
        {
            MedicoForm doctoresFormRRP = new MedicoForm();
            doctoresFormRRP.ShowDialog();
        }
        //Método que permites abrir el form de especialidades
        private void BtnEspecialidadesRRP_Click(object sender, EventArgs e)
        {
            EspecialidadesForm especialidadesFormRRP = new EspecialidadesForm();
            especialidadesFormRRP.ShowDialog();
        }
        //Método que permite abri el form de la importación txt 
         private void BtnExportarTxtRRP_Click(object sender, EventArgs e)
        {
            ImportarTxtForm importarTxtRRP = new ImportarTxtForm();
            importarTxtRRP.ShowDialog();
        }

        private void BtnAsignarDoctor_Click(object sender, EventArgs e)
        {
            AsignarDoctorForm asignarDoctorFormRRP  = new AsignarDoctorForm();
            asignarDoctorFormRRP.ShowDialog();
        }
    }
}
