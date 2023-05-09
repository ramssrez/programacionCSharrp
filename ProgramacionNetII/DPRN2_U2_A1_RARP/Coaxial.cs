namespace UnidadDosA1
{
    //Declaración de la clase Coaxial con sus atributos necesarios
    public class Coaxial : Dron
    {
        //Declaración de las variables, métodos  getter y setter del objeto Coaxial
        public string Tipo { get; set; }
        public double CapacidadCarga { get; set; }
        //Declaración del constructor con parametros de entrada
        public Coaxial(string tipo, double capacidadCarga, int numeroBrazos, double peso, double energiaImpacto, double velocidadVuelo, Dimension dimension)
            : base(numeroBrazos, peso, energiaImpacto, velocidadVuelo, dimension)
        {
            Tipo = tipo;
            CapacidadCarga = capacidadCarga;
        }
        public string TransportarCarga()
        {
            return $"El peso que puede transportar es menor a {CapacidadCarga} [kg]";
        }
        //Método que imprime los atributos que componen al objeto
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                $"Tipo: {Tipo}\n" +
                $"Capacidad de carga Máxima: {CapacidadCarga} [kg]";
        }
    }
}