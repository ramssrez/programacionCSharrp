using System;
using System.Collections;
namespace UnidadUnoEA
{
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            Presentacion();
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
        public static void Presentacion()
        {
            Personajes personajes = new Personajes();
            Personaje personaje1 = personajes.WoderWoman();
            Personaje personaje2 = personajes.Lobo();
            Personaje personaje3 = personajes.CatWoman();
            Personaje personaje4 = personajes.ReverseFlash();
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de héroes DC");
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
                Console.WriteLine("5. Informe de la consulta");
                Console.WriteLine("6. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos del paciente
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        //IngresarDatosPaciente();
                        Console.WriteLine("****Ingreso de datos exitosa***");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Llamado al método para imprimir la información del paciente
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        personaje1.Ataque();
                        personaje1.Pelea();
                        personaje1.ToString();
                        //InformePaciente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Llamado al método para actualizar la información del cliente
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        //ActualizarDatosPaciente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Llamado al método para registrar una consulta para el paciente
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        //RegistrarConsulta();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        //Llamado al metodo para mostrar el informe de la consulta
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 5");
                        //InformeConsulta();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 6:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido salir de la aplicación");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 6");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
            }
        }

    }
}