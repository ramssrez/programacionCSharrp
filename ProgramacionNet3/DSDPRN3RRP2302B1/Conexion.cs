using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DSDPRN3RRP2302B1
{
    internal class Conexion
    {
        public static MySqlConnection conexion()
        {
            string servidorRRP = "localhost";
            string dbRRP = "prn3s2b123rrp";
            string passwordRRP = "admin";
            string usuarioRRP = "root";
            string cadenaConexionRRP = $"Database={dbRRP}; Data Source={servidorRRP}; User Id={usuarioRRP}; Password={passwordRRP}";
            try
            {
                MySqlConnection conexionDbRRP = new MySqlConnection(cadenaConexionRRP);
                return conexionDbRRP;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectarse a la bd: {ex.Message}");
                return null;
            }
        }
    }
}
