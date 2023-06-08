namespace UnidadTresA3
{
    class Program
    {
        //Declaración de la variable global de la aplicación
        //public static EntidadesMetaverso entidadesMeta = new();
        //public static UsuarioMetaverso usuario = new("Gratuita");
        public static List<Empleado> empleados = new List<Empleado>();
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Inicio del método que contiene el menú de principal.
            Presentacion();
        }
        //Método que muesta el menú de opciones para el caso de estudio
        public static void Presentacion()
        {
            Empleado empleado = new();
            Console.WriteLine(empleados.Count);

        }
    }
}
