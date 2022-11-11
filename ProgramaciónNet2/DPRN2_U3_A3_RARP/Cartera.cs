namespace UnidadTresA3
{
    class Cartera
    {
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public double Presupuesto { get; set; }
        public double Inversion { get; set; }
        public List<MonedaVirtual> Monedas { get; set; }
        public Cartera()
        {
            Monedas = new List<MonedaVirtual>();
            Presupuesto = 0;

        }
        public void GuardarInformacion(MonedaVirtual moneda, double inversion)
        {
            Monedas.Add(moneda);
            Inversion = Inversion + inversion;
        }
        public void MostrarCarteraVitual()
        {
            foreach (MonedaVirtual i in Monedas)
            {
                Console.WriteLine("**********************************************************************************************");
                Console.WriteLine($"Id");
            }
        }
    }
}