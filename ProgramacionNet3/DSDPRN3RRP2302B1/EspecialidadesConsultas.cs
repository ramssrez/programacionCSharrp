using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDPRN3RRP2302B1
{
    internal class EspecialidadesConsultas
    {
        private ConexionMysql ConexionMysqlRRP;
        private List<Especialidad> ListEspecialidaRRP;
        public EspecialidadesConsultas()
        {
            ConexionMysqlRRP = new ConexionMysql();
            ListEspecialidaRRP = new List<Especialidad>();
        }
        public List<Especialidad> GetEspecialidades(string filtro)
        {
            string QueryRRP = SentenciaSQL.SQL_OBTENER_ESPECIALIDADES_RRP;
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
                MessageBox.Show($"Error al obtener pacientes: {ex.Message}");
            }
            finally
            {
                ConexionMysqlRRP.GetConexionMySQL().Close();
            }
            return ListEspecialidaRRP;
        }
    }
}