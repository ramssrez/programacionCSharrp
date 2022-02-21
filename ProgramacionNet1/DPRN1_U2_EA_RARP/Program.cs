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
            

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Ingresar los datos del usuario");
                Console.WriteLine("2. Mostrar información de usuario");
                Console.WriteLine("3. Realizar depositos a la cuenta");
                Console.WriteLine("4. Realizar retiros a la cuenta");
                Console.WriteLine("5. Mostrar monto de la cuenta");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Elige una de las opciones");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Has elegido la opción 1");
                        IngresoDatosUsuario(cliente);
                        break;

                     case 2:
                         Console.WriteLine("Has elegido la opción 2");
                         MostrarInformacionUsuario(cliente);
                         break;

                     case 3:
                         Console.WriteLine("Has elegido la opción 3");
                         RealizarDepositos(cliente);
                         break;
                     case 4:
                         Console.WriteLine("Has elegido la opción 4");
                         RealizarRetiros(cliente);
                         break;
                     case 5:
                         Console.WriteLine("Has elegido la opción 5");
                         MostrarBalance(cliente);
                         break;
                     case 6:
                         Console.WriteLine("Has elegido salir de la aplicación");
                         salir = true;
                         break;
                     default:
                         Console.WriteLine("Elige una opcion entre 1 y 6");
                        break;
                }
            }    
        }
        public static void IngresoDatosUsuario(Cliente cliente)
        {
            Console.WriteLine("**************************************************************************************");
            Console.Write("Ingrese el nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.Write("Ingrese la clave del cliente: ");
            cliente.Clave = Console.ReadLine();
            Console.Write("Ingrese el tipo de cliente (Standart, Priority o Premium): ");
            cliente.TipoCliente = Console.ReadLine();
            DeterminarTipoCliente(cliente);
            Console.WriteLine("**************************************************************************************");
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
        public static void MostrarInformacionUsuario(Cliente cliente)
        {
            Console.WriteLine("**************************************************************************************");
            cliente.ToString();
            Console.WriteLine("**************************************************************************************");
        }
        public static void RealizarDepositos(Cliente cliente)
        {
            Console.WriteLine("**************************************************************************************");
            Console.Write("Ingresa el deposito a realizar: ");
            double depositar = Convert.ToDouble(Console.ReadLine()); 
            cliente.Depositar(depositar);
            Console.WriteLine("**************************************************************************************");
        }
        public static void RealizarRetiros(Cliente cliente)
        {
            Console.WriteLine("**************************************************************************************");
            Console.Write("Ingresa el deposito a realizar: ");
            double retirar = Convert.ToDouble(Console.ReadLine());
            cliente.Retirar(retirar);
            Console.WriteLine("**************************************************************************************");
        }
        public static void MostrarBalance(Cliente cliente)
        {
            Console.WriteLine("**************************************************************************************");
            Console.Write($"El cliente tiene un monto de : {cliente.Monto}");
            Console.WriteLine("**************************************************************************************");
        }
    }
    class Cliente
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string TipoCliente { get; set; }
        public string TipoOperacion { get; set; }
        public double Monto { get; set; }
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
        public void Depositar(double ingreso)
        {
            this.Monto = this.Monto + ingreso; 
        }
        public void Retirar(double retiro)
        {
            this.Monto = this.Monto - retiro;
        }
        public void ToString()
        {
            Console.WriteLine("Los datos del cliente son los siguientes");
            Console.WriteLine($"Nombre del cliente: {Nombre} \n" +
                $"Clave: {Clave} \n" +
                $"Tipo de cliente {TipoCliente} \n" +
                $"Cantidad depositos permitidos: {CantidadDepositos} \n" +
                $"Cantidad retiros permitidos: {CantidadRetiros} \n" +
                $"Monto: {Monto}\n");
        }
    }
}