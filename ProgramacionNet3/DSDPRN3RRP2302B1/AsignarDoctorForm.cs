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
    //Clase para crear un form de asignar doctor
    public partial class AsignarDoctorForm : Form
    {
        //Variables para poder realizar la conexión y consultas a diferentes tablas
        private List<Medico> ListMedicosRRP;
        private MedicoConsultas MedicoConsultasRRP;
        private Medico MedicoRRP;
        private List<Paciente> ListPacientesRRP;
        private PacienteConsultas PacienteConsultasRRP;
        private Paciente PacienteRRP;
        private PacienteMedicoConsultasRRP PacienteMedicoConsultasRRP;
        private List<PacienteMedico> ListPacienteMedicosRRP;
        //Constructor del form de AsignarDoctorForm.
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
        //Método que permite cargar los médicos en un DataGridView.
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
        //Método que permite cargar los pacientes en un DataGridView.
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
        //Métodó para cargar los pacientes sin doctor
        private void CargarDatosPacientesSinDoctor()
        {
            DgvPacientesRRP.Rows.Clear();
            DgvPacientesRRP.Refresh();
            ListPacientesRRP.Clear();
            ListPacientesRRP = PacienteConsultasRRP.GetPacientesWioutMedicos();
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
        //Método que permite cargar las relaciones de pacientes y doctores.
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
        //Método que permite regresar al menú principal del proyecto.
        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menú principal?", "Regresar al menú", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        //Método que permite realizar el guardado de los datos al momento de realizar click.
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
                CargarDatosPacientes();
                LimpiarCampos();
                DgvMedicosRRP.ClearSelection();
                DgvPacientesRRP.ClearSelection();
            }
        }
        //Método que limpia los campos de texto utilizados
        private void LimpiarCampos()
        {
            TxtIdDoctorRRP.Text = "";
            TxtIdPacienteRRP.Text = "";
            TxtIdPacienteMedicoRRP.Text = "";
        }
        //Método que permite eliminar un registro de la tabla de médicos.
        private void BtnEliminarRRP_Click(object sender, EventArgs e)
        {
            if (GetIdMedicoPaciente() == -1)
            {
                MessageBox.Show("No se ha seleccionado una opción de la tabla de paciente-médico");
                return;
            }
            if (MessageBox.Show("¿Desea eliminar la relación paciente-médico?", "Eliminar paciente-médico", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (PacienteMedicoConsultasRRP.EliminarPacienteMedico(int.Parse(TxtIdPacienteMedicoRRP.Text.Trim())))
                {
                    MessageBox.Show("Se ha eliminado la relación paciente-médico");
                    CargarDatosPacientesDoctores();
                    CargarDatosPacientes();
                    LimpiarCampos();
                }
            }
        }
        //Método que obtiene el id de la relación paciente-medico
        private int GetIdMedicoPaciente()
        {
            int numberRRP = -1;
            if (!TxtIdPacienteMedicoRRP.Text.Trim().Equals(""))
            {
                if (int.TryParse(TxtIdPacienteMedicoRRP.Text.Trim(), out int ids))
                {
                    numberRRP = ids;
                }
            }
            return numberRRP;
        }
        //Método que permite seleccionar una opción de la DataGridView y los datos obtenidos agregarlos a los caja de texto.
        private void DgvPacienteMedicoRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvPacienteMedicoRRP.Rows[e.RowIndex];
            TxtIdPacienteMedicoRRP.Text = Convert.ToString(filaRRP.Cells["idPacienteMedico"].Value);
        }
        //Método que permite seleccionar una opción de la DataGridView y los datos obtenidos agregarlos a los caja de texto.
        private void DgvPacientesRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvPacientesRRP.Rows[e.RowIndex];
            TxtIdPacienteRRP.Text = Convert.ToString(filaRRP.Cells["IdPaciente"].Value);
        }
        //Método que permite seleccionar una opción de la DataGridView y los datos obtenidos agregarlos a los caja de texto.
        private void DgvMedicosRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvMedicosRRP.Rows[e.RowIndex];
            TxtIdDoctorRRP.Text = Convert.ToString(filaRRP.Cells["IdMedico"].Value);
        }
        //Metodo para poder realizar la busqueda de los pacientes sin médico
        private void BtnPacientesSinMedicoRRP_Click(object sender, EventArgs e)
        {
            CargarDatosPacientesSinDoctor();
            if (DgvPacientesRRP.RowCount == 0)
            {
                MessageBox.Show("No se han encontrado datos");
            }
        }
    }
}
