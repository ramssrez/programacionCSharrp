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
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema bancario, selecciona alguna opción del menú");
            //Declaración del cliente de tipo cliente
            Cliente cliente = new Cliente();
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Ingresar los datos del usuario");
                Console.WriteLine("2. Mostrar información de usuario");
                Console.WriteLine("3. Realizar depositos a la cuenta");
                Console.WriteLine("4. Realizar retiros a la cuenta");
                Console.WriteLine("5. Mostrar monto de la cuenta");
                Console.WriteLine("6. Salir");
                Console.Write("Ingresa una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                //Uso del switch para selecion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para el ingreso de datos del usuario
                    case 1:
                        Console.WriteLine("Has elegido la opción 1");
                        IngresoDatosUsuario(cliente);
                        break;
                     //Llamado del método para mostrar la información del usuario
                     case 2:
                         Console.WriteLine("Has elegido la opción 2");
                         MostrarInformacionUsuario(cliente);
                         break;
                    //Llamado del método para realizar el deposito de un cliente
                     case 3:
                         Console.WriteLine("Has elegido la opción 3");
                         RealizarDepositos(cliente);
                         break;
                    //llamado del método para realizar un deposito del cliente
                     case 4:
                         Console.WriteLine("Has elegido la opción 4");
                         RealizarRetiros(cliente);
                         break;
                    //Llamado del método para mostrar la información del cliente
                     case 5:
                         Console.WriteLine("Has elegido la opción 5");
                         MostrarBalance(cliente);
                         break;
                    //Finalización del programa
                     case 6:
                         Console.WriteLine("Has elegido salir de la aplicación");
                         salir = true;
                         break;
                    //Opción en el caso de que el usuario no seleccione una opción
                     default:
                        Console.WriteLine("Elige una opcion entre 1 y 6");
                        break;
                }
            }    
        }
        //Método que realizar el ingreso de los datos de un usuario
        public static void IngresoDatosUsuario(Cliente cliente)
        {
            //Impresión y recepción de la información del cliente
            Console.WriteLine("**************************************************************************************");
            Console.Write("Ingrese el nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.Write("Ingrese la clave del cliente: ");
            cliente.Clave = Console.ReadLine();
            Console.Write("Ingrese el tipo de cliente (Standart, Priority o Premium): ");
            cliente.TipoCliente = Console.ReadLine();
            //Llamado al método que determina el valor del cliente en función del tipo seleccionado
            DeterminarTipoCliente(cliente);
            Console.WriteLine("**************************************************************************************");
        }
        //Método que determina el tipo de cliente con la recepción de un cliente
        public static Cliente DeterminarTipoCliente(Cliente cliente)
        {
            //Sentencias if/else en donde se lee el valor del tipo de cliente para asignar los valores de la cantidad de depositos y retiros
            if (cliente.TipoCliente == "Standart" || cliente.TipoCliente == "standart")
            {
                cliente.CantidadDepositos = 3;
                cliente.CantidadRetiros = 2;
            }else if (cliente.TipoCliente == "Priority" || cliente.TipoCliente == "priority")
            {
                cliente.CantidadDepositos = 5;
                cliente.CantidadRetiros = 4;
            }
            else if (cliente.TipoCliente == "Premium" || cliente.TipoCliente == "premium")
            {
                cliente.CantidadDepositos = 8;
                cliente.CantidadRetiros = 8;
            }
            return cliente;
        }
        //Método que muestra la información del cliente
        public static void MostrarInformacionUsuario(Cliente cliente)
        {
            //Impresión de la información con un método de la clase Cliente
            Console.WriteLine("**************************************************************************************");
            cliente.ToString();
            Console.WriteLine("**************************************************************************************");
        }
        //Método que realizar el deposito en la cuenta del cliente
        public static void RealizarDepositos(Cliente cliente)
        {
            Console.WriteLine("**************************************************************************************");
            //Sentencia if/else que verifica si el cliente puede realizar depositos
            if (cliente.CantidadDepositos != 0)
            {
                Console.Write("Ingresa el deposito a realizar: ");
                double depositar = Convert.ToDouble(Console.ReadLine());
                cliente.Depositar(depositar);
            }
            else
            {
                //Impresión en el caso de que no se puedan realizar depositos
                Console.WriteLine("No se pueden realizar mas depositos");
            }
            Console.WriteLine("**************************************************************************************");
        }
        //Método que realiza el retiro de la cuenta del cliente
        public static void RealizarRetiros(Cliente cliente)
        {
            Console.WriteLine("**************************************************************************************");
            //Sentencia if/else que verifica si el cliente puede realizar retiros
            if (cliente.CantidadRetiros != 0)
            {
                Console.Write("Ingresa el retiro a realizar: ");
                double retirar = Convert.ToDouble(Console.ReadLine());
                cliente.Retirar(retirar);
            }
            else
            {
                //Impresión en el caso de que no se puedan realizar retiros
                Console.WriteLine("No se pueden realizar mas retiros");
            }
            Console.WriteLine("**************************************************************************************");
        }
        //Método que muestra el balance o saldo del cliente
        public static void MostrarBalance(Cliente cliente)
        {
            //Impresión del monto del cliente
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine($"El cliente tiene un monto de: ${cliente.Monto}");
            Console.WriteLine("**************************************************************************************");
        }
    }
    //Definición de la clase Cliente
    class Cliente
    {
        //Declaración de los métodos getters, setters y los atributos de la clase
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string TipoCliente { get; set; }
        public double Monto { get; set; }
        public int CantidadDepositos { get; set; }
        public int CantidadRetiros { get; set; }
        //Declaración del constructos vacio de la clase
        public Cliente()
        {

        }
        //Declaración del método para depositar
        public void Depositar(double ingreso)
        {
            this.Monto = this.Monto + ingreso;
            this.CantidadDepositos = this.CantidadDepositos - 1;
        }
        //Declaración del método para retirar
        public void Retirar(double retiro)
        {
            this.Monto = this.Monto - retiro;
            this.CantidadRetiros = this.CantidadRetiros - 1;
        }
        //Declaración del método para la impresión de la información del cliente
        public void ToString()
        {
            Console.WriteLine("Los datos del cliente son los siguientes");
            Console.WriteLine($"Nombre del cliente: {Nombre} \n" +
                $"Clave: {Clave} \n" +
                $"Tipo de cliente: {TipoCliente} \n" +
                $"Cantidad depositos permitidos: {CantidadDepositos} \n" +
                $"Cantidad retiros permitidos: {CantidadRetiros} \n" +
                $"Monto: {Monto}\n");
        }
    }
}