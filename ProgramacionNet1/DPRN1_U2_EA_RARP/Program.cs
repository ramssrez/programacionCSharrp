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
            Presentacion();
        }
        public static void Presentacion()
        {
            Cliente cliente = new Cliente();
            IngresoDatosUsuario(cliente);
            
        }
        public static void IngresoDatosUsuario(Cliente cliente)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.Write("Ingrese la clave del cliente: ");
            cliente.Clave = Console.ReadLine();
            Console.Write("Ingrese el tipo de cliente (Standart, Priority o Premium): ");
            cliente.TipoCliente = Console.ReadLine();
            Console.Write("Ingrese el monto del cliente: ");
            cliente.Monto = double.Parse(Console.ReadLine());
            DeterminarTipoCliente(cliente);
            cliente.ToString();
        }
        public static Cliente DeterminarTipoCliente(Cliente cliente)
        {
            if (cliente.TipoCliente == "Standart")
            {
                cliente.CantidadDepositos = 3;
                cliente.CantidadRetiros = 2;
            }else if (cliente.TipoCliente == "Priority")
            {
                cliente.CantidadDepositos = 5;
                cliente.CantidadRetiros = 4;
            }
            else if (cliente.TipoCliente == "Premium")
            {
                cliente.CantidadDepositos = 8;
                cliente.CantidadRetiros = 8;
            }
            return cliente;
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
        public string  TipoCliente { get; set; }
        public string TipoOperacion { get; set; }
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