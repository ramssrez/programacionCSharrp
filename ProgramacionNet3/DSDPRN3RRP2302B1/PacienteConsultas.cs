using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDPRN3RRP2302B1
{
    internal class PacienteConsultas
    {
        private ConexionMysql ConexionMysqlRRP;
        private List<Paciente> ListPacientesRRP;
        public PacienteConsultas()
        {
            ConexionMysqlRRP = new ConexionMysql();
            ListPacientesRRP = new List<Paciente>();
        }

       public List<Paciente> GetPacientes(string filtro)
        {
            string QueryRRP = SentenciaSQL.SQL_OBTENER_PACIENTES_RRP;
            MySqlDataReader readerRRP = null;
            try
            {
                if (filtro != "")
                {
                    string s = $" WHERE idPacientes LIKE '%{filtro}%' OR Nombre LIKE '%{filtro}%' OR ApellidoPaterno LIKE '%{filtro}%' OR ApellidoMaterno LIKE '%{filtro}%';";
                    QueryRRP += s;
                }
                MySqlCommand commandRRP = new MySqlCommand(QueryRRP);
                commandRRP.Connection = ConexionMysqlRRP.GetConexionMySQL();
                readerRRP = commandRRP.ExecuteReader();
                Paciente pacienteRRP = null;
                while (readerRRP.Read())
                {
                    pacienteRRP = new Paciente();
                    pacienteRRP.IdRRP = readerRRP.GetInt16("Id");
                    pacienteRRP.NombreRRP = readerRRP.GetString("Nombre");
                    pacienteRRP.ApellidoPaternoRRP = readerRRP.GetString("Apellido Paterno");
                    pacienteRRP.ApellidoMaternoRRP = readerRRP.GetString("Apellido Materno");
                    pacienteRRP.DireccionRRP = readerRRP.GetString("Direccion");
                    pacienteRRP.CelularRRP = readerRRP.GetString("Celular");
                    pacienteRRP.TelefonoFijoRRP = readerRRP.GetString("Telefono Fijo");
                    pacienteRRP.EmailRRP = readerRRP.GetString("Email");
                    pacienteRRP.EdadRRP = readerRRP.GetInt16("Edad");
                    pacienteRRP.SexoRRP = readerRRP.GetChar("Sexo");
                    pacienteRRP.EstadoCivilStringRRP = readerRRP.GetString("Estado Civil");
                    ListPacientesRRP.Add( pacienteRRP );
                }
                readerRRP.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al obtener pacientes: {ex.Message}");
            }
            return ListPacientesRRP;
        }
    }
}
