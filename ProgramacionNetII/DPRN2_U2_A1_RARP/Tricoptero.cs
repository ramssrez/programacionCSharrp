namespace UnidadDosA1
{
    //Declaración de la clase Tricoptero con sus atributos necesarios
    public class Tricoptero : Dron
    {
        //Declaración de las variables, métodos  getter y setter del objeto Tricoptero
        public string Tipo { get; set; }
        public double PotenciaMotorTrasero { get; set; }
        //Declaración del constructor con parametros de entrada
        public Tricoptero(string tipo, double potencia, int numeroBrazos, double peso, double energiaImpacto, double velocidadVuelo, Dimension dimension) :
            base(numeroBrazos,peso,energiaImpacto,velocidadVuelo,dimension)
        {
            Tipo = tipo;
            PotenciaMotorTrasero = potencia;          
        }
        //Método que imprime los atributos que componen al objeto
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                $"Tipo: {Tipo}\n" +
                $"Potencia Motor Trasero: {PotenciaMotorTrasero} [W]";
        }
    }
}