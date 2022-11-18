namespace UnidadTresEA
{
    class Reserva
    {
        public int Hora { get; set; }
        public Posicion Posicion { get; set; }
        public List<Pizza> Pizzas { get; set; }
        //public Pizza Pizza { get; set; }
        public string TiempoEntrega { get; set; } 
        public Reserva()
        {
            Pizzas = new List<Pizza>();
        }
        public void MostrarReserva()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine($"Hora de pedido: {Hora} \n" +
                $"Latitud: {Posicion.Latitud} \n" +
                $"Longitud: {Posicion.Longitud} \n" +
                $"Total de Pizzas: ");
            MostrarPizzas(Pizzas);
        }
        public static void MostrarPizzas(List<Pizza> pizzas)
        {
            for (int i = 0; i < pizzas.Count; i++)
            {
                Console.WriteLine("**********************************************************************************************");
                Console.WriteLine($"{pizzas[i].PizzaName }, {pizzas[i].Type.Name}");
                pizzas[i].MostrarIngredientes();
            }
        }
    }
}