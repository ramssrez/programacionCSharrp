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
            CargarDatosPacientes();
        }

        private void CargarDatosPacientes(string filtro = "")
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
            CargarDatosPacientes(TxtBuscarRRP.Text.Trim());
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
            if (TxtDireccionCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la calle");
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
                MessageBox.Show("Se ha agregado un paciente");
                CargarDatosPacientes();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            TxtNombreCRRP.Text = "";
            TxtApellidoMaternoCRRP.Text = "";
            TxtApellidoPaternoCRRP.Text = "";
            TxtDireccionCRRP.Text = "";
            TxtTelefonoCelularCRRP.Text = "";
            TxtTelefonoFijoCRRP.Text = "";
            TxtEmailCRRP.Text = "";
            TxtEdadCRRP.Text = "";
            TxtIdRRP.Text = "";
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
            PacienteRRP.IdRRP = GetIdPaciente();
            PacienteRRP.NombreRRP = TxtNombreCRRP.Text.Trim();
            PacienteRRP.ApellidoPaternoRRP = TxtApellidoPaternoCRRP.Text.Trim();
            PacienteRRP.ApellidoMaternoRRP = TxtApellidoMaternoCRRP.Text.Trim();
            PacienteRRP.DireccionRRP = TxtDireccionCRRP.Text.Trim();
            PacienteRRP.CelularRRP = TxtTelefonoCelularCRRP.Text.Trim();
            PacienteRRP.TelefonoFijoRRP = TxtTelefonoFijoCRRP.Text.Trim();
            PacienteRRP.EdadRRP = int.Parse(TxtEdadCRRP.Text.Trim());
            PacienteRRP.SexoRRP = sexoRRP;
            PacienteRRP.EmailRRP = TxtEmailCRRP.Text.Trim();
            PacienteRRP.EstadoCivilRRP = CbxEdoCivilRRP.SelectedIndex+1;
        }

        private int GetIdPaciente()
        {
            int numberRRP = -1;
            if (!TxtIdRRP.Text.Trim().Equals(""))
            {
                if (int.TryParse(TxtIdRRP.Text.Trim(), out int ids))
                {
                    numberRRP = ids;
                }
            }
            return numberRRP;
        }

        private void DgvPacientesRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvPacientesRRP.Rows[e.RowIndex];
            TxtIdRRP.Text = Convert.ToString(filaRRP.Cells["Id"].Value);
            TxtNombreCRRP.Text = Convert.ToString(filaRRP.Cells["Nombre"].Value);
            TxtApellidoPaternoCRRP.Text = Convert.ToString(filaRRP.Cells["ApellidoPaterno"].Value);
            TxtApellidoMaternoCRRP.Text = Convert.ToString(filaRRP.Cells["ApellidoMaterno"].Value);
            TxtEdadCRRP.Text = Convert.ToString(filaRRP.Cells["Edad"].Value);
            TxtTelefonoFijoCRRP.Text = Convert.ToString(filaRRP.Cells["Telefono"].Value);
            TxtTelefonoCelularCRRP.Text = Convert.ToString(filaRRP.Cells["Celular"].Value);
            TxtEmailCRRP.Text = Convert.ToString(filaRRP.Cells["Email"].Value);
            TxtDireccionCRRP.Text = Convert.ToString(filaRRP.Cells["Direccion"].Value);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!DatosCorrecto())
            {
                return;
            }
            CargarPaciente();
            if (PacienteConsultasRRP.ModificarPaciente(PacienteRRP))
            {
                MessageBox.Show("Se ha modificado un paciente");
                CargarDatosPacientes();
                LimpiarCampos();
            }
        }

        private void BtnEliminarRRP_Click(object sender, EventArgs e)
        {
            if (GetIdPaciente() == -1)
            {
                return;
            }
            //CargarDatosPacientes();
            if (MessageBox.Show("¿Desea eliminar el paciente?","Eliminar paciente",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CargarPaciente();
                if (PacienteConsultasRRP.EliminarPaciente(PacienteRRP))
                {
                    MessageBox.Show("Se ha Eliminado un paciente");
                    CargarDatosPacientes();
                    LimpiarCampos();
                }
            }
        }
    }
}
