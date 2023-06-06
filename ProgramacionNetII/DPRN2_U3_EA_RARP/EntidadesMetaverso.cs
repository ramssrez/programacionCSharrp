namespace UnidadTresEA
{
    //Declaración de la clase EntidadesMetaverso con sus atributos necesarios
    public class EntidadesMetaverso
    {
        //Declaración de las variables y métodos  getter y setter del objeto Tipo
        public List<EntidadMetaverso>? Entidades { get; set; }
        //Declaración del constructor vacío, pero agrega la lista de las entidades
        public EntidadesMetaverso()
        {
            Entidades = new List<EntidadMetaverso>();
            Entidades.AddRange(Personajes());
            Entidades.AddRange(Objetos());
            Entidades.AddRange(Lugares());
            Entidades.AddRange(Eventos());
        }
        //Método que permite crear una lista de personajes del metaverso
        private List<EntidadMetaverso> Personajes()
        {
            Personaje personaje = new("Programador 1", "Desarrollador de videojuegos dentro del metaverso nivel I", Strings.PERSONAJE, "Desarrollador videojuegos consola");
            Personaje personaje2 = new ("Programador 2", "Desarrollador de videojuegos dentro del metaverso nivel II", Strings.PERSONAJE, "Desarrollador videojuegos móvil");
            Personaje personaje3 = new("Programador 3", "Desarrollador de videojuegos dentro del metaverso nivel III", Strings.PERSONAJE, "Desarrollador videojuegos de escritorio");

            return new List<EntidadMetaverso>() {personaje,personaje2,personaje3 };
        }
        //Método que permite crear una lista de objetos del metaverso
        private List<EntidadMetaverso> Objetos()
        {
            Objeto objeto = new ("Computadora", "Computadora de ultima generación para poder desarrollar videojuegos para consolas", Strings.OBJETO, "Electrónico");
            Objeto objeto1 = new ("Escritorio", "Escritorio que sostiene todo el equipo necesario para poder desarrollar videojuegos", Strings.OBJETO, "Mueble");
            Objeto objeto2 = new ("Mouse", "Mouse necesario para tener el control de la interfaz gráfica con el usuaro", Strings.OBJETO, "Electrónico");
            Objeto objeto3 = new ("Silla", "Silla en donde el usuario puede sentarse y desarrollar los videojuegos con su respectiva computadora", Strings.OBJETO, "Mueble");
            Objeto objeto4 = new ("Teclado", "Teclado para que el usuario pueda escribir en la computadora", Strings.OBJETO, "Electrónico");
            return new List<EntidadMetaverso>() { objeto,objeto1,objeto2, objeto3,objeto4};
        }
        //Método que permite crear una lista de lugares del metaverso
        private List<EntidadMetaverso> Lugares()
        {
            Lugar lugar = new("Oficina", "Oficina de desarrollo de videojuegos", Strings.LUGAR, "CDMX");
            Lugar lugar2 = new("World Trade Center", "Primer piso de la torre", Strings.LUGAR, "CDMX");
            Lugar lugar3 = new("Friki Plaza", "Tercer piso de la Friki Plaza", Strings.LUGAR, "CDMX");
            return new List<EntidadMetaverso>() { lugar, lugar2,lugar3 };
        }
        //Método que perimite crear una lista de eventos del metaverso
        private List<EntidadMetaverso> Eventos()
        {
            Lugar lugar2 = new("World Trade Center", "Primer piso de la torre", Strings.LUGAR, "CDMX");
            Lugar lugar3 = new("Friki Plaza", "Tercer piso de la Friki Plaza", Strings.LUGAR, "CDMX");
            Evento evento = new("Hackaton", "Hackaton desarrollo de videojuegos", Strings.EVENTO, "20/06/2023", lugar2, "Hackaton para todo publico en general, que guste experimentar" +
                "la adredalina para poder desarrollar videojuegos en consola, ven con tu equipo para mostrar tus habilidades de desarrollo ya sea en equipo o dentro de " +
                 "las instalaciones puedes crear tu propio equipo");

            Evento evento2 = new("La Mole", "Comics, anime y videojuegos en un solo lugar", Strings.EVENTO, "24/06/2023", lugar3, "Visita el evento anual de comics, anime y videjuegos" +
                "en donde podras una gran cantidad de stands de diferentes temas que te pueden interesar, además de stads de actores de doblaje");
            return new List<EntidadMetaverso>() { evento,evento2};
        }
    }
}