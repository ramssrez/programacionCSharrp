namespace UnidadTresEA
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
            Personaje personaje = new Personaje("Programador 1","Desarrollador de videojuegos dentro del metaverso","Desarrollador videojuegos");
            Objeto objeto = new Objeto();
            Lugar lugar = new Lugar();
            List<EntidadMetaverso> entidadMeta = new List<EntidadMetaverso>() { personaje, objeto,lugar};
            for (int i = 0; i< entidadMeta.Count;i++)
            {
                Console.WriteLine($"Id: {entidadMeta[i].ID} mensaje: {entidadMeta[i].Interactuar()}");
            }
        }
    }
}