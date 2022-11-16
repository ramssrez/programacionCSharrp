namespace UnidadTresEA
{
    class Ingrediente
    {
        public int Id { get;}
        public string Name { get; set; }
        public static int contador = 1;

        public Ingrediente()
        {

        }
        public Ingrediente(string name)
        {
            Id = contador++;
            Name = name;
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Nombre: {Name}");
        }
    }
}