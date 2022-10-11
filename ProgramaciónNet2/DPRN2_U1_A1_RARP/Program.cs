using System;
using System.Collections;
namespace UnidadUnoA1
{
    class Program
    {
        //Declaración de variables globales del programa
        public static Personajes? personajes;
        public static Personaje? personaje;
        public static List<Personaje>? personajeList;

        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Instancia de las variables globales
            personajes = new Personajes();
            personajeList = personajes.PersonajesDC();
            //Llamado al método de presentación
            Presentacion();
        }
        //Declaración del método presentación
        public static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de personajes de DC");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Mostrar información de los personajes");
                Console.WriteLine("2. Seleccionar personaje");
                Console.WriteLine("3. Pelea");
                Console.WriteLine("4. Ataque");
                Console.WriteLine("5. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de los personajes
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1, información de los personajes de DC");
                        infoPersonajes(personajeList);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder elegir un personaje
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        seleccionPersonaje();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la pelea del personaje seleccionado
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        if (personaje != null)
                        {
                            personaje.Pelea();
                        }
                        else
                        {
                            Console.WriteLine("No se ha seleccionado al personaje");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Caso para poder realizar el ataque del personaje
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        if (personaje != null)
                        {
                            personaje.Ataque();
                        }
                        else
                        {
                            Console.WriteLine("No se ha seleccionado al personaje");
                        }
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
        //Método que imprime la información de los personajes
        public static void infoPersonajes(List<Personaje>? personajeList)
        {
            //Recorrido de la lista de los personajes
            foreach (Personaje p in personajeList)
            {
                //Impresión de la informaición de los personajes
                Console.WriteLine("**********************************************************************************************");
                p.ToString();
                Console.WriteLine("**********************************************************************************************");
            }
        }
        //Nétodo que permite seleccionar un personaje de un menú
        public static void seleccionPersonaje()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Selecciona un personajes de DC");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones con las quese cuenta
                Console.WriteLine("0. Wonder Woman");
                Console.WriteLine("1. Lobo");
                Console.WriteLine("2. Flash Reverse");
                Console.WriteLine("3. CatWoman");
                Console.WriteLine("4. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Selección de Wonder Woman
                    case 0:
                        personaje = personajeList[opcion];
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine($"Has elegido a: {personaje.NombreComercial}");
                        salir = true;
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Selección de Lobo
                    case 1:
                        personaje = personajeList[opcion];
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine($"Has elegido a: {personaje.NombreComercial}");
                        salir = true;
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Selección de Reverse Flash
                    case 2:
                        personaje = personajeList[opcion];
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine($"Has elegido a: {personaje.NombreComercial}");
                        salir = true;
                        Console.WriteLine("**********************************************************************************************");
                        break;
                        //Selección de Cat Woman
                    case 3:
                        personaje = personajeList[opcion]; 
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine($"Has elegido a: {personaje.NombreComercial}");
                        salir = true;
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido salir del manú secundario");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 0 y 4");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
            }
        }
    }
}