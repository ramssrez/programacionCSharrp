namespace UnidadUnoEA
{
    public class Creador
    {
        public String Nombre { get; set; }
        public int Id { get; set; }
        public String Apellido { get; set; }
        public Creador()
        {
        }
        public Creador(string nombre, int identificador, string apellido)
        {
            Nombre = nombre;
            Id = identificador;
            Apellido = apellido;
        }
        public void ToString()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Nombre: {Nombre} \n" +
                $"Apellido: {Apellido} \n");
        }
    }
}