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
        public PacientesForm()
        {
            InitializeComponent();
            ListPacientesRRP = new List<Paciente>();
            PacienteConsultasRRP = new PacienteConsultas();
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
        /*
        private void PacientesConsulta()
        {
            conexion = new Conexion();
            MySqlConnection conexionDBRRP = conexion.GetConexionMySQL();
            try
            {
                conexionDBRRP.Open();
                adapterRRP = new MySqlDataAdapter(SentenciaSQL.SQL_OBTENER_PACIENTES_RRP, conexionDBRRP);
                dataTableRRP = new DataTable();
                adapterRRP.Fill(dataTableRRP);
                DtWConexionRRP.DataSource = dataTableRRP;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al buscar doctores: {ex.Message}");
            }
            finally
            {
                conexionDBRRP.Close();
            }
        }
        */
    }
}
