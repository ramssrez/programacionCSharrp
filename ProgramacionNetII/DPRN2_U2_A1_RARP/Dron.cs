namespace UnidadDosA1
{
    //Declaración de la clase Dron con sus atributos necesarios
    public class Dron
    {
        //Declaración de las variables, métodos  getter y setter del objeto Dron
        public int NumeroSerie { get; }
        public int NumeroBrazos { get; set; }
        public double Peso { get; set; }
        public string EnergiaImpacto { get; set; }
        public double VelocidadVuelo { get; set; }
        //public string Dimension { get; set; }
        public Dimension Dimension { get; set; }
        //Declaración del constructor vacio de la clase
        public Dron()
        {
            
        }
        //Declaración del constructor con parametros de entrada
        public Dron(int numeroSerie, int numeroBrazos, double peso, string energiaImpacto, double velocidadVuelo, Dimension dimension)
        {
            NumeroSerie = numeroSerie;
            NumeroBrazos = numeroBrazos;
            Peso = peso;
            EnergiaImpacto = energiaImpacto;
            VelocidadVuelo = velocidadVuelo;
            Dimension = dimension;
        }
        public Dron(int numeroBrazos, double peso, string energiaImpacto, double velocidadVuelo, Dimension dimension)
        {
            NumeroBrazos = numeroBrazos;
            Peso = peso;
            EnergiaImpacto = energiaImpacto;
            VelocidadVuelo = velocidadVuelo;
            Dimension = dimension;
        }
        //Método que imprime los atributos que componen al objeto
        public virtual string MostrarInformacion()
        {
            return $"Número de serie: {NumeroSerie} \n" +
                    $"Número de brazos: {NumeroBrazos} \n" +
                    $"Peso: {Peso} [kg]\n" +
                    $"Energía de Impacto: {EnergiaImpacto}\n" +
                    $"Velocidad de Vuelo: {VelocidadVuelo} m/s\n" +
                    $"Dimensión: {Dimension.Altura}x{Dimension.Ancho}x{Dimension.BaseDron} [cm]";
        }
    }
}