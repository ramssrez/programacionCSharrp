﻿namespace UnidadTresEA
{
    class Program
    {
        //Declaración de la variable global de la aplicación

        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Inicio del método que contiene el menú de principal.
            Presentacion();
        }
        //Método que muesta el menú de opciones para el caso de estudio
        public static void Presentacion()
        {
            //EntidadMetaverso entidad = new EntidadMetaverso();
            Personaje personaje = new Personaje("Programador 1","Desarrollador de videojuegos dentro del metaverso nivel I","Desarrollador videojuegos consola");
            Personaje personaje2 = new Personaje("Programador 2", "Desarrollador de videojuegos dentro del metaverso nivel II", "Desarrollador videojuegos móvil");
            Personaje personaje3 = new Personaje("Programador 3", "Desarrollador de videojuegos dentro del metaverso nivel III", "Desarrollador videojuegos móvil");
            Objeto objeto = new Objeto("Computadora","Computadora de ultima generación que contiene los programas necesarios para poder desarrollar videojuegos para consolas","Electrónico");
            Objeto objeto1 = new Objeto("Escritorio", "Escritorio que sostiene todo el equipo necesario para poder desarrollar videojuegos", "Mueble");
            Objeto objeto2 = new Objeto("Mouse", "Mouse necesario para tener el control de la interfaz gráfica con el usuaro", "Electrónico");
            Objeto objeto3 = new Objeto("Silla", "Silla en donde el usuario puede sentarse y desarrollar los videojuegos con su respectiva computadora", "Mueble");
            Objeto objeto4 = new Objeto("Teclado", "Teclado para que el usuario pueda escribir en la computadora", "Electrónico");

            Lugar lugar = new Lugar("Oficina","Oficina de desarrollo de videojuegos","CDMX");
            Evento evento = new Evento();
            List<EntidadMetaverso> entidadMeta = new List<EntidadMetaverso>() { personaje, objeto,lugar};
            for (int i = 0; i< entidadMeta.Count;i++)
            {
                Console.WriteLine($"Id: {entidadMeta[i].ID} mensaje: {entidadMeta[i].Interactuar()}");
            }
            for (int i = 0; i < entidadMeta.Count; i++)
            {
                Console.WriteLine($"{i}. {entidadMeta[i].DatosEntidad()}");
            }
        }
    }
}