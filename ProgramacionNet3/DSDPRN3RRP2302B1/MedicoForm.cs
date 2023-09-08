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
        private MedicoConsultas MedicoConsultasRRP;
        private Medico MedicoRRP;
        public MedicoForm()
        {
            InitializeComponent();
            ListMedicosRRP = new List<Medico>();
            MedicoConsultasRRP = new MedicoConsultas();
            MedicoRRP = new Medico();
            CargarDatosMedico();
        }

        private void CargarDatosMedico(string filtro = "")
        {
            DgvMedicosRRP.Rows.Clear();
            DgvMedicosRRP.Refresh();
            ListMedicosRRP.Clear();
            ListMedicosRRP = MedicoConsultasRRP.GetMedicos(filtro);
            for (int i = 0; i < ListMedicosRRP.Count(); i++)
            {
                DgvMedicosRRP.RowTemplate.Height = 50;
                DgvMedicosRRP.Rows.Add(
                    ListMedicosRRP[i].IdRRP,
                    ListMedicosRRP[i].NombreRRP,
                    ListMedicosRRP[i].ApellidoPaternoRRP,
                    ListMedicosRRP[i].ApellidoMaternoRRP,
                    ListMedicosRRP[i].Cedula,
                    ListMedicosRRP[i].EspcialidadRRP
                    );
            }
        }

        private void BtnRegresarRRP_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
