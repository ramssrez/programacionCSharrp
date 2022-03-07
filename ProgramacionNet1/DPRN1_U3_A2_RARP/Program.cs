using System;
namespace UnidadTresU2
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
            Console.WriteLine("Bienvenidos al sistema del cálculo de área y perímetos de distintas fíguras geométricas");
            //Declaración del cliente de tipo cliente
            //Cliente cliente = new Cliente();
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Área y perímetro de un Trapecio");
                Console.WriteLine("2. Área y perímetro de una Estrella de 6 puntas");
                Console.WriteLine("3. Área y perímetro de un Círculo");
                Console.WriteLine("4. Área y perímetro de una Estrella de 5 puntas");
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
                        //IngresoDatosUsuario(cliente);
                        DatosTrapecio();
                        break;
                    //Llamado del método para mostrar la información del usuario
                    case 2:
                        Console.WriteLine("Has elegido la opción 2");
                        //MostrarInformacionUsuario(cliente);
                        break;
                    //Llamado del método para realizar el deposito de un cliente
                    case 3:
                        Console.WriteLine("Has elegido la opción 3");
                        //RealizarDepositos(cliente);
                        break;
                    //llamado del método para realizar un deposito del cliente
                    case 4:
                        Console.WriteLine("Has elegido la opción 4");
                        //RealizarRetiros(cliente);
                        break;
                    //Llamado del método para mostrar la información del cliente
                    case 5:
                        Console.WriteLine("Has elegido la opción 5");
                        //MostrarBalance(cliente);
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
        public static void DatosTrapecio()
        {
            //Impresión y recepción de la información del trapecio
            Console.WriteLine("**************************************************************************************");
            double BaseMayor, BaseMenor, Altura, LadoIzquierdo, LadoDerecho;
            Console.Write("Ingresa la base mayor del Trapecio: ");
            BaseMayor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la base menor del Trapecio: ");
            BaseMenor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la altura del Trapecio: ");
            Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la longitud izquieda del Trapecio: ");
            LadoIzquierdo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la longitud derecha del Trapecio: ");
            LadoDerecho = Convert.ToDouble(Console.ReadLine());
            //Llamado al método que determina el valor del cliente en función del tipo seleccionado
            //DeterminarTipoCliente(cliente);
            Console.WriteLine($"El área del Trapecio es: {Area(BaseMayor,BaseMenor,Altura)} [Unidades Cuadradas]");
            Console.WriteLine($"El perímetro del Trapecio es: {Perimetro(BaseMayor,BaseMenor,LadoIzquierdo,LadoDerecho)} [Unidades Lineales]");
            Console.WriteLine("**************************************************************************************");
        }
        public static double Area(double BaseMayor, double BaseMenor, double Altura)
        {
            return ((BaseMayor + BaseMenor) / 2) * Altura;
        }
        public static double Perimetro(double BaseMayor, double BaseMenor, double LadoIzquierdo, double LadoDerecho)
        {
            return (BaseMenor +BaseMayor + LadoDerecho + LadoIzquierdo);
        }
        public static double Area(double Radio)
        {
            return (Math.PI*(Radio*Radio));
        }
    }
}