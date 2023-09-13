using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDPRN3RRP2302B1
{
    //Clase que permite realizar las diferentes consultas a las tabla de pacientes
    internal class PacienteConsultas
    {
        //Atributos de la clase
        private ConexionMysql ConexionMysqlRRP;
        private List<Paciente> ListPacientesRRP;
        //Instancia de las clases para poder realizar la conexión para la base de datos
        public PacienteConsultas()
        {
            ConexionMysqlRRP = new ConexionMysql();
            ListPacientesRRP = new List<Paciente>();
        }
        //Método que permite obtener la lista de pacientes sin doctor
        public List<Paciente> GetPacientesWioutMedicos()
        {
            string QueryRRP = SentenciaSQLAndStrings.SQL_OBTENER_PACIENTES_WITHOUT_DOCTOR_RRP;
            MySqlDataReader readerRRP = null;
            ListPacientesRRP.Clear();
            try
            {
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
                    ListPacientesRRP.Add(pacienteRRP);
                }
                readerRRP.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al obtener pacientes: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return ListPacientesRRP;
        }
        //Método que obtiene los pacientes en función de los doctores, se obtiene cada uno de los pacientes
        public List<Paciente> GetPacientesPorNombreDoctor(string filtro)
        {
            string QueryRRP = $"SELECT CONCAT(tbpacientesrrp.Nombre, ' ', tbpacientesrrp.ApellidoPaterno, ' ', tbpacientesrrp.ApellidoMaterno) AS Paciente FROM tbpacientesrrp INNER JOIN tbpacientesmedicosrrp ON tbpacientesrrp.idPacientes = tbpacientesmedicosrrp.idPacientes INNER JOIN tbmedicosrrp ON tbpacientesmedicosrrp.idMedicos = tbmedicosrrp.idMedicos WHERE tbmedicosrrp.nombre LIKE '%{filtro}%';";
            MySqlDataReader readerRRP = null;
            try
            {
                MySqlCommand commandRRP = new MySqlCommand(QueryRRP);
                commandRRP.Connection = ConexionMysqlRRP.GetConexionMySQL();
                readerRRP = commandRRP.ExecuteReader();
                Paciente pacienteRRP = null;
                while (readerRRP.Read())
                {
                    pacienteRRP = new Paciente();
                    pacienteRRP.NombreRRP = readerRRP.GetString("Paciente");
                    ListPacientesRRP.Add(pacienteRRP);
                }
                readerRRP.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al obtener pacientes: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return ListPacientesRRP;
        }
        //Método que permite obtener la lista de pacientes
        public List<Paciente> GetPacientes(string filtro)
        {
            string QueryRRP = SentenciaSQLAndStrings.SQL_OBTENER_PACIENTES_RRP;
            MySqlDataReader readerRRP = null;
            try
            {
                if (filtro != "")
                {
                    QueryRRP = "";
                    string s = $" WHERE idPacientes LIKE '%{filtro}%' OR Nombre LIKE '%{filtro}%' OR ApellidoPaterno LIKE '%{filtro}%' OR ApellidoMaterno LIKE '%{filtro}%' ORDER By idPacientes ASC;";
                    QueryRRP = SentenciaSQLAndStrings.SQL_OBTENER_PACIENTES_FILTRO_RRP+s;
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
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return ListPacientesRRP;
        }
        //Método que permite agregar pacientes a la base de datos
        internal bool AgregarPaciente(Paciente pacienteRRP)
        {
            bool BanderaRRP = false;
            try
            {
                string QueryRRP = "INSERT INTO tbpacientesrrp (Nombre, ApellidoPaterno, ApellidoMaterno, Direccion, Celular, TelefonoFijo, Edad, Sexo, Email, idEstadoCivil) " +
                    "VALUES (@nombre, @apellidoP, @apellidoM, @direccion, @celular, @telefono, @edad, @sexo, @email, @civil);";
                MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
                CommandRRP.Parameters.Add(new MySqlParameter("@nombre", pacienteRRP.NombreRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@apellidoP", pacienteRRP.ApellidoPaternoRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@apellidoM", pacienteRRP.ApellidoMaternoRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@direccion", pacienteRRP.DireccionRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@celular", pacienteRRP.CelularRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@telefono", pacienteRRP.TelefonoFijoRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@edad", pacienteRRP.EdadRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@sexo", pacienteRRP.SexoRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@email", pacienteRRP.EmailRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@civil", pacienteRRP.EstadoCivilRRP));
                BanderaRRP = CommandRRP.ExecuteNonQuery() > 0;
            }            
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al agregar paciente: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return BanderaRRP;
        }
        //Método que permite eliminar un registro de la tabla de pacientes
        internal bool EliminarPaciente(Paciente pacienteRRP)
        {
            bool BanderaRRP = false;
            try
            {
                string QueryRRP = "DELETE FROM tbpacientesrrp WHERE idPacientes=@id;";
                MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
                CommandRRP.Parameters.Add(new MySqlParameter("@id", pacienteRRP.IdRRP));
                BanderaRRP = CommandRRP.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar paciente: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return BanderaRRP;
        }
        //Método que permite modificar un registro de la tabla de pacientes, en base de su id
        internal bool ModificarPaciente(Paciente pacienteRRP)
        {
            bool BanderaRRP = false;
            try
            {
                string QueryRRP = "UPDATE tbpacientesrrp SET Nombre = @nombre, ApellidoPaterno=@apellidoP, ApellidoMaterno=@apellidoM, Direccion=@direccion, Celular=@celular, TelefonoFijo=@telefono, Edad=@edad, Sexo=@sexo, Email=@email, idEstadoCivil=@civil WHERE idPacientes=@id;";
                MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
                CommandRRP.Parameters.Add(new MySqlParameter("@nombre", pacienteRRP.NombreRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@apellidoP", pacienteRRP.ApellidoPaternoRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@apellidoM", pacienteRRP.ApellidoMaternoRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@direccion", pacienteRRP.DireccionRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@celular", pacienteRRP.CelularRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@telefono", pacienteRRP.TelefonoFijoRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@edad", pacienteRRP.EdadRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@sexo", pacienteRRP.SexoRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@email", pacienteRRP.EmailRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@civil", pacienteRRP.EstadoCivilRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@id", pacienteRRP.IdRRP));
                BanderaRRP = CommandRRP.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al modificar paciente: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return BanderaRRP;
        }
    }
}
