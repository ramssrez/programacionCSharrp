using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDPRN3RRP2302B1
{
    //Clase que permite realizar las diferentes consultas a las tabla de especialidades
    internal class EspecialidadesConsultas
    {
        //Atributos de la clase
        private ConexionMysql ConexionMysqlRRP;
        private List<Especialidad> ListEspecialidaRRP;
        //Instancia de las clases para poder realizar la conexión para la base de datos
        public EspecialidadesConsultas()
        {
            ConexionMysqlRRP = new ConexionMysql();
            ListEspecialidaRRP = new List<Especialidad>();
        }
        //Método que permite obtener la lista de las especialidades 
        public List<Especialidad> GetEspecialidades(string filtro)
        {
            string QueryRRP = SentenciaSQLAndStrings.SQL_OBTENER_ESPECIALIDADES_RRP;
            MySqlDataReader readerRRP = null;
            //try/cathc para poder realizar la consulta de las especialidades
            try
            {
                if (filtro != "")
                {
                    string s = $" WHERE idEspecialidades LIKE '%{filtro}%' OR Nombre LIKE '%{filtro}%' OR Descripcion LIKE '%{filtro}%';";
                    QueryRRP += s;
                }
                MySqlCommand commandRRP = new MySqlCommand(QueryRRP);
                commandRRP.Connection = ConexionMysqlRRP.GetConexionMySQL();
                readerRRP = commandRRP.ExecuteReader();
                Especialidad especialidadRRP = null;
                while (readerRRP.Read())
                {
                    especialidadRRP = new Especialidad();
                    especialidadRRP.IdRRP = readerRRP.GetInt16("idEspecialidades");
                    especialidadRRP.NombreRRP = readerRRP.GetString("Nombre");
                    especialidadRRP.DescripcionRRP = readerRRP.GetString("Descripcion");
                    ListEspecialidaRRP.Add(especialidadRRP);
                }
                readerRRP.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show($"Error al obtener las especialidades: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return ListEspecialidaRRP;
        }
        //Método que permite agregar especialidades a la base de datos
        internal bool AgregarEspecialidad(Especialidad especialidadRRP)
        {
            bool BanderaRRP = false;
            try
            {
                string QueryRRP = "INSERT INTO tbespecialidadesrrp (Nombre, Descripcion) " +
                    "VALUES (@nombre, @descripcion);";
                MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
                CommandRRP.Parameters.Add(new MySqlParameter("@nombre", especialidadRRP.NombreRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@descripcion", especialidadRRP.DescripcionRRP));
                BanderaRRP = CommandRRP.ExecuteNonQuery() > 0;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show($"Error al agregar la especialidad: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return BanderaRRP;
        }
        //Método que permite eliminar un registro de la tabla de especilidades 
        internal bool EliminarEspecialidad(Especialidad especialidadRRP)
        {
            bool BanderaRRP = false;
            try
            {
                string QueryRRP = "DELETE FROM tbespecialidadesrrp WHERE idEspecialidades=@id;";
                MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
                CommandRRP.Parameters.Add(new MySqlParameter("@id", especialidadRRP.IdRRP));
                BanderaRRP = CommandRRP.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar la especialidad: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return BanderaRRP;
            throw new NotImplementedException();
        }
        //Método que permite modificar un registro de la tabla de especilidad, en base de su id
        internal bool ModificarEspecialidad(Especialidad especialidadRRP)
        {
            bool BanderaRRP = false;
            try
            {
                string QueryRRP = "UPDATE tbespecialidadesrrp SET Nombre = @nombre, Descripcion = @descripcion WHERE idEspecialidades=@id;";
                MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
                CommandRRP.Parameters.Add(new MySqlParameter("@nombre", especialidadRRP.NombreRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@descripcion", especialidadRRP.DescripcionRRP));
                CommandRRP.Parameters.Add(new MySqlParameter("@id", especialidadRRP.IdRRP));
                BanderaRRP = CommandRRP.ExecuteNonQuery() > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al modificar la especialidad: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return BanderaRRP;
        }
    }
}