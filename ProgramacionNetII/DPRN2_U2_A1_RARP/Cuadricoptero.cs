namespace UnidadDosA1
{
    public class Cuadricoptero : Dron
    {
        public string Tipo { get; set; }
        public double AltitudVueloMaxima { get; set; }

        public Cuadricoptero(string tipo, double altitudVueloMaxima, int numeroBrazos, double peso, string energiaImpacto, double velocidadVuelo, Dimension dimension)
            : base(numeroBrazos, peso, energiaImpacto, velocidadVuelo, dimension)
        {
            Tipo = tipo;
            AltitudVueloMaxima = altitudVueloMaxima;
        }
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                $"Tipo: {Tipo}\n" +
                $"Altitud Vuelo Máxima: {AltitudVueloMaxima} [m]";
        }
    }
}