using System;
using System.Collections;
namespace UnidadUnoEA
{
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Personaje personaje = new();
            //personaje.NombreReal = "Princesa Diana de Temiscaar";

            //Console.WriteLine("Hola mundo" + personaje.NombreReal);
            //Personajes();
            Personajes personajes = new Personajes();
            Personaje personaje1 = personajes.WoderWoman();
            personaje1.ToString();
            personaje1.NombreReal = "Julion";
            personaje1.ToString();


        }

    }
}