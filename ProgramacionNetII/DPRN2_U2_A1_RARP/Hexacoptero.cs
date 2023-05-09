namespace UnidadDosA1
{
    public class Hexacoptero : Dron
    {
        public string Tipo { get; set; }
        public double ResolucionCamara { get; set; }
        public Hexacoptero(string tipo, int resolucionCamara, int numeroSerie, int numeroBrazos, double peso, string energiaImpacto, double velocidadVuelo, Dimension dimension)
            :base(numeroSerie, numeroBrazos, peso, energiaImpacto, velocidadVuelo, dimension)
        {
            Tipo = tipo;
            ResolucionCamara = resolucionCamara;
        }
        public string IniciarGrabacion()
        {
            return "El dron esta comenzando a grabar";
        }
        public string DetenerGrabacion()
        {
            return "El dron esta deteniendo la grabación";
        }
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                $"Tipo: {Tipo}\n" +
                $"Resolución de cámara: {ResolucionCamara} [px]";
        }
    }
}