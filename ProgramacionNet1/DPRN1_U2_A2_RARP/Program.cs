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
            //Impresión y solicitud de datos para 
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema para observar el funcionamiento de métodos que no regresan datos");
            Console.WriteLine(" ");
            Console.WriteLine("Ingresa los nombres de tres las ciudades");
            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.Write($"Ingresa el nombre de la ciudad {i + 1}: ");
                ciudades[i] = Console.ReadLine();
            }
            Console.WriteLine(" ");
            Console.WriteLine("Ingresa tres numeros enteros diferentes");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingresa el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("**********************************************************************************************");
            listaCiudad(ciudades);
            listaNumeros(numeros);
        }
        public static void listaCiudad(string [] ciudades)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Las ciudades son las siguientes");
            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.WriteLine($"La ciudad {i + 1} es: {ciudades[i]}");
            }
            Console.WriteLine("**********************************************************************************************");
        }
        public static void listaNumeros(int[] numeros)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Los numeros son los siguientes");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El número {i + 1} es: {numeros[i]}");
            }
            Console.WriteLine("**********************************************************************************************");
        }

    }
}