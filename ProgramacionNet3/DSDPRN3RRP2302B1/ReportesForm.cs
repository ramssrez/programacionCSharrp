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
    //Clase que crea el form para los reportes
    public partial class ReportesForm : Form
    {
        //Variables necesarias para realizar las diferentes consultas
        private MedicoConsultas MedicoConsultasRRP;
        private EspecialidadesConsultas EspecialidadesConsultasRRP;
        private PacienteConsultas PacienteConsultasRRP;
        private List<Paciente> PacientesRRP;
        private List<Medico> MedicosRRP;
        //Inicialización de la clase, así como la instancia de los atributos
        public ReportesForm()
        {
            InitializeComponent();
            MedicoConsultasRRP = new MedicoConsultas();
            PacienteConsultasRRP = new PacienteConsultas();
            EspecialidadesConsultasRRP = new EspecialidadesConsultas();
            PacientesRRP = new List<Paciente>();
            MedicosRRP = new List<Medico>();
            ObtenerNombresMedicos();
            ObtenerNombresEspecialidades();
        }
        //Método que obtiene el nombre de las especialidades
        private void ObtenerNombresEspecialidades()
        {
            List<string> strings = new List<string>();
            strings = EspecialidadesConsultasRRP.GetEspecialidadesNombre();
            for (int i = 0; i < strings.Count; i++)
            {
                CbxEspecialidadRRP.Items.Add(strings[i]);
            }
        }
        //Método que obtiene el nombre de los médicos
        private void ObtenerNombresMedicos()
        {
            List<string> strings = new List<string>();
            strings = MedicoConsultasRRP.NombresMedicos();
            for (int i = 0; i < strings.Count; i++)
            {
                CbxMedicosRRP.Items.Add(strings[i]);
            }
        }
        //Método que al momento de seleccionar un médico, realiza la busqueda en la base de datos.
        private void CbxMedicosRRP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPacientes($"{CbxMedicosRRP.Items[CbxMedicosRRP.SelectedIndex]}");
            if (DgvDatosRRP.RowCount == 0)
            {
                MessageBox.Show("No se han encontrado datos");
            }
        }
        //Método que carga la información de los pacientes al momento de agregar el nombre del doctor
        private void CargarPacientes(string filtro)
        {
            DgvDatosRRP.Rows.Clear();
            DgvDatosRRP.Refresh();
            PacientesRRP.Clear();
            PacientesRRP = PacienteConsultasRRP.GetPacientesPorNombreDoctor(filtro);
            for (int i = 0; i < PacientesRRP.Count(); i++)
            {
                DgvDatosRRP.RowTemplate.Height = 25;
                DgvDatosRRP.Rows.Add(
                    PacientesRRP[i].NombreRRP
                    );
            }
        }
        //Método que al momento de seleccionar una especialidad, realiza la busqueda en la base de datos.
        private void CbxEspecialidadRRP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMedicos($"{CbxEspecialidadRRP.Items[CbxEspecialidadRRP.SelectedIndex]}");
            if (DgvDatosEspecialidadRRP.RowCount == 0)
            {
                MessageBox.Show("No se han encontrado datos");
            }
        }
        //Método que carga la información de los médico al momento de agregar el nombre del doctor
        private void CargarMedicos(string filtro)
        {
            DgvDatosEspecialidadRRP.Rows.Clear();
            DgvDatosEspecialidadRRP.Refresh();
            MedicosRRP.Clear();
            MedicosRRP = MedicoConsultasRRP.GetMedicoPorEspecialidad(filtro);
            for (int i = 0; i < MedicosRRP.Count(); i++)
            {
                DgvDatosEspecialidadRRP.RowTemplate.Height = 25;
                DgvDatosEspecialidadRRP.Rows.Add(
                     MedicosRRP[i].NombreRRP
                    );
            }
        }
        //Método que permite regresar al menú principal de la aplicación
        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menú principal?", "Regresar al menú", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
