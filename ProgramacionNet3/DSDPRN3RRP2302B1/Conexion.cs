using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DSDPRN3RRP2302B1
{
    internal class Conexion
    {
        private MySqlConnection ConnectionRRP;
        private static string servidorRRP = "localhost";
        private static string dbRRP = "prn3s2b123rrp";
        private static string passwordRRP = "admin";
        private static string usuarioRRP = "root";

        public Conexion()
        {
            string cadenaConexionRRP = $"Database={dbRRP}; Data Source={servidorRRP}; User Id={usuarioRRP}; Password={passwordRRP}";
            ConnectionRRP = new MySqlConnection(cadenaConexionRRP);
        }
        public MySqlConnection GetConexionMySQL()
        {
            try
            {                
                return ConnectionRRP;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectarse a la bd: {ex.Message}");
                return null;
            }
        }
    }
}
