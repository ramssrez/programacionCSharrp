namespace UnidadDosA1
{
    //Declaración de la clase Dron con sus atributos necesarios
    public class Dron
    {
        //Declaración de las variables, métodos  getter y setter del objeto Dron
        public int NumeroSerie { get; }
        public int NumeroBrazos { get; set; }
        public double Peso { get; set; }
        public double EnergiaImpacto { get; set; }
        public double VelocidadVuelo { get; set; }
        public Dimension Dimension { get; set; }
        private static int Contador = 1;
        //Declaración del constructor vacio de la clase
        public Dron()
        {
        }
        //Declaración del constructor con parametros de entrada
        public Dron(int numeroBrazos, double peso, double energiaImpacto, double velocidadVuelo, Dimension dimension)
        {
            NumeroSerie = Contador;
            NumeroBrazos = numeroBrazos;
            Peso = peso;
            EnergiaImpacto = energiaImpacto;
            VelocidadVuelo = velocidadVuelo;
            Dimension = dimension;
            Contador++;
        }
        //Método que imprime los atributos que componen al objeto
        public virtual string MostrarInformacion()
        {
            return $"Número de serie: {NumeroSerie} \n" +
                    $"Número de brazos: {NumeroBrazos} [brazos]\n" +
                    $"Peso: {Peso} [kg]\n" +
                    $"Energía de Impacto: {EnergiaImpacto} [Julios]\n" +
                    $"Velocidad de Vuelo: {VelocidadVuelo} [m/s]\n" +
                    $"Dimensión: {Dimension.Altura}x{Dimension.Ancho}x{Dimension.BaseDron} [cm]";
        }
    }
}