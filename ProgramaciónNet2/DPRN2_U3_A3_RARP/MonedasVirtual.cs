namespace UnidadTresA3
{
    //Declaración de la clase MonedasVirtual
    class MonedasVirtual
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public List<MonedaVirtual> Monedas { get; set; }
        //Declaración del constructor vacio de la clase pero que genera 10 monedas virtuales
        public MonedasVirtual()
        {
            Monedas = new List<MonedaVirtual>();
            MonedaVirtual monedaVirtual = new (1, "Bitcoin", "BTC", 18000.0, "11/11/2022");
            MonedaVirtual monedaVirtual1 = new(2, "Ethereum", "ETH", 1300.0, "11/11/2022");
            MonedaVirtual monedaVirtual2= new(3, "Tether", "USDT", 1.0, "11/11/2022");
            MonedaVirtual monedaVirtual3 = new(4, "BNB", "BNB", 319.19, "11/11/2022");
            MonedaVirtual monedaVirtual4 = new(5, "USD Coin", "USDC", 1.0, "11/11/2022");
            MonedaVirtual monedaVirtual5 = new(6, "Binance USD", "BUSD", 1.0, "11/11/2022");
            MonedaVirtual monedaVirtual6 = new(7, "XRP", "XRP", 0.4015, "11/11/2022");
            MonedaVirtual monedaVirtual7 = new(8, "Cardano", "ADA", 0.3687, "11/11/2022");
            MonedaVirtual monedaVirtual8 = new(9, "Dogecoin", "DOGE", 0.08713, "11/11/2022");
            MonedaVirtual monedaVirtual9 = new(10, "Polygon", "MATIC", 1.04, "11/11/2022");
            Monedas.Add(monedaVirtual);
            Monedas.Add(monedaVirtual1);
            Monedas.Add(monedaVirtual2);
            Monedas.Add(monedaVirtual3);
            Monedas.Add(monedaVirtual4);
            Monedas.Add(monedaVirtual5);
            Monedas.Add(monedaVirtual6);
            Monedas.Add(monedaVirtual7);
            Monedas.Add(monedaVirtual8);
            Monedas.Add(monedaVirtual9);
        }
        public void MostrarMonedas()
        {
            foreach (MonedaVirtual i in Monedas)
            {
                Console.WriteLine("**********************************************************************************************");
                Console.WriteLine(i.MostrarInformacion());
            }
        }
        //Método que muestra la información de las monedas virtuales
        public void MostrarMonedasPorID()
        {
            foreach (MonedaVirtual i in Monedas)
            {
                Console.WriteLine($"{i.Numero}.- {i.Nombre}");
            }
        }
    }
}