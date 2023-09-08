using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSDPRN3RRP2302B1
{
    internal class MedicoConsultas
    {

        private ConexionMysql ConexionMysqlRRP;
        private List<Medico> ListMedicoRRP;
        public MedicoConsultas() 
        {
            ConexionMysqlRRP = new ConexionMysql();
            ListMedicoRRP = new List<Medico>();
        }

        public List<Medico> GetMedicos(string filtro)
        {
            string QueryRRP = SentenciaSQL.SQL_OBTENER_MEDICO_RRP;
            MySqlDataReader readerRRP = null;
            try
            {
                
                if (filtro != "")
                {
                    QueryRRP = "";
                    string s = $" WHERE idMedicos LIKE '%{filtro}%' OR tbmedicosrrp.Nombre LIKE '%{filtro}%' OR tbmedicosrrp.ApellidoPaterno LIKE '%{filtro}%' OR tbmedicosrrp.ApellidoMaterno LIKE '%{filtro}%' ORDER By tbmedicosrrp.idMedicos ASC;";
                    QueryRRP=SentenciaSQL.SQL_OBTENER_MEDICO_FILTTRO_RRP+s;
                }
                
                MySqlCommand commandRRP = new MySqlCommand(QueryRRP);
                commandRRP.Connection = ConexionMysqlRRP.GetConexionMySQL();
                readerRRP = commandRRP.ExecuteReader();
                Medico medicoRRP = null;
                while (readerRRP.Read())
                {
                    medicoRRP= new Medico();
                    medicoRRP.IdRRP = readerRRP.GetInt16("Id");
                    medicoRRP.NombreRRP = readerRRP.GetString("Nombre");
                    medicoRRP.ApellidoPaternoRRP = readerRRP.GetString("Apellido Paterno");
                    medicoRRP.ApellidoMaternoRRP = readerRRP.GetString("Apellido Materno");
                    medicoRRP.CedulaRRP = readerRRP.GetString("Cedula");
                    medicoRRP.EspcialidadRRP = readerRRP.GetString("Especialidad");
                    ListMedicoRRP.Add(medicoRRP);
                }
                readerRRP.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al obtener medicos: {ex.Message}");
            }
            return ListMedicoRRP;      
        }

        internal bool AgregarMedico(Medico medicoRRP)
        {
            string QueryRRP = "INSERT INTO tbmedicosrrp (Nombre, ApellidoPaterno, ApellidoMaterno, Cedula, idEspecialidades) " +
                "VALUES (@nombre, @apellidoP, @apellidoM, @cedula, @idEspecialida);";
            MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
            CommandRRP.Parameters.Add(new MySqlParameter("@nombre", medicoRRP.NombreRRP));
            CommandRRP.Parameters.Add(new MySqlParameter("@apellidoP", medicoRRP.ApellidoPaternoRRP));
            CommandRRP.Parameters.Add(new MySqlParameter("@apellidoM", medicoRRP.ApellidoMaternoRRP));
            CommandRRP.Parameters.Add(new MySqlParameter("@cedula", medicoRRP.CedulaRRP));
            CommandRRP.Parameters.Add(new MySqlParameter("@idEspecialida", medicoRRP.EspcialidadIntRRP));
            return CommandRRP.ExecuteNonQuery() > 0;
        }

        internal bool EliminarPaciente(Medico medicoRRP)
        {
            string QueryRRP = "DELETE FROM tbmedicosrrp WHERE idMedicos=@id;";
            MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
            CommandRRP.Parameters.Add(new MySqlParameter("@id", medicoRRP.IdRRP));
            return CommandRRP.ExecuteNonQuery() > 0;
        }

        internal bool ModificarPaciente(Medico medicoRRP)
        {
            string QueryRRP = "UPDATE tbmedicosrrp SET Nombre = @nombre, ApellidoPaterno=@apellidoP, ApellidoMaterno=@apellidoM, Cedula=@cedula, idEspecialidades=@idEspecialida WHERE idMedicos=@id;";
            MySqlCommand CommandRRP = new MySqlCommand(QueryRRP, ConexionMysqlRRP.GetConexionMySQL());
            CommandRRP.Parameters.Add(new MySqlParameter("@nombre", medicoRRP.NombreRRP));
            CommandRRP.Parameters.Add(new MySqlParameter("@apellidoP", medicoRRP.ApellidoPaternoRRP));
            CommandRRP.Parameters.Add(new MySqlParameter("@apellidoM", medicoRRP.ApellidoMaternoRRP));
            CommandRRP.Parameters.Add(new MySqlParameter("@cedula", medicoRRP.CedulaRRP));
            CommandRRP.Parameters.Add(new MySqlParameter("@idEspecialida", medicoRRP.EspcialidadIntRRP));
            CommandRRP.Parameters.Add(new MySqlParameter("@id", medicoRRP.IdRRP));
            return CommandRRP.ExecuteNonQuery() > 0;
        }
    }
}