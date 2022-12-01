namespace UnidadTresEA
{ 
    //Declaración de la clase Reserva
    class Reserva
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public int Hora { get; set; }
        public Posicion Posicion { get; set; }
        public List<Pizza> Pizzas { get; set; }
        //public string TiempoEntrega { get; set; }
        public double Distancia { get; set; }
        public double Precio { get; set; }   
        //Declaración del constructor vacio
        public Reserva()
        {
            Pizzas = new List<Pizza>();
        }
        //Declaración del método que realiza el calculo del precio
        public double CalcularPrecio()
        {
            double suma = 0.0;
            for (int i = 0; i<Pizzas.Count;i++)
            {
                suma = suma + Pizzas[i].Type.Precio;
            }
            return suma+Precio;
        }
        //Método que realiza el calculo del tiempo
        public double CalcularTiempo()
        {
            double suma = 0.0;
            for (int i = 0; i < Pizzas.Count; i++)
            {
                suma = suma + Pizzas[i].Tiempo;
            }
            return suma;
        }
        //Método que realiza la impresión de la reserva realizada
        public void MostrarReserva()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine($"Hora de pedido: {Hora} horas\n" +
                $"Latitud: {Posicion.Latitud} \n" +
                $"Longitud: {Posicion.Longitud} \n" +
                $"Precio: ${CalcularPrecio()} \n" +
                $"Distancia {Distancia} Km \n" +
                $"Tiempo de entrega repartidor: {Distancia*3} minutos, tiempo de preparación: {CalcularTiempo()} minutos\n" +
                $"Total de Pizzas: {Pizzas.Count}");
            MostrarPizzas(Pizzas);
        }
        //Método que realizar la impresión de la pizzas seleccionadas
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