using System;
namespace UnidadDosA2
{
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Declaración de variables necesarias para 
            string [] ciudades = new string[3];
            int [] numeros = new int[3];
            //Impresión y solicitud de datos para el desarrollo del problema
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al siguiente sistema para observar el funcionamiento de métodos que no regresan datos");
            Console.WriteLine(" ");
            Console.WriteLine("Ingresa los nombres de tres las ciudades");
            //Ingreso de las ciudades dentro de un arreglo de tipo string
            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.Write($"Ingresa el nombre de la ciudad {i + 1}: ");
                //Lectura de las ciudades que se ingresen en la consola
                ciudades[i] = Console.ReadLine();
            }
            Console.WriteLine(" ");
            Console.WriteLine("Ingresa tres numeros enteros diferentes");
            //Ingreso de los numeros dentro de un arreglo de tipo entero
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingresa el número {i + 1}: ");
                //Lectura de los numeros que se ingresen en la consola
                numeros[i] = int.Parse(Console.ReadLine());
            }
            //Llamado a los métodos para la impresión de los datos ingresados 
            listaCiudad(ciudades);
            listaNumeros(numeros);
        }
        //Método que lista las ciudades de un arreglo, no retorna valores
        public static void listaCiudad(string [] ciudades)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Las ciudades son las siguientes");
            //Uso de sentencia for para poder imprimir las ciudades
            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.WriteLine($"La ciudad {i + 1} es: {ciudades[i]}");
            }
            Console.WriteLine("**********************************************************************************************");
        }
        //Método que lista los numeros de un arreglo, no retorna valores
        public static void listaNumeros(int[] numeros)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Los numeros son los siguientes");
            //Uso de sentencia for para poder imprimir los numeros
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El número {i + 1} es: {numeros[i]}");
            }
            Console.WriteLine("**********************************************************************************************");
        }

    }
}