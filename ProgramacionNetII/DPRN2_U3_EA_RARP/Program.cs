namespace UnidadTresEA
{
    class Program
    {
        //Declaración de la variable global de la aplicación
        Strings strings = new Strings();
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
            Personaje personaje = new Personaje("Programador 1","Desarrollador de videojuegos dentro del metaverso nivel I",Strings.PERSONAJE,"Desarrollador videojuegos consola");
            Personaje personaje2 = new Personaje("Programador 2", "Desarrollador de videojuegos dentro del metaverso nivel II", Strings.PERSONAJE,"Desarrollador videojuegos móvil");
            Personaje personaje3 = new Personaje("Programador 3", "Desarrollador de videojuegos dentro del metaverso nivel III", Strings.PERSONAJE,"Desarrollador videojuegos de escritorio");
            
            Objeto objeto = new Objeto("Computadora","Computadora de ultima generación que contiene los programas necesarios para poder desarrollar videojuegos para consolas","Electrónico");
            Objeto objeto1 = new Objeto("Escritorio", "Escritorio que sostiene todo el equipo necesario para poder desarrollar videojuegos", "Mueble");
            Objeto objeto2 = new Objeto("Mouse", "Mouse necesario para tener el control de la interfaz gráfica con el usuaro", "Electrónico");
            Objeto objeto3 = new Objeto("Silla", "Silla en donde el usuario puede sentarse y desarrollar los videojuegos con su respectiva computadora", "Mueble");
            Objeto objeto4 = new Objeto("Teclado", "Teclado para que el usuario pueda escribir en la computadora", "Electrónico");

            Lugar lugar = new Lugar("Oficina","Oficina de desarrollo de videojuegos","CDMX");
            Lugar lugar2 = new Lugar("World Trade Center","Primer piso de la torre","CDMX");
            Lugar lugar3 = new Lugar("Friki Plaza", "Tercer piso de la Friki Plaza", "CDMX");

            Evento evento = new Evento("Hackaton","Hackaton desarrollo de videojuegos","20/06/2023",lugar2,"Hackaton para todo publico en general, que guste experimentar" +
                "la adredalina para poder desarrollar videojuegos en consola, ven con tu equipo para mostrar tus habilidades de desarrollo ya sea en equipo o dentro de " +
                "las instalaciones puedes crear tu propio equipo");

            Evento evento2 = new Evento("La Mole", "Comics, anime y videojuegos en un solo lugar", "24/06/2023", lugar3, "Visita el evento anual de comics, anime y videjuegos" +
                "en donde podras una gran cantidad de stands de diferentes temas que te pueden interesar, además de stads de actores de doblaje");

            List<EntidadMetaverso> entidadMeta = new List<EntidadMetaverso>() { personaje, personaje2, personaje3, objeto, objeto1, objeto2, objeto3, objeto4, lugar,lugar2,lugar3,evento, evento2 };
           /* 
            for (int i = 0; i< entidadMeta.Count;i++)
            {
                Console.WriteLine($"Id: {entidadMeta[i].ID} mensaje: {entidadMeta[i].Interactuar()}");
            }
            for (int i = 0; i < entidadMeta.Count; i++)
            {
                Console.WriteLine($"{i}. {entidadMeta[i].DatosEntidad()}");
            }
           */
            for (int i = 0; i < entidadMeta.Count; i++)
            {
                Console.WriteLine($"{i}. {entidadMeta[i].Descripcion}");
            }
        }
    }
}