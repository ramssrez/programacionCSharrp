namespace UnidadTresEA
{
    //Declaración de la clase Pizza
    class Pizza
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public List<Ingrediente> Ingredientes { get; set; }
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public Tipo Type { get; set; }
        public int Tiempo { get; set; }
        public static int contador = 1;
        //Declaración del constructor vacio
        public Pizza()
        {

        }
        //Declaración del constructor con parametros
        public Pizza(string name, List<Ingrediente> ingredientes, Tipo tipo, int tiempo)
        {
            Ingredientes = ingredientes;
            PizzaName =name;
            Type = tipo;
            Tiempo = tiempo;
            Id = contador++;
        }
        //Método que muesta la información de la pizza con sus respectivos ingredientes
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
        //Método que muestra los ingredientes de la pizza
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