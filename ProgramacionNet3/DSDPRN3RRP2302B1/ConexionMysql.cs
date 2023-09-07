using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DSDPRN3RRP2302B1
{
    internal class ConexionMysql
    {
        private MySqlConnection ConnectionRRP;
        private static string servidorRRP = "localhost";
        private static string dbRRP = "prn3s2b123rrp";
        private static string passwordRRP = "admin";
        private static string usuarioRRP = "root";

        public ConexionMysql()
        {
            string cadenaConexionRRP = $"Database={dbRRP}; Data Source={servidorRRP}; User Id={usuarioRRP}; Password={passwordRRP}";
            ConnectionRRP = new MySqlConnection(cadenaConexionRRP);
        }
        public MySqlConnection GetConexionMySQL()
        {
            try
            {      
                if (ConnectionRRP.State != System.Data.ConnectionState.Open)
                {
                    ConnectionRRP.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectarse a la bd: {ex.Message}");
            }
            return ConnectionRRP;
        }
    }
}
