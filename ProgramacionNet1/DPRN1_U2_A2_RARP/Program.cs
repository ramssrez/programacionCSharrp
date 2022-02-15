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
            calculadoraNumeros(numeros);
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
        //Método que realiza la calculadora de tres números que son ingresados por medio de un arreglo
        public static void calculadoraNumeros(int[] numeros)
        {
            //Declaración de variables y realización de la operación.
            int suma = numeros[0] + numeros[1] + numeros[2];
            int resta = numeros[0] - numeros[1] - numeros[2];
            int multi = numeros[0] * numeros[1] * numeros[2];
            //Impresión de los resultados
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Las operaciones son los siguientes: ");
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"La resta es: {resta}");
            Console.WriteLine($"La multiplicación es: {multi}");
            Console.WriteLine("**********************************************************************************************");
        }
    }
}