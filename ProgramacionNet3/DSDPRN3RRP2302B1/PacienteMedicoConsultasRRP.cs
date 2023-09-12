using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDPRN3RRP2302B1
{
    //Clase que permite realizar las diferentes consultas a las tabla de pacientesmedicos
    internal class PacienteMedicoConsultasRRP
    {
        //Atributos de la clase
        private ConexionMysql ConexionMysqlRRP;
        private List<PacienteMedico> ListPacienteMedicosRRP;
        //Instancia de las clases para poder realizar la conexión para la base de datos
        public PacienteMedicoConsultasRRP()
        {
            ConexionMysqlRRP = new ConexionMysql();
            ListPacienteMedicosRRP = new List<PacienteMedico>();
        }
        //Método que permite obtener la lista de pacientes-medico
        public List<PacienteMedico> GetMedicoPacientes(string filtro)
        {
            string QueryRRP = SentenciaSQLAndStrings.SQL_OBTENER_PACIENTE_MEDICO_ESPECIALIDAD;
            MySqlDataReader readerRRP = null;
            try
            {
                MySqlCommand commandRRP = new MySqlCommand(QueryRRP);
                commandRRP.Connection = ConexionMysqlRRP.GetConexionMySQL();
                readerRRP = commandRRP.ExecuteReader();
                PacienteMedico pacienteMedicoRRP = null;
                while (readerRRP.Read())
                {
                    pacienteMedicoRRP = new PacienteMedico();
                    pacienteMedicoRRP.IdRRP = readerRRP.GetInt16("Id");
                    pacienteMedicoRRP.PacienteRRP = readerRRP.GetString("Paciente");
                    pacienteMedicoRRP.MedicoRRP = readerRRP.GetString("Médico");
                    pacienteMedicoRRP.EspecialidadRRP = readerRRP.GetString("Especialidad");
                    ListPacienteMedicosRRP.Add(pacienteMedicoRRP);
                }
                readerRRP.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al obtener pacientes y médico: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return ListPacienteMedicosRRP;
        }
        //Método que permite agregar la vinculación entre paciente y medico
        internal bool AsignarPacienteMedico(int v1, int v2)
        {
            bool BanderaRRP = false;
            try
            {
                string QueryRRP = "INSERT INTO tbpacientesmedicosrrp (idPacientes,idMedicos) " +
                    "VALUES (@idPaciente, @idMedico);";
                MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
                CommandRRP.Parameters.Add(new MySqlParameter("@idPaciente", v1));
                CommandRRP.Parameters.Add(new MySqlParameter("@idMedico", v2));
                BanderaRRP = CommandRRP.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al asignar médico: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return BanderaRRP;
        }
        //Método que permite eliminar la vinculación entre paciente y medico
        internal bool EliminarPacienteMedico(int v)
        {
            bool BanderaRRP = false;
            try
            {
                string QueryRRP = "DELETE FROM tbpacientesmedicosrrp WHERE idPacientesMedico=@id;";
                MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
                CommandRRP.Parameters.Add(new MySqlParameter("@id", v));
                BanderaRRP = CommandRRP.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar médico: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return BanderaRRP;
        }
    }
}