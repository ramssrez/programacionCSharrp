namespace UnidadDosA1
{
    //Declaración de la clase Hexacoptero con sus atributos necesarios
    public class Hexacoptero : Dron
    {
        //Declaración de las variables, métodos  getter y setter del objeto Hexacoptero
        public string Tipo { get; set; }
        public double ResolucionCamara { get; set; }
        //Declaración del constructor con parametros de entrada
        public Hexacoptero(string tipo, int resolucionCamara, int numeroBrazos, double peso, double energiaImpacto, double velocidadVuelo, Dimension dimension)
            :base(numeroBrazos, peso, energiaImpacto, velocidadVuelo, dimension)
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
        //Método que imprime los atributos que componen al objeto
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                $"Tipo: {Tipo}\n" +
                $"Resolución de cámara: {ResolucionCamara} [px]";
        }
    }
}