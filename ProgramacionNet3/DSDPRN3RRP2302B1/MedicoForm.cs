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
    public partial class MedicoForm : Form
    {
        private List<Medico> ListMedicosRRP;
        private List<Especialidad> ListEspecialidadesRRP;
        private MedicoConsultas MedicoConsultasRRP;
        private Medico MedicoRRP;
        private EspecialidadesConsultas EspecialidadesConsultaRRP;
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

        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menú principal?", "Regresar al menú", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

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
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            TxtNombreMedicoRRP.Text = "";
            TxtApellidoPaternoMedicoRRP.Text = "";
            TxtApellidoMaternoMedicoCRRP.Text = "";
            TxtCedulaRRP.Text = "";
            TxtIdDoctorRRP.Text = "";
            TxtIdEspecialidaRRP.Text = "";
        }

        private void CargarMedico()
        {
            MedicoRRP.IdRRP = GetIdMedico();
            MedicoRRP.NombreRRP = TxtNombreMedicoRRP.Text.Trim();
            MedicoRRP.ApellidoPaternoRRP = TxtApellidoPaternoMedicoRRP.Text.Trim();
            MedicoRRP.ApellidoMaternoRRP = TxtApellidoMaternoMedicoCRRP.Text.Trim();
            MedicoRRP.CedulaRRP = TxtCedulaRRP.Text.Trim();
            MedicoRRP.EspcialidadIntRRP =GetIdEspecialidad();
        }

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
            return true;
        }

        private void DgvEspcialidadesRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvEspcialidadesRRP.Rows[e.RowIndex];
            TxtIdEspecialidaRRP.Text = Convert.ToString(filaRRP.Cells["idEspecialidad"].Value);
        }

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
                LimpiarCampos();
            }
        }

        private void DgvMedicosRRP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaRRP = DgvMedicosRRP.Rows[e.RowIndex];
            TxtIdDoctorRRP.Text = Convert.ToString(filaRRP.Cells["Id"].Value);
            TxtNombreMedicoRRP.Text = Convert.ToString(filaRRP.Cells["Nombre"].Value);
            TxtApellidoPaternoMedicoRRP.Text = Convert.ToString(filaRRP.Cells["ApellidoPaterno"].Value);
            TxtApellidoMaternoMedicoCRRP.Text = Convert.ToString(filaRRP.Cells["ApellidoMaterno"].Value);
            TxtCedulaRRP.Text = Convert.ToString(filaRRP.Cells["Cedula"].Value);
        }

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
                    LimpiarCampos();
                }
            }
        }

        private void btnBuscarMedicoRRP_Click(object sender, EventArgs e)
        {
            CargarDatosMedico(TxtBuscarRRP.Text.Trim());
            TxtBuscarRRP.Text = "";
        }
    }
}
