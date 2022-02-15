using System;
namespace UnidadDosA2
{

    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Declaración de variables
            string [] ciudades = new string[3];
            int [] numeros = new int[3];
            //Impresión y solicitud de datos 
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de vacunación, ingresa los siguientes datos del paciente");
            
            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.Write($"Ingresa el nombre de la ciudad {i + 1}: ");
                ciudades[i] = Console.ReadLine();
            }
            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            listaCiudad(ciudades);
            listaNumeros(numeros);
        }

        public static void listaCiudad(string [] ciudades)
        {
            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.WriteLine($"La ciudad {i + 1} es: {ciudades[i]}");
            }
        }

        public static void listaNumeros(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El número {i + 1} es: {numeros[i]}");
            }
        }

    }

}