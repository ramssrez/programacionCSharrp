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
            Personajes();
            Console.WriteLine("**********************************************************************************************");
        }
        public static void Personajes()
        {
            Personaje wonderWoman = new Personaje("Wonder Woman","Princesa Diana de Temiscira","All Start Commics V1 #8, Dic. 1941/ Ene. 1942","Wonder Eoman V4 #1, Sep. 2011",
                "Vuelo, Súper fierza, Súper velocidad, Brazaletes indestructibles, Lazo mágico dela verdad","William Moulton Marston, Harry G. Peter","sdfasdfasdfasdf",1.0f,"sdfasdfsadf", true);
            wonderWoman.ToString();
        } 
    }
}