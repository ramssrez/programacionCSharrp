using System;
namespace UnidadUnoEA
{
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            Personaje personaje = new Personaje();
            personaje.NombreReal = "Diana";
            Console.WriteLine("Hola mundo" + personaje.NombreReal);
            Console.WriteLine("**********************************************************************************************");
        }
    }
    /*
    class Personaje
    {
        public string NombreReal { get; set; }
        public string NombreConocido { get; set; }
        public string PrimeraAparicionHistorica { get; set; }
        public string PrimeraAparicion { get; set; }
        public string Poderes { get; set; }
        public string Creador { get; set; }
        public string Descripcion { get; set; }
        public bool Humano { get; set; }
        public string PuntosExperiencia { get; set; }
        public string NivelFisico { get; set; }


        Personaje()
        {

        }
        Personaje(string nombreConocido, string nombreReal, string primeraAparicionHistorica,
            string primeraAparicion, string poderes, string creador, string descripcion)
        {

        }
    }
    */
}