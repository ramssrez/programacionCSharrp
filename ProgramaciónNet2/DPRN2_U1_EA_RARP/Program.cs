using System;
using System.Collections;
namespace UnidadUnoEA
{
    class Program
    {
        Pastel pastel = new Pastel();
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            Pastel pastel = new Pastel();
            Ingrediente ingrediente = new Ingrediente();
            Ingredientes ingredientes = new Ingredientes();
            ingredientes.IngredientesTotales.Add(ingrediente);
            foreach(Ingrediente om in ingredientes.IngredientesTotales)
            {
                Console.WriteLine("**********************************************************************************************");
                Console.WriteLine(om.Nombre);
                /*
                if (i.Tipo.Id != 1)
                {
                    Console.WriteLine(i.Nombre);
                }
                */
            }
            Presentacion();
        }
        public static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de pedidos de Pasteles Delicioso");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Mostrar ingredientes diponibles");
                Console.WriteLine("2. Realizar pedido");
                Console.WriteLine("3. Mostrar información del pedido");
                Console.WriteLine("4. Cerrar pedido");
                Console.WriteLine("5. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de los personajes
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder elegir un personaje
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la pelea del personaje seleccionado
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Caso para poder realizar el ataque del personaje
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido salir de la aplicación");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 5");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
            }
        }
        //Método que varifica si es un entero el valor ingresado desde la consola, se repite hasta que sea correcto
        public static int ValidarNumero(string mensaje)
        {
            //Declaración de variables necesarias para realizar el programa
            bool salir = false;
            int valor = 0;
            //Ciclo while que se repite en caso de que no se haya  ingresado un entero o sea menor a cuatro
            while (!salir)
            {
                //Uso de la sentencia try/catch para el caso de que no se ingrese un entero
                try
                {
                    Console.Write(mensaje);
                    valor = Convert.ToInt32(Console.ReadLine());
                    //Llamado al metodo para verificar que el valor ingresado sea mayor a cuatro
                    salir = true;
                }
                catch (FormatException ex)
                {
                    //Mensaje de error en caso de que no se haya ingresado un entero
                    Console.WriteLine("Error al ingresa valor, vuelve a intentarlo");
                }
                catch (OverflowException ex)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine("Número demasiado grande, intenta con otro número");
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
    }
}