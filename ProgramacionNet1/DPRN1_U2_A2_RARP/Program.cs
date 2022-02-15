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
            char sexo;
            double salario;
            //Impresión y solicitud de datos 
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de vacunación, ingresa los siguientes datos del paciente");
            Console.Write("Ingresa el nombre del paciente: ");
            
            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.Write($"Ingresa el nombre de la ciudad {i + 1}: ");
                ciudades[i] = Console.ReadLine();
            }

            foreach (string ciudad in ciudades)
            {
                Console.WriteLine(ciudad);
            }


        }

    }

}