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
                    string s = $" WHERE idMedicos LIKE '%{filtro}%' OR Nombre LIKE '%{filtro}%' OR ApellidoPaterno LIKE '%{filtro}%' OR ApellidoMaterno LIKE '%{filtro}%';";
                    QueryRRP += s;
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
                    medicoRRP.Cedula = readerRRP.GetString("Cedula");
                    medicoRRP.EspcialidadRRP = readerRRP.GetString("Especialidad");
                    ListMedicoRRP.Add(medicoRRP);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al obtener medicos: {ex.Message}");
            }
            return ListMedicoRRP;      
        }
    }
}