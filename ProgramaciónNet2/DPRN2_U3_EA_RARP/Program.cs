namespace UnidadTresEA
{
    class Program
    {
        public static List<Ingrediente> ingredientes;
        public static List<Pizza> pizzas;
        static void Main(string[] args)
        {
            //Inicio del método que contiene el menú de principal.
            Presentacion();
        }

        private static void Presentacion()
        {
            CrearIngredientes();
            CrearPizzas();
            //throw new NotImplementedException();
        }

        private static void CrearPizzas()
        {
            pizzas = new List<Pizza>();
            Pizza pizza = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos")}, new Tipo("Chica", 100.0), "30");
            Pizza pizza1 = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Median", 150.0), "30");
            Pizza pizza2= new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Grande", 200.0), "30");

            Pizza pizza3 = new("Hawaiana", new List<Ingrediente> { ingredientes[0],ingredientes[1],ingredientes[2],ingredientes[3]},new Tipo("Chica",100.0),"28");
            Pizza pizza4 = new("Hawaiana", new List<Ingrediente> { ingredientes[0], ingredientes[1], ingredientes[2], ingredientes[3] }, new Tipo("Mediana", 150.0), "28");
            Pizza pizza5 = new("Hawaiana", new List<Ingrediente> { ingredientes[0], ingredientes[1], ingredientes[2], ingredientes[3] }, new Tipo("Grande", 200.0), "28");
            pizzas.Add(pizza);
            pizzas.Add(pizza1);
            pizzas.Add(pizza2);
            pizzas.Add(pizza3);
            pizzas.Add(pizza4);
            pizzas.Add(pizza5);
            foreach (Pizza p in pizzas)
            {
                p.MostrarInfo();
            }
            //throw new NotImplementedException();
        }

        private static void CrearIngredientes()
        {
            ingredientes = new List<Ingrediente>();
            Ingrediente ing1 = new("Queso");
            Ingrediente ing2 = new("Jamón");
            Ingrediente ing3 = new("Tocino");
            Ingrediente ing4 = new("Piña");
            Ingrediente ing5 = new("Pierna");
            Ingrediente ing6 = new("Pollo");
            Ingrediente ing7 = new("Jalapeño");
            Ingrediente ing8 = new("Mayonesa");
            Ingrediente ing9 = new("Atún");
            Ingrediente ing10 = new("Champiñón");
            Ingrediente ing11 = new("Anchoas");
            Ingrediente ing12 = new("Mariscos");
            Ingrediente ing13 = new("Peperoni");
            //Ingrediente ing14 = new("Peperoni");
            ingredientes.Add(ing1);
            ingredientes.Add(ing2);
            ingredientes.Add(ing3);
            ingredientes.Add(ing4);
            ingredientes.Add(ing5);
            ingredientes.Add(ing6);
            ingredientes.Add(ing7);
            ingredientes.Add(ing8);
            ingredientes.Add(ing9);
            ingredientes.Add(ing10);
            ingredientes.Add(ing11);
            ingredientes.Add(ing12);
            ingredientes.Add(ing13);
            foreach (Ingrediente i in ingredientes)
            {
                Console.WriteLine($"{i.Id} - {i.Name}");
            }
        }
    }
}