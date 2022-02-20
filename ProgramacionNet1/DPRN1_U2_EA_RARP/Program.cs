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
            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese el nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la clave del cliente: ");
            cliente.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de cliente (Standart, Priority, Premium): ");
            cliente.Nombre = Console.ReadLine();
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
        public double Monto { get; set;}
        public int CantidadDepositos { get; set; }
        public int CantidadRetiros { get; set; }
        public Cliente()
        {

        }
        public Cliente(string nombre, string clave, string tipoCliente, int depositos, int retiros, double monto)
        {
            Nombre = nombre;
            Clave = clave;
            TipoCliente = tipoCliente;
            CantidadDepositos = depositos;
            CantidadRetiros = retiros;
            Monto = monto;
        }
        public void ToString()
        {
            Console.WriteLine("Los datos del cliente son los siguientes");
            Console.WriteLine($"Nombre del cliente: {Nombre} \n" +
                $"Clase: {Clave} \n" +
                $"Tipo de cliente {TipoCliente} \n" +
                $"Cantidad depositos permitidos: {CantidadDepositos} \n" +
                $"Cantidad retiros permitidos: {CantidadRetiros} \n" +
                $"Monto: {Monto}\n");
        }

    }
}