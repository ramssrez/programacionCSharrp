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
    public partial class EspecialidadesForm : Form
    {
        private EspecialidadesConsultas EspecialidadesConsultaRRP;
        private List<Especialidad> ListEspecialidadesRRP;
        private Especialidad EspecialidadRRP;

        public EspecialidadesForm()
        {
            InitializeComponent();
            ListEspecialidadesRRP = new List<Especialidad>();
            EspecialidadesConsultaRRP = new EspecialidadesConsultas();
            EspecialidadRRP = new Especialidad();
            CargarDatosEspecialidades();
        }

        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menú principal?", "Regresar al menú", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
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

        private void DgvEspcialidadesRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvEspcialidadesRRP.Rows[e.RowIndex];
            TxtIdEspecialidaRRP.Text = Convert.ToString(filaRRP.Cells["idEspecialidad"].Value);
            TxtDescripcionRRP.Text = Convert.ToString(filaRRP.Cells["DescipcionEs"].Value);
            TxtNombreEspecialidadRRP.Text = Convert.ToString(filaRRP.Cells["NombreEs"].Value);
        }

        private void LimpiarCampos()
        {
            TxtNombreEspecialidadRRP.Text = "";
            TxtDescripcionRRP.Text = "";
            TxtIdEspecialidaRRP.Text = "";
        }
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
            return true;
        }

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
            }
        }

        private void CargarEspecialidad()
        {
            EspecialidadRRP.IdRRP = GetIdEspecialidad();
            EspecialidadRRP.NombreRRP = TxtNombreEspecialidadRRP.Text.Trim();
            EspecialidadRRP.DescripcionRRP = TxtDescripcionRRP.Text.Trim();
        }
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
            }
        }

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
                }
            }
        }
    }
}
