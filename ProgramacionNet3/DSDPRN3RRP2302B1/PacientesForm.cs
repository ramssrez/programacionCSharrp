using MySql.Data.MySqlClient;
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
    public partial class PacientesForm : Form
    {
        private List<Paciente> ListPacientesRRP;
        private PacienteConsultas PacienteConsultasRRP;
        private Paciente PacienteRRP;
        public PacientesForm()
        {
            InitializeComponent();
            ListPacientesRRP = new List<Paciente>();
            PacienteConsultasRRP = new PacienteConsultas();
            PacienteRRP = new Paciente();
            CargarPacientes();
        }

        private void CargarPacientes(string filtro = "")
        {
            DgvPacientesRRP.Rows.Clear();
            DgvPacientesRRP.Refresh();
            ListPacientesRRP.Clear();
            ListPacientesRRP = PacienteConsultasRRP.GetPacientes(filtro);
            for (int i = 0; i < ListPacientesRRP.Count(); i++)
            {
                DgvPacientesRRP.RowTemplate.Height = 50;
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
        private void btnBuscarRRP_Click(object sender, EventArgs e)
        {
            CargarPacientes(TxtBuscarRRP.Text.Trim());
        }
        private bool DatosCorrecto()
        {
            if (TxtNombreCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }
            if (TxtApellidoPaternoCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el apellido paterno");
                return false;
            }
            if (TxtApellidoMaternoCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el apellido materno");
                return false;
            }
            if (TxtTelefonoCelularCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el telefono fijo");
                return false;
            }
            if (TxtTelefonoCelularCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el telefono celular");
                return false;
            }
            if (TxtEmailCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el email");
                return false;
            }
            if (TxtCiudadCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la ciudad");
                return false;
            }
            if (TxtCalleCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la calle");
                return false;
            }
            if (TxtCodigoPostalCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el código postal");
                return false;
            }
            if (TxtEstadoCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el estado");
                return false;
            }
            if (!int.TryParse(TxtEdadCRRP.Text.Trim(),out int edad))
            {
                MessageBox.Show("Ingrese una edad correcta");
                return false;
            }
            return true;
        }

        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardarRRP_Click(object sender, EventArgs e)
        {
            if (!DatosCorrecto())
            {
                return;
            }
            CargarPaciente();
            if (PacienteConsultasRRP.AgregarPaciente(PacienteRRP))
            {
                MessageBox.Show("Paciente agregado");
                CargarPacientes();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            TxtNombreCRRP.Text = "";
            TxtApellidoMaternoCRRP.Text = "";
            TxtApellidoPaternoCRRP.Text = "";
            TxtCalleCRRP.Text = "";
            TxtCiudadCRRP.Text = "";
            TxtEstadoCRRP.Text = "";
            TxtCodigoPostalCRRP.Text = "";
            TxtTelefonoCelularCRRP.Text = "";
            TxtTelefonoFijoCRRP.Text = "";
            TxtEmailCRRP.Text = "";
            TxtEdadCRRP.Text = "";
            //throw new NotImplementedException();
        }

        private void CargarPaciente()
        {
            char sexoRRP =' ';
            if (RgbFemeninoRRP.Checked)
            {
                sexoRRP = 'M';
            }
            else if (RgbMasculinoRRP.Checked)
            {
                sexoRRP ='H';
            }
            PacienteRRP.NombreRRP = TxtNombreCRRP.Text.Trim();
            PacienteRRP.ApellidoPaternoRRP = TxtApellidoPaternoCRRP.Text.Trim();
            PacienteRRP.ApellidoMaternoRRP = TxtApellidoMaternoCRRP.Text.Trim();
            PacienteRRP.DireccionRRP = TxtCalleCRRP.Text.Trim()+", "+TxtEstadoCRRP.Text.Trim()+", "+TxtCiudadCRRP.Text.Trim()+", "+TxtCodigoPostalCRRP.Text.Trim();
            PacienteRRP.CelularRRP = TxtTelefonoCelularCRRP.Text.Trim();
            PacienteRRP.TelefonoFijoRRP = TxtTelefonoFijoCRRP.Text.Trim();
            PacienteRRP.EdadRRP = int.Parse(TxtEdadCRRP.Text.Trim());
            PacienteRRP.SexoRRP = sexoRRP;
            PacienteRRP.EmailRRP = TxtEmailCRRP.Text.Trim();
            PacienteRRP.EstadoCivilRRP = CbxEdoCivilRRP.SelectedIndex+1;
            //throw new NotImplementedException();
        }
    }
}
