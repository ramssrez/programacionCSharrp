namespace UnidadTresEA
{
    //Declaración de la clase ManejadorPizzas
    class ManejadorPizzas
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public List<Pizza> PizzasCarlos { get; set; }
        public List<Pizza> PizzasHuawaina { get; set; }
        public List<Pizza> PizzasMexicana { get; set; }
        public List<Pizza> PizzasCubana { get; set; }
        public List<Pizza> PizzasVegetariana { get; set; }
        public List<Pizza> PizzasMarinera { get; set; }
        public List<Pizza> PizzasPeperoni { get; set; }
        public List<Pizza> PizzasAnchoas { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        //Declaración del constructor vacio de la clase
        public ManejadorPizzas()
        {
            ListaIngredientes();
            ListaPizzasCarlos();
            ListaPizzasHuawaina();
            ListaPizzasMexicana();
            ListaPizzasCubana();
            ListaPizzasVegetariana();
            ListaPizzasMarinera();
            ListaPizzasPeperoni();
            ListaPizzasAnchoas();
        }
        //Métodos para crear las diferentes variedadees de pizzas
        private void ListaPizzasAnchoas()
        {
            Pizza pizza21 = new("Anchoas", new List<Ingrediente> { Ingredientes[0], Ingredientes[10] }, new Tipo("Chica", 100.0),29);
            Pizza pizza22 = new("Anchoas", new List<Ingrediente> { Ingredientes[0], Ingredientes[10] }, new Tipo("Mediana", 150.0), 29);
            Pizza pizza23 = new("Anchoas", new List<Ingrediente> { Ingredientes[0], Ingredientes[10] }, new Tipo("Grande", 200.0), 29);
            PizzasAnchoas = new List<Pizza> { pizza21, pizza22, pizza23 };
        }
        private void ListaPizzasPeperoni()
        {
            Pizza pizza18 = new("Peperoni", new List<Ingrediente> { Ingredientes[0], Ingredientes[12] }, new Tipo("Chica", 100.0), 30);
            Pizza pizza19 = new("Peperoni", new List<Ingrediente> { Ingredientes[0], Ingredientes[12] }, new Tipo("Mediana", 150.0), 30);
            Pizza pizza20 = new("Peperoni", new List<Ingrediente> { Ingredientes[0], Ingredientes[12] }, new Tipo("Grande", 200.0), 30);
            PizzasPeperoni = new List<Pizza> { pizza18, pizza19, pizza20 };
        }
        private void ListaPizzasMarinera()
        {
            Pizza pizza15 = new("Marinera", new List<Ingrediente> { Ingredientes[0], Ingredientes[11] }, new Tipo("Chica", 200.0), 45);
            Pizza pizza16 = new("Marinera", new List<Ingrediente> { Ingredientes[0], Ingredientes[11] }, new Tipo("Mediana", 250.0), 45);
            Pizza pizza17 = new("Marinera", new List<Ingrediente> { Ingredientes[0], Ingredientes[11] }, new Tipo("Grande", 300.0), 45);
            PizzasMarinera = new List<Pizza> { pizza15, pizza16, pizza17 };
        }
        private void ListaPizzasVegetariana()
        {
            Pizza pizza12 = new("Vegetariana", new List<Ingrediente> { Ingredientes[0], Ingredientes[9], Ingredientes[10] }, new Tipo("Chica", 100.0), 32);
            Pizza pizza13 = new("Vegetariana", new List<Ingrediente> { Ingredientes[0], Ingredientes[9], Ingredientes[10] }, new Tipo("Mediana", 150.0), 32);
            Pizza pizza14 = new("Vegetariana", new List<Ingrediente> { Ingredientes[0], Ingredientes[9], Ingredientes[10] }, new Tipo("Grande", 200.0), 32);
            PizzasVegetariana = new List<Pizza> { pizza12, pizza13, pizza14 };
        }
        private void ListaPizzasCubana()
        {
            Pizza pizza9 = new("Cubana", new List<Ingrediente> { Ingredientes[0], Ingredientes[4], Ingredientes[1], Ingredientes[7], Ingredientes[8] }, new Tipo("Chica", 100.0), 30);
            Pizza pizza10 = new("Cubana", new List<Ingrediente> { Ingredientes[0], Ingredientes[4], Ingredientes[1], Ingredientes[7], Ingredientes[8] }, new Tipo("Mediana", 150.0), 30);
            Pizza pizza11 = new("Cubana", new List<Ingrediente> { Ingredientes[0], Ingredientes[4], Ingredientes[1], Ingredientes[7], Ingredientes[8] }, new Tipo("Grande", 200.0), 30);
            PizzasCubana = new List<Pizza> { pizza9, pizza10, pizza11 };
        }
        private void ListaPizzasMexicana()
        {
            Pizza pizza6 = new("Mexicana", new List<Ingrediente> { Ingredientes[0], Ingredientes[4], Ingredientes[5], Ingredientes[6] }, new Tipo("Chica", 100.0), 45);
            Pizza pizza7 = new("Mexicana", new List<Ingrediente> { Ingredientes[0], Ingredientes[4], Ingredientes[5], Ingredientes[6] }, new Tipo("Mediana", 150.0), 45);
            Pizza pizza8 = new("Mexicana", new List<Ingrediente> { Ingredientes[0], Ingredientes[4], Ingredientes[5], Ingredientes[6] }, new Tipo("Grande", 200.0), 45);
            PizzasMexicana = new List<Pizza> { pizza6, pizza7, pizza8 };
        }
        private void ListaPizzasHuawaina()
        {
            Pizza pizza3 = new("Hawaiana", new List<Ingrediente> { Ingredientes[0], Ingredientes[1], Ingredientes[2], Ingredientes[3] }, new Tipo("Chica", 100.0), 28);
            Pizza pizza4 = new("Hawaiana", new List<Ingrediente> { Ingredientes[0], Ingredientes[1], Ingredientes[2], Ingredientes[3] }, new Tipo("Mediana", 150.0), 28);
            Pizza pizza5 = new("Hawaiana", new List<Ingrediente> { Ingredientes[0], Ingredientes[1], Ingredientes[2], Ingredientes[3] }, new Tipo("Grande", 200.0), 28);
            PizzasHuawaina = new List<Pizza> { pizza3, pizza4, pizza5 };

        }
        private void ListaPizzasCarlos()
        {
            Pizza pizza = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Chica", 100.0), 30);
            Pizza pizza1 = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Mediana", 150.0), 30);
            Pizza pizza2 = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Grande", 200.0), 30);
            PizzasCarlos = new List<Pizza> { pizza,pizza1,pizza2};
        }
        //Método que crea las diferentes ingredientes del menú
        private void ListaIngredientes()
        {
            Ingredientes = new List<Ingrediente>();
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
            Ingredientes = new List<Ingrediente> {ing1, ing2,ing3, ing4, ing5, ing6, ing7, ing8, ing9, ing10, ing11, ing12,ing13 };
        }
    }
}