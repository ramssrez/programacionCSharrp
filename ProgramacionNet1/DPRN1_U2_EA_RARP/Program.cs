using System;
namespace UnidadDosEA
{
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Llamado el método que realiza la presentación del programa
            //Presentacion();
        }
        public static void Presentacion()
        {

        }
        public static void IngresoDatosUsuario()
        {

        }
        public static void MostrarInformacionUsuario()
        {

        }
        public static void RealizarDepositos()
        {

        }
        public static void RealizarRetiros()
        {

        }
        public static void MostrarBalance()
        {

        }
    }
    class Cliente
    {
        public string Nombre { get; set; }
        public string Clave { get; set;}
        public string  TipoCliente { get;}
        public string TipoOperacion { get;}
        public string Monto { get; set;}
        public int CantidadDepositos { get; set; }
        public int CantidadRetiros { get; set; }
        public Cliente()
        {

        }
        public Cliente(string nombre, string clave, string tipoCliente, int depositos, int retiros)
        {
            Nombre = nombre;
            Clave = clave;
            TipoCliente = tipoCliente;
            CantidadDepositos = depositos;
            CantidadRetiros = retiros;
        }

    }
}