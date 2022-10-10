namespace UnidadUnoEA
{
    public class Poder
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }

        public Poder()
        {

        }
        public Poder(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public void ToString()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Descripción: {Descripcion} \n");
        }
    }
}