namespace UnidadTresAC
{
    class Program
    {
        //Declaración de las variables globales

        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Llamado al método de presentación
            Presentacion();
        }
        public static void Presentacion()
        {
            Console.WriteLine("Hola desde la reflexión");
            //Beca beca = new();
            BecaDeportiva beca = new();
            BecaAcademica becaA = new();
        }
    }
}