namespace UnidadTresEA
{
    class Pizza
    {
        public List<Ingrediente> Ingredientes { get; set; }
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public Tipo Type { get; set; }
        public string Tiempo { get; set; }
        public static int contador = 1;

        public Pizza()
        {

        }
        public Pizza(string name, List<Ingrediente> ingredientes, Tipo tipo, string tiempo)
        {
            Ingredientes = ingredientes;
            PizzaName =name;
            Type = tipo;
            Tiempo = tiempo;
            Id = contador++;
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Nombre: {PizzaName}\n" +
                $"Tiempo de cocción: {Tiempo} minutos\n" +
                $"Tamaño: {Type.Name}\n" +
                $"Precio: ${Type.Precio}");
            Console.WriteLine($"Ingredientes: ");
            for (int i=0; i<Ingredientes.Count;i++)
            {
                Console.WriteLine($"{i+1} - {Ingredientes[i].Name}");
            }
            Console.WriteLine($"\n");
        }
        public void MostrarIngredientes()
        {
            Console.WriteLine($"Ingredientes: ");
            for (int i = 0; i < Ingredientes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Ingredientes[i].Name}");
            }
        }
    }
}