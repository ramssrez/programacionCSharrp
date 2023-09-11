using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DSDPRN3RRP2302B1
{
    //Clase para crear un form de medicos
    public partial class PacientesForm : Form
    {
        //Variables para poder realizar la conexión y la consulta de tabla de médicos
        private List<Paciente> ListPacientesRRP;
        private PacienteConsultas PacienteConsultasRRP;
        private Paciente PacienteRRP;
        //Constructor del form de pacientes.
        public PacientesForm()
        {
            InitializeComponent();
            ListPacientesRRP = new List<Paciente>();
            PacienteConsultasRRP = new PacienteConsultas();
            PacienteRRP = new Paciente();
            CargarDatosPacientes();
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
        //Método que permite buscar un médico por medio de un texto y que sea por medio de un click en el boton
        private void btnBuscarRRP_Click(object sender, EventArgs e)
        {
            CargarDatosPacientes(TxtBuscarRRP.Text.Trim());
            TxtBuscarRRP.Text = "";
            if (DgvPacientesRRP.RowCount == 0)
            {
                MessageBox.Show("No se han encontrado datos");
            }
        }
        //Método que permite verificar diferentes tipos de datos, si es de un tipo o si esta vacío.
        private bool DatosCorrecto()
        {
            int caracterUno = 3;
            int caracterDos = 100;
            int caracterTres = 5;
            //Validaciones para el campo de nombre
            if (TxtNombreCRRP.Text.Trim().Equals(""))
            {
                TxtNombreCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_NOMBRE);
                TxtNombreCRRP.Focus();
                return false;
            }
            if (!(TxtNombreCRRP.Text.Length >= caracterUno && TxtNombreCRRP.Text.Length <= caracterDos))
            {
                TxtNombreCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.RangoOpciones(caracterUno, caracterDos));
                TxtNombreCRRP.Focus();

                return false;
            }
            if (!Regex.IsMatch(TxtNombreCRRP.Text.Trim(), SentenciaSQLAndStrings.PatronDatosRRP))
            {
                TxtNombreCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.NO_CARACTERES_ESPECIALES);
                TxtNombreCRRP.Focus();
                return false;
            }

            //Validaciones para el campo de apellido paterno
            if (TxtApellidoPaternoCRRP.Text.Trim().Equals(""))
            {
                TxtApellidoPaternoCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_APELLIDO_PATERNO);
                TxtApellidoPaternoCRRP.Focus();
                return false;
            }
            if (!(TxtApellidoPaternoCRRP.Text.Length >= caracterUno && TxtApellidoPaternoCRRP.Text.Length <= caracterDos))
            {
                TxtApellidoPaternoCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.RangoOpciones(caracterUno, caracterDos));
                TxtApellidoPaternoCRRP.Focus();
                return false;
            }
            if (!Regex.IsMatch(TxtApellidoPaternoCRRP.Text.Trim(), SentenciaSQLAndStrings.PatronDatosRRP))
            {
                TxtApellidoPaternoCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.NO_CARACTERES_ESPECIALES);
                TxtApellidoPaternoCRRP.Focus();
                return false;
            }

            //Validaciones para el campo de apellido materno
            if (TxtApellidoMaternoCRRP.Text.Trim().Equals(""))
            {
                TxtApellidoMaternoCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_APELLIDO_MATERNO);
                TxtApellidoMaternoCRRP.Focus();
                return false;
            }
            if (!(TxtApellidoMaternoCRRP.Text.Length >= caracterUno && TxtApellidoMaternoCRRP.Text.Length <= caracterDos))
            {
                TxtApellidoMaternoCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.RangoOpciones(caracterUno, caracterDos));
                TxtApellidoMaternoCRRP.Focus();
                return false;
            }
            if (!Regex.IsMatch(TxtApellidoMaternoCRRP.Text.Trim(), SentenciaSQLAndStrings.PatronDatosRRP))
            {
                TxtApellidoMaternoCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.NO_CARACTERES_ESPECIALES);
                TxtApellidoMaternoCRRP.Focus();
                return false;
            }

            //Validaciones para el campo de edad
            if (!int.TryParse(TxtEdadCRRP.Text.Trim(), out int edad))
            {
                TxtEdadCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_EDAD);
                TxtEdadCRRP.Focus();
                return false;
            }
            if (!(TxtEdadCRRP.Text.Length >= 1 && TxtEdadCRRP.Text.Length <= 2))
            {
                TxtEdadCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.RangoOpciones(1, 2));
                TxtEdadCRRP.Focus();
                return false;
            }

            //Validaciones para el campo de dirección
            if (TxtDireccionCRRP.Text.Trim().Equals(""))
            {
                TxtDireccionCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_DIRECCION);
                TxtDireccionCRRP.Focus();
                return false;
            }
            if (!(TxtDireccionCRRP.Text.Length >= caracterTres && TxtDireccionCRRP.Text.Length <= caracterDos))
            {
                TxtDireccionCRRP.BackColor= Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.RangoOpciones(caracterTres, caracterDos));
                TxtDireccionCRRP.Focus();
                return false;
            }
            if (!Regex.IsMatch(TxtDireccionCRRP.Text.Trim(), SentenciaSQLAndStrings.PatronDireccionRRP))
            {
                TxtDireccionCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.NO_CARACTERES_ESPECIALES);
                TxtDireccionCRRP.Focus();
                return false;
            }

            //Validación para el campo de telefono celular
            if (TxtTelefonoCelularCRRP.Text.Trim().Equals(""))
            {
                TxtTelefonoCelularCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_CELULAR);
                TxtTelefonoCelularCRRP.Focus();
                return false;
            }
            if (!(TxtTelefonoCelularCRRP.Text.Length == 10))
            {
                TxtTelefonoCelularCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.NO_SIZE_PHONE);
                TxtTelefonoCelularCRRP.Focus();
                return false;
            }

            //Validación para el campo de telefono fijo
            if (TxtTelefonoFijoCRRP.Text.Trim().Equals(""))
            {
                TxtTelefonoFijoCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_TELEFONO_FIJO);
                TxtTelefonoFijoCRRP.Focus();
                return false;
            }
            if (!(TxtTelefonoFijoCRRP.Text.Length == 10))
            {
                TxtTelefonoFijoCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.NO_SIZE_PHONE);
                TxtTelefonoFijoCRRP.Focus();
                return false;
            }

            //Validación para el campo de email
            if (TxtEmailCRRP.Text.Trim().Equals(""))
            {
                TxtEmailCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_EMAIL);
                TxtEmailCRRP.Focus();
                return false;
            }
            if (!(TxtEmailCRRP.Text.Length >= 6 && TxtDireccionCRRP.Text.Length <= 50))
            {
                TxtEmailCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.RangoOpciones(6, 50));
                TxtEmailCRRP.Focus();
                return false;
            }
            if (!Regex.IsMatch(TxtEmailCRRP.Text.Trim(), SentenciaSQLAndStrings.PatronEmailRRP))
            {
                TxtEmailCRRP.BackColor = Color.Gold;
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_EMAIL_FORMATO_CORRECTO);
                TxtEmailCRRP.Focus();
                return false;
            }
            //Validación para el estado civil
            if (CbxEdoCivilRRP.SelectedIndex<0)
            {
                MessageBox.Show(SentenciaSQLAndStrings.INGRESO_ESTADO_CIVIL);
                CbxEdoCivilRRP.Focus();
                return false;
            }   
            return true;
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
                BackColorTextInput();
            }
        }
        //Método que permite limpiar lo que contenga en las cajas de texto.
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
         //Método que permite cambiar el color de los cajas de texto.
        private void BackColorTextInput() 
        {
            TxtEmailCRRP.BackColor = Color.White;
            TxtDireccionCRRP.BackColor = Color.White;
            TxtNombreCRRP.BackColor = Color.White;
            TxtApellidoPaternoCRRP.BackColor = Color.White;
            TxtApellidoMaternoCRRP.BackColor = Color.White;
            TxtEdadCRRP.BackColor = Color.White;
            TxtTelefonoCelularCRRP.BackColor = Color.White;
            TxtTelefonoFijoCRRP.BackColor=Color.White;
        }
        //Método que permite crear un objeto de tipo Paciente
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
        //Método que permite obtener el id del paciente de una caja de texto.
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
        //Método que permite seleccionar una opción de la DataGridView y los datos obtenidos agregarlos a los caja de texto.
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
        //Método que permite actualizar un registro de la tabla pacientes.
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtIdRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha seleccionado una opción de la tabla de pacientes");
                return;
            }
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
                BackColorTextInput();
            }
        }
        //Método que permite eliminar un registro de la tabla pacientes.
        private void BtnEliminarRRP_Click(object sender, EventArgs e)
        {
            if (GetIdPaciente() == -1)
            {
                MessageBox.Show("No se ha seleccionado una opción de la tabla de pacientes");
                return;
            }
            if (MessageBox.Show("¿Desea eliminar el paciente?","Eliminar paciente",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CargarPaciente();
                if (PacienteConsultasRRP.EliminarPaciente(PacienteRRP))
                {
                    MessageBox.Show("Se ha eliminado un paciente");
                    CargarDatosPacientes();
                    LimpiarCampos();
                    BackColorTextInput();
                }
            }
        }
        //Método que permite realizar la busqueda, pero con un enter en el textBox
        private void TxtBuscarRRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarDatosPacientes(TxtBuscarRRP.Text.Trim());
                TxtBuscarRRP.Text = "";
                if (DgvPacientesRRP.RowCount == 0)
                {
                    MessageBox.Show("No se han encontrado datos");
                }
            }
        }
        //Método que no permites el ingreso caracteres a cajas de texto donde solo se necesite números
        private void TxtTelefonoCelularCRRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Método que no permites el ingreso caracteres a cajas de texto donde solo se necesite números
        private void TxtTelefonoFijoCRRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Método que no permites el ingreso caracteres a cajas de texto donde solo se necesite números
        private void TxtEdadCRRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
