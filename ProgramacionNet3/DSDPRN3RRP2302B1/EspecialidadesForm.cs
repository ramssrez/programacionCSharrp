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
    //Clase para crear un form de especialidades
    public partial class EspecialidadesForm : Form
    {
        //Variables para poder realizar la conexión y la consulta de tablas de especilidades.
        private EspecialidadesConsultas EspecialidadesConsultaRRP;
        private List<Especialidad> ListEspecialidadesRRP;
        private Especialidad EspecialidadRRP;
        //Constructor del form de especialidades.
        public EspecialidadesForm()
        {
            InitializeComponent();
            ListEspecialidadesRRP = new List<Especialidad>();
            EspecialidadesConsultaRRP = new EspecialidadesConsultas();
            EspecialidadRRP = new Especialidad();
            CargarDatosEspecialidades();
        }
        //Método que permite regresar al menú principal del proyecto.
        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menú principal?", "Regresar al menú", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
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
                    );
            }
        }
        //Método que permite seleccionar una opción de la DataGridView y los datos obtenidos agregarlos a los caja de texto.
        private void DgvEspcialidadesRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvEspcialidadesRRP.Rows[e.RowIndex];
            TxtIdEspecialidaRRP.Text = Convert.ToString(filaRRP.Cells["idEspecialidad"].Value);
            TxtDescripcionRRP.Text = Convert.ToString(filaRRP.Cells["DescipcionEs"].Value);
            TxtNombreEspecialidadRRP.Text = Convert.ToString(filaRRP.Cells["NombreEs"].Value);
        }
        //Método que permite limpiar lo que contenga en las cajas de texto.
        private void LimpiarCampos()
        {
            TxtNombreEspecialidadRRP.Text = "";
            TxtDescripcionRRP.Text = "";
            TxtIdEspecialidaRRP.Text = "";
        }
        //Método que permite verificar diferentes tipos de datos, si es de un tipo o si esta vacío.
        private bool DatosCorrectos()
        {
            if (TxtNombreEspecialidadRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre de la especialidad");
                return false;
            }
            if (TxtDescripcionRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la descripción de la especialidad");
                return false;
            }
            if (!Regex.IsMatch(TxtNombreEspecialidadRRP.Text.Trim(), SentenciaSQLAndStrings.PatronDatosRRP))
            {
                TxtNombreEspecialidadRRP.BackColor = Color.Red;
                MessageBox.Show("No se permiten caracteres especiales");
                return false;
            }
            if (!Regex.IsMatch(TxtDescripcionRRP.Text.Trim(), SentenciaSQLAndStrings.PatronEspecialidaRRP))
            {
                TxtDescripcionRRP.BackColor = Color.Red;
                MessageBox.Show("No se permiten caracteres especiales");
                return false;
            }
            return true;
        }
        //Método que permite realizar el guardado de los datos al momento de realizar click.
        private void BtnGuardarRRP_Click(object sender, EventArgs e)
        {
            if (!DatosCorrectos())
            {
                return;
            }
            CargarEspecialidad();
            if (EspecialidadesConsultaRRP.AgregarEspecialidad(EspecialidadRRP))
            {
                MessageBox.Show("Se ha agregado una especialidad");
                CargarDatosEspecialidades();
                LimpiarCampos();
                BackColorTextInput();
            }
        }
        //Método que permite cambiar el color de los cajas de texto.
        private void BackColorTextInput()
        {
            TxtNombreEspecialidadRRP.BackColor = Color.White;
            TxtDescripcionRRP.BackColor=Color.White;
        }
        //Método que permite crear un objeto de tipo Especialidad.
        private void CargarEspecialidad()
        {
            EspecialidadRRP.IdRRP = GetIdEspecialidad();
            EspecialidadRRP.NombreRRP = TxtNombreEspecialidadRRP.Text.Trim();
            EspecialidadRRP.DescripcionRRP = TxtDescripcionRRP.Text.Trim();
        }
        //Método que permites obtener el id de la especialidad de una caja de texto.
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
        //Método que permite actualizar un registro de la tabla especialidad.
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtIdEspecialidaRRP.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha seleccionado una opción de la tabla");
                return;
            }
            if (!DatosCorrectos())
            {
                return;
            }
            CargarEspecialidad();
            if (EspecialidadesConsultaRRP.ModificarEspecialidad(EspecialidadRRP))
            {
                MessageBox.Show("Se ha modificado la especialidad");
                CargarDatosEspecialidades();
                LimpiarCampos();
                BackColorTextInput();
            }
        }
        //Método que permite eliminar un registro de la tabla de especialidades.
        private void BtnEliminarRRP_Click(object sender, EventArgs e)
        {
            if (GetIdEspecialidad() == -1)
            {
                MessageBox.Show("No se ha seleccionado una opción de la tabla");
                return;
            }
            if (MessageBox.Show("¿Desea eliminar la especialidad?", "Eliminar Especialidad", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CargarEspecialidad();
                if (EspecialidadesConsultaRRP.EliminarEspecialidad(EspecialidadRRP))
                {
                    MessageBox.Show("Se ha eliminado una especialidad");
                    CargarDatosEspecialidades();
                    LimpiarCampos();
                    BackColorTextInput();
                }
            }
        }
        //Método que permite buscar una especialidad por medio de un texto y que sea por medio de un click en el boton
        private void BtnBuscarEspecialidaRRP_Click(object sender, EventArgs e)
        {
            CargarDatosEspecialidades(TxtBuscarRRP.Text.Trim());
            TxtIdEspecialidaRRP.Text = "";
            if (DgvEspcialidadesRRP.RowCount == 0)
            {
                MessageBox.Show("No se han encontrado datos");
            }
        }
        //Método que permite realizar la busqueda, pero con un enter en el textBox
        private void TxtBuscarRRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarDatosEspecialidades(TxtBuscarRRP.Text.Trim());
                TxtBuscarRRP.Text = "";
                if (DgvEspcialidadesRRP.RowCount == 0)
                {
                    MessageBox.Show("No se han encontrado datos");
                }
            }
        }
    }
}
