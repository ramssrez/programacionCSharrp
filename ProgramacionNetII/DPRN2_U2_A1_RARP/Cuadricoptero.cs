namespace UnidadDosA1
{
    //Declaración de la clase Cuadricoptero con sus atributos necesarios
    public class Cuadricoptero : Dron
    {
        //Declaración de las variables, métodos  getter y setter del objeto Cuadricoptero
        public string Tipo { get; set; }
        public double AltitudVueloMaxima { get; set; }
        //Declaración del constructor con parametros de entrada
        public Cuadricoptero(string tipo, double altitudVueloMaxima, int numeroBrazos, double peso, double energiaImpacto, double velocidadVuelo, Dimension dimension)
            : base(numeroBrazos, peso, energiaImpacto, velocidadVuelo, dimension)
        {
            Tipo = tipo;
            AltitudVueloMaxima = altitudVueloMaxima;
        }
        //Método que imprime los atributos que componen al objeto
        public string IniciarServomotor()
        {
            return "Iniciando servomotor......\n\n" +
                $"¡Se ha establecido estabilidad en el vuelo! # de serie {NumeroSerie}";
        }
        //Método que imprime los atributos que componen al objeto
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                $"Tipo: {Tipo}\n" +
                $"Altitud Vuelo Máxima: {AltitudVueloMaxima} [m]";
        }
    }
}