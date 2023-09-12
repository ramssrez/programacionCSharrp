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
    public partial class AsignarDoctorForm : Form
    {
        private List<Medico> ListMedicosRRP;
        private MedicoConsultas MedicoConsultasRRP;
        private Medico MedicoRRP;
        private List<Paciente> ListPacientesRRP;
        private PacienteConsultas PacienteConsultasRRP;
        private Paciente PacienteRRP;
        private PacienteMedicoConsultasRRP PacienteMedicoConsultasRRP;
        private List<PacienteMedico> ListPacienteMedicosRRP;
        public AsignarDoctorForm()
        {
            InitializeComponent();
            ListMedicosRRP = new List<Medico>();
            MedicoConsultasRRP = new MedicoConsultas();
            PacienteMedicoConsultasRRP = new PacienteMedicoConsultasRRP();
            MedicoRRP = new Medico();
            ListPacientesRRP = new List<Paciente>();
            PacienteConsultasRRP = new PacienteConsultas();
            PacienteRRP = new Paciente();
            ListPacienteMedicosRRP = new List<PacienteMedico>();
            CargarDatosPacientes();
            CargarDatosMedico();
            CargarDatosPacientesDoctores();
        }

        private void CargarDatosMedico(string filtro = "")
        {
            DgvMedicosRRP.Rows.Clear();
            DgvMedicosRRP.Refresh();
            ListMedicosRRP.Clear();
            ListMedicosRRP = MedicoConsultasRRP.GetMedicos(filtro);
            for (int i = 0; i < ListMedicosRRP.Count(); i++)
            {
                DgvMedicosRRP.RowTemplate.Height = 25;
                DgvMedicosRRP.Rows.Add(
                    ListMedicosRRP[i].IdRRP,
                    ListMedicosRRP[i].NombreRRP,
                    ListMedicosRRP[i].ApellidoPaternoRRP,
                    ListMedicosRRP[i].ApellidoMaternoRRP,
                    ListMedicosRRP[i].CedulaRRP,
                    ListMedicosRRP[i].EspcialidadRRP
                    );
            }
        }

        private void CargarDatosPacientes(string filtro = "")
        {
            DgvPacientesRRP.Rows.Clear();
            DgvPacientesRRP.Refresh();
            ListPacientesRRP.Clear();
            ListPacientesRRP = PacienteConsultasRRP.GetPacientes(filtro);
            for (int i = 0; i < ListPacientesRRP.Count(); i++)
            {
                DgvPacientesRRP.RowTemplate.Height = 25;
                DgvPacientesRRP.Rows.Add(
                    ListPacientesRRP[i].IdRRP,
                    ListPacientesRRP[i].NombreRRP,
                    ListPacientesRRP[i].ApellidoPaternoRRP,
                    ListPacientesRRP[i].ApellidoMaternoRRP,
                    ListPacientesRRP[i].DireccionRRP,
                    ListPacientesRRP[i].CelularRRP,
                    ListPacientesRRP[i].TelefonoFijoRRP,
                    ListPacientesRRP[i].EdadRRP,
                    ListPacientesRRP[i].SexoRRP,
                    ListPacientesRRP[i].EmailRRP,
                    ListPacientesRRP[i].EstadoCivilStringRRP
                    );
            }
        }

        private void CargarDatosPacientesDoctores(string filtro = "")
        {
            DgvPacienteMedicoRRP.Rows.Clear();
            DgvPacienteMedicoRRP.Refresh();
            ListPacienteMedicosRRP.Clear();
            ListPacienteMedicosRRP = PacienteMedicoConsultasRRP.GetMedicoPacientes(filtro);
            for (int i = 0; i < ListPacienteMedicosRRP.Count; i++)
            {
                DgvPacienteMedicoRRP.RowTemplate.Height = 25;
                DgvPacienteMedicoRRP.Rows.Add(
                    ListPacienteMedicosRRP[i].IdRRP,
                    ListPacienteMedicosRRP[i].PacienteRRP,
                    ListPacienteMedicosRRP[i].MedicoRRP,
                    ListPacienteMedicosRRP[i].EspecialidadRRP
                    );
            }

        }
        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menú principal?", "Regresar al menú", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void DgvPacientesRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvPacientesRRP.Rows[e.RowIndex];
            TxtIdPacienteRRP.Text = Convert.ToString(filaRRP.Cells["IdPaciente"].Value);
        }

        private void DgvMedicosRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvMedicosRRP.Rows[e.RowIndex];
            TxtIdDoctorRRP.Text = Convert.ToString(filaRRP.Cells["IdMedico"].Value);
        }

        private void BtnAsignarRRP_Click(object sender, EventArgs e)
        {
            if (TxtIdPacienteRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha seleccionado una opción de la tabla de pacientes");
                return;
            }
            if (TxtIdDoctorRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha seleccionado una opción de la tabla de médicos");
                return;
            }
            if (PacienteMedicoConsultasRRP.AsignarPacienteMedico(int.Parse(TxtIdPacienteRRP.Text.Trim()),int.Parse(TxtIdDoctorRRP.Text.Trim())))
            {
                MessageBox.Show("Se ha asignado un médico al paciente");
                CargarDatosPacientesDoctores();
                LimpiarCampos();
                DgvMedicosRRP.ClearSelection();
                DgvPacientesRRP.ClearSelection();
            }
        }

        private void LimpiarCampos()
        {
            TxtIdDoctorRRP.Text = "";
            TxtIdPacienteRRP.Text = "";
        }
    }
}
