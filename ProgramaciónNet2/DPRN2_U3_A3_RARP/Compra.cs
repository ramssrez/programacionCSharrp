namespace UnidadTresA3
{
    //Declaración de la clase Compra
    class Compra
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public MonedaVirtual Moneda { get; set; }
        public double MonedasComprada { get; set; }
        public double Inversion { get; set; }
        public Compra()
        {

        }
        //Método que realiza la compra de la moneda seleccionada
        public void RealizarCompra(MonedaVirtual moneda, double monedasCompradas, double inversion)
        {
            Moneda = moneda;
            MonedasComprada = monedasCompradas;
            Inversion = inversion;
        }
    }
}