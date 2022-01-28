using System;
namespace PrimeraPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a C#");
            Presentacion presentacion = new Presentacion();
            presentacion.ToString();
        }
    }

    class Presentacion
    {
        public Presentacion()
        {
            //String nombre = "Nombre del autor, matrícula y título de la actividad así como la fecha y hora actual";
            string nombre = "Raúl Ramírez Pérez";
            string matricula = "ES1921023412";
            string actividad = "Actividad 3 Resolver problemas con C#";

            Console.WriteLine("Bienvenido a la actividad número 3 de esta unidad");
            Console.WriteLine($"Programa desarrollado por: {nombre}");
            Console.WriteLine($"Matricula: {matricula}");
            Console.WriteLine($"Actividad: {actividad}");
            Console.WriteLine($"Fecha del sistema: {DateTime.Now}");

        }

    }

}
