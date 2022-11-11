namespace UnidadTresA3
{
    class Cartera
    {
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public Compra Compra { get; set; }
        //public List<double> Inversion { get; set; }
        //public List<MonedaVirtual> Monedas { get; set; }
        public List<Compra> Compras { get; set; }
        public Cartera()
        {
            //Monedas = new List<MonedaVirtual>();
            //Inversion = new List<double>();
            Compras = new List<Compra>();
            //Presupuesto = 0;
        }
        public void GuardarInformacion(MonedaVirtual moneda, double monedasCompradas,double inversion)
        {
            Compra = new Compra(moneda, monedasCompradas,inversion);
            Compras.Add(Compra);
            //Monedas.Add(moneda);
            //Inversion.Add(inversion);
        }
        private double InversionTotal()
        {
            double suma = 0.0;
            for (int i = 0; i < Compras.Count; i++)
            {
                suma = suma + Compras[i].Inversion;
            }
            return suma;
        }
        public void MostrarCarteraVitual()
        {
            Console.WriteLine("Monedas en la cartera: ");
            foreach (Compra i in Compras)
            {
                Console.WriteLine($"Id: {i.Moneda.ID}, Total: {i.MonedasComprada} monedas, Inversión: ${i.Inversion}");
            }
            Console.WriteLine($"Inversión total: ${InversionTotal()}");
        }
    }
}