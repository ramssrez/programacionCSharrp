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

namespace DSDPRN3RRP2302B1
{
    //Clase para crear un form de medicos
    public partial class MedicoForm : Form
    {
        //Variables para poder realizar la conexión y la consulta de tabla de médicos
        private List<Medico> ListMedicosRRP;
        private List<Especialidad> ListEspecialidadesRRP;
        private MedicoConsultas MedicoConsultasRRP;
        private Medico MedicoRRP;
        private EspecialidadesConsultas EspecialidadesConsultaRRP;
        //Constructor del form de médicos.
        public MedicoForm()
        {
            InitializeComponent();
            ListMedicosRRP = new List<Medico>();
            ListEspecialidadesRRP = new List<Especialidad>();
            MedicoConsultasRRP = new MedicoConsultas();
            MedicoRRP = new Medico();
            EspecialidadesConsultaRRP = new EspecialidadesConsultas();
            CargarDatosMedico();
            CargarDatosEspecialidades();
        }
        //Método que permite cargar las especialidades en un DataGridView.
        private void CargarDatosEspecialidades(string filtro = "")
        {
            DgvEspcialidadesRRP.Rows.Clear();
            DgvEspcialidadesRRP.Refresh();
            ListEspecialidadesRRP.Clear();
            ListEspecialidadesRRP = EspecialidadesConsultaRRP.GetEspecialidades(filtro);
            for (int i = 0; i < ListEspecialidadesRRP.Count(); i++)
            {
                DgvEspcialidadesRRP.RowTemplate.Height = 25;
                DgvEspcialidadesRRP.Rows.Add(
                    ListEspecialidadesRRP[i].IdRRP,
                    ListEspecialidadesRRP[i].NombreRRP,
                    ListEspecialidadesRRP[i].DescripcionRRP
                    ) ;
            }
        }
        //Método que permite cargar los médico en un DataGridView.
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
            if (!DatosCorrectos())
            {
                return;
            }
            CargarMedico();
            if (MedicoConsultasRRP.AgregarMedico(MedicoRRP))
            {
                MessageBox.Show("Se ha agregado un médico");
                CargarDatosMedico();
                BackColorTextInput();
                LimpiarCampos();
            }
        }
        //Método que permite cambiar el color de los cajas de texto.
        private void BackColorTextInput()
        {
            TxtNombreMedicoRRP.BackColor = Color.White;
            TxtApellidoPaternoMedicoRRP.BackColor = Color.White;
            TxtApellidoMaternoMedicoCRRP.BackColor=Color.White;
        }
        //Método que permite limpiar lo que contenga en las cajas de texto.
        private void LimpiarCampos()
        {
            TxtNombreMedicoRRP.Text = "";
            TxtApellidoPaternoMedicoRRP.Text = "";
            TxtApellidoMaternoMedicoCRRP.Text = "";
            TxtCedulaRRP.Text = "";
            TxtIdDoctorRRP.Text = "";
            TxtIdEspecialidaRRP.Text = "";
        }
        //Método que permite crear un objeto de tipo Medico
        private void CargarMedico()
        {
            MedicoRRP.IdRRP = GetIdMedico();
            MedicoRRP.NombreRRP = TxtNombreMedicoRRP.Text.Trim();
            MedicoRRP.ApellidoPaternoRRP = TxtApellidoPaternoMedicoRRP.Text.Trim();
            MedicoRRP.ApellidoMaternoRRP = TxtApellidoMaternoMedicoCRRP.Text.Trim();
            MedicoRRP.CedulaRRP = TxtCedulaRRP.Text.Trim();
            MedicoRRP.EspcialidadIntRRP =GetIdEspecialidad();
        }
        //Método que permite obtener el id del médico de una caja de texto.
        private int GetIdMedico()
        {
            int numberRRP = -1;
            if (!TxtIdDoctorRRP.Text.Trim().Equals(""))
            {
                if (int.TryParse(TxtIdDoctorRRP.Text.Trim(), out int ids))
                {
                    numberRRP = ids;
                }
            }
            return numberRRP;
        }
        //Método que permite obtener el id de la especialidad de una caja de texto.
        private int GetIdEspecialidad()
        {
            int numberRRP = -1;
            if (!TxtIdEspecialidaRRP.Text.Trim().Equals(""))
            {
                if (int.TryParse(TxtIdEspecialidaRRP.Text.Trim(), out int ids))
                {
                    numberRRP = ids;
                }
            }
            return numberRRP;
        }
        //Método que permite verificar diferentes tipos de datos, si es de un tipo o si esta vacío.
        private bool DatosCorrectos()
        {
            if (TxtNombreMedicoRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }
            if (TxtApellidoPaternoMedicoRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el apellido paterno");
                return false;
            }
            if (TxtApellidoMaternoMedicoCRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el apellido materno");
                return false;
            }
            if (TxtCedulaRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la cedula");
                return false;
            }
            if (TxtIdEspecialidaRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Selecciona una especialidad de la tabla");
                return false;
            }
            if (!Regex.IsMatch(TxtNombreMedicoRRP.Text.Trim(), SentenciaSQLAndStrings.PatronDatosRRP))
            {
                TxtNombreMedicoRRP.BackColor = Color.Red;
                MessageBox.Show("No se permiten caracteres especiales");
                return false;
            }
            if (!Regex.IsMatch(TxtApellidoPaternoMedicoRRP.Text.Trim(), SentenciaSQLAndStrings.PatronDatosRRP))
            {
                TxtApellidoPaternoMedicoRRP.BackColor = Color.Red;
                MessageBox.Show("No se permiten caracteres especiales");
                return false;
            }
            if (!Regex.IsMatch(TxtApellidoMaternoMedicoCRRP.Text.Trim(), SentenciaSQLAndStrings.PatronDatosRRP))
            {
                TxtApellidoMaternoMedicoCRRP.BackColor = Color.Red;
                MessageBox.Show("No se permiten caracteres especiales");
                return false;
            }
            return true;
        }
        //Método que permite seleccionar una opción de la DataGridView y los datos obtenidos agregarlos a los caja de texto.
        private void DgvEspcialidadesRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvEspcialidadesRRP.Rows[e.RowIndex];
            TxtIdEspecialidaRRP.Text = Convert.ToString(filaRRP.Cells["idEspecialidad"].Value);
        }
        //Método que permite actualizar un registro de la tabla médicos
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtIdDoctorRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha seleccionado una opción de la tabla de médicos");
                return;
            }
            if (!DatosCorrectos())
            {
                return;
            }
            CargarMedico();
            if (MedicoConsultasRRP.ModificarMedico(MedicoRRP))
            {
                MessageBox.Show("Se ha modificado un médico");
                CargarDatosMedico();
                BackColorTextInput();
                LimpiarCampos();
            }
        }
        //Método que permite seleccionar una opción de la DataGridView y los datos obtenidos agregarlos a los caja de texto.
        private void DgvMedicosRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvMedicosRRP.Rows[e.RowIndex];
            TxtIdDoctorRRP.Text = Convert.ToString(filaRRP.Cells["Id"].Value);
            TxtNombreMedicoRRP.Text = Convert.ToString(filaRRP.Cells["Nombre"].Value);
            TxtApellidoPaternoMedicoRRP.Text = Convert.ToString(filaRRP.Cells["ApellidoPaterno"].Value);
            TxtApellidoMaternoMedicoCRRP.Text = Convert.ToString(filaRRP.Cells["ApellidoMaterno"].Value);
            TxtCedulaRRP.Text = Convert.ToString(filaRRP.Cells["Cedula"].Value);
        }
        //Método que permite eliminar un registro de la tabla de médicos.
        private void BtnEliminarRRP_Click(object sender, EventArgs e)
        {
            if (GetIdMedico() == -1)
            {
                MessageBox.Show("No se ha seleccionado una opción de la tabla de médicos");
                return;
            }
            if (MessageBox.Show("¿Desea eliminar al médico?", "Eliminar Médico", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CargarMedico();
                if (MedicoConsultasRRP.EliminarMedico(MedicoRRP))
                {
                    MessageBox.Show("Se ha eliminado un médico");
                    CargarDatosMedico();
                    BackColorTextInput();
                    LimpiarCampos();
                }
            }
        }
        //Método que permite buscar un médico por medio de un texto y que sea por medio de un click en el boton
        private void btnBuscarMedicoRRP_Click(object sender, EventArgs e)
        {
            CargarDatosMedico(TxtBuscarRRP.Text.Trim());
            TxtBuscarRRP.Text = "";
            if (DgvMedicosRRP.RowCount == 0)
            {
                MessageBox.Show("No se han encontrado datos");
            }
        }
        //Método que permite realizar la busqueda, pero con un enter en el textBox
        private void TxtBuscarRRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarDatosMedico(TxtBuscarRRP.Text.Trim());
                TxtBuscarRRP.Text = "";
                if (DgvMedicosRRP.RowCount == 0)
                {
                    MessageBox.Show("No se han encontrado datos");
                }
            }
        }
        //Método que no permites el ingreso caracteres a cajas de texto donde solo se necesite números
        private void TxtCedulaRRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
