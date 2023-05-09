namespace UnidadDosA1
{
    public class Coaxial : Dron
    {
        public string Tipo { get; set; }
        public double CapacidadCarga { get; set; }
        public Coaxial(string tipo, double capacidadCarga, int numeroBrazos, double peso, string energiaImpacto, double velocidadVuelo, Dimension dimension)
            : base(numeroBrazos, peso, energiaImpacto, velocidadVuelo, dimension)
        {
            Tipo = tipo;
            CapacidadCarga = capacidadCarga;
        }
        public string TransportarCarga()
        {
            return $"El peso que puede transportar es menor a {CapacidadCarga} [kg]";
        }
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                $"Tipo: {Tipo}\n" +
                $"Capacidad de carga Máxima: {CapacidadCarga} [kg]";
        }
    }
}