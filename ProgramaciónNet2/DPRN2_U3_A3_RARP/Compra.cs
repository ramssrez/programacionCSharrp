namespace UnidadTresA3
{
    class Compra
    {
        public MonedaVirtual Moneda { get; set; }
        public double MonedasComprada { get; set; }
        public double Inversion { get; set; }
        public Compra()
        {

        }
        public void RealizarCompra(MonedaVirtual moneda, double monedasCompradas, double inversion)
        {
            Moneda = moneda;
            MonedasComprada = monedasCompradas;
            Inversion = inversion;
        }
    }
}