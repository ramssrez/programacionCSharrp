namespace UnidadTresEA
{
    class Program
    {
        public static List<Ingrediente> ingredientes;
        public static List<Pizza> pizzas;
        static void Main(string[] args)
        {
            //Inicio del método que contiene el menú de principal.
            //Presentacion();
            Posicion pizzeria = new(19.3934749F, -99.176846F);
            Posicion granada= new(19.4934749F, -99.276846F);
            float distancia = DistanciaKm(pizzeria,granada);
            Console.WriteLine($"La distancia es: {distancia}");

        }
        public static float DistanciaKm(Posicion posOrigen, Posicion posDestino)
        {
            float RadioTierraKm = 6378.0F;
            float radianLat = EnRadianes(posDestino.Latitud-posOrigen.Latitud);
            float radianLon = EnRadianes(posDestino.Longitud - posOrigen.Longitud);


            //float difLatitud = (posDestino.Latitud – posOrigen.Latitud).EnRadianes();
            //var difLongitud = (posDestino.Longitud - posOrigen.Longitud).EnRadianes();


            var a = Math.Sin(AlCuadrado(radianLat / 2)) +
                      Math.Cos(EnRadianes(posOrigen.Latitud)) *
                      Math.Cos(EnRadianes(posDestino.Latitud)) *
                      Math.Sin(AlCuadrado(radianLon / 2));

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a));

            return RadioTierraKm * Convert.ToSingle(c);
        }
        public static float EnRadianes(float valor)
        {
            return Convert.ToSingle(Math.PI / 180) * valor;
        }
        static double AlCuadrado(double valor)
        {
            return Math.Pow(valor, 2);
        }
        private static void Presentacion()
        {
            CrearIngredientes();
            CrearPizzas();
        }

        private static void CrearPizzas()
        {
            pizzas = new List<Pizza>();
            Pizza pizza = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Chica", 100.0), "30");
            Pizza pizza1 = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Mediana", 150.0), "30");
            Pizza pizza2 = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Grande", 200.0), "30");

            Pizza pizza3 = new("Hawaiana", new List<Ingrediente> { ingredientes[0], ingredientes[1], ingredientes[2], ingredientes[3] }, new Tipo("Chica", 100.0), "28");
            Pizza pizza4 = new("Hawaiana", new List<Ingrediente> { ingredientes[0], ingredientes[1], ingredientes[2], ingredientes[3] }, new Tipo("Mediana", 150.0), "28");
            Pizza pizza5 = new("Hawaiana", new List<Ingrediente> { ingredientes[0], ingredientes[1], ingredientes[2], ingredientes[3] }, new Tipo("Grande", 200.0), "28");

            Pizza pizza6 = new("Mexicana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[5], ingredientes[6] }, new Tipo("Chica", 100.0), "45");
            Pizza pizza7 = new("Mexicana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[5], ingredientes[6] }, new Tipo("Mediana", 150.0), "45");
            Pizza pizza8 = new("Mexicana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[5], ingredientes[6] }, new Tipo("Grande", 200.0), "45");

            Pizza pizza9 = new("Cubana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[1], ingredientes[7], ingredientes[8] }, new Tipo("Chica", 100.0), "30");
            Pizza pizza10 = new("Cubana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[1], ingredientes[7], ingredientes[8] }, new Tipo("Mediana", 150.0), "30");
            Pizza pizza11 = new("Cubana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[1], ingredientes[7], ingredientes[8] }, new Tipo("Grande", 200.0), "30");

            Pizza pizza12 = new("Vegetariana", new List<Ingrediente> { ingredientes[0], ingredientes[9], ingredientes[10] }, new Tipo("Chica", 100.0), "32");
            Pizza pizza13 = new("Vegetariana", new List<Ingrediente> { ingredientes[0], ingredientes[9], ingredientes[10] }, new Tipo("Mediana", 150.0), "32");
            Pizza pizza14 = new("Vegetariana", new List<Ingrediente> { ingredientes[0], ingredientes[9], ingredientes[10] }, new Tipo("Grande", 200.0), "32");

            Pizza pizza15 = new("Marinera", new List<Ingrediente> { ingredientes[0], ingredientes[11] }, new Tipo("Chica", 200.0), "45");
            Pizza pizza16 = new("Marinera", new List<Ingrediente> { ingredientes[0], ingredientes[11] }, new Tipo("Mediana", 250.0), "45");
            Pizza pizza17 = new("Marinera", new List<Ingrediente> { ingredientes[0], ingredientes[11] }, new Tipo("Grande", 300.0), "45");

            Pizza pizza18 = new("Peperoni", new List<Ingrediente> { ingredientes[0], ingredientes[12] }, new Tipo("Chica", 100.0), "30");
            Pizza pizza19 = new("Peperoni", new List<Ingrediente> { ingredientes[0], ingredientes[12] }, new Tipo("Mediana", 150.0), "30");
            Pizza pizza20 = new("Peperoni", new List<Ingrediente> { ingredientes[0], ingredientes[12] }, new Tipo("Grande", 200.0), "30");

            Pizza pizza21 = new("Anchoas", new List<Ingrediente> { ingredientes[0], ingredientes[10] }, new Tipo("Chica", 100.0), "29");
            Pizza pizza22 = new("Anchoas", new List<Ingrediente> { ingredientes[0], ingredientes[10] }, new Tipo("Mediana", 150.0), "29");
            Pizza pizza23 = new("Anchoas", new List<Ingrediente> { ingredientes[0], ingredientes[10] }, new Tipo("Grande", 200.0), "29");

            pizzas.Add(pizza);
            pizzas.Add(pizza1);
            pizzas.Add(pizza2);
            pizzas.Add(pizza3);
            pizzas.Add(pizza4);
            pizzas.Add(pizza5);
            pizzas.Add(pizza6);
            pizzas.Add(pizza7);
            pizzas.Add(pizza8);
            pizzas.Add(pizza9);
            pizzas.Add(pizza10);
            pizzas.Add(pizza11);
            pizzas.Add(pizza12);
            pizzas.Add(pizza13);
            pizzas.Add(pizza14);
            pizzas.Add(pizza15);
            pizzas.Add(pizza16);
            pizzas.Add(pizza17);
            pizzas.Add(pizza18);
            pizzas.Add(pizza19);
            pizzas.Add(pizza20);
            pizzas.Add(pizza21);
            pizzas.Add(pizza22);
            pizzas.Add(pizza23);

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