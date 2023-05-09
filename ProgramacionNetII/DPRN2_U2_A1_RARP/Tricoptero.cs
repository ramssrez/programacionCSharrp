namespace UnidadDosA1
{
    public class Tricoptero : Dron
    {
        public string Tipo { get; set; }
        public int PotenciaMotorTrasero { get; set; }
        public Tricoptero(string tipo, int potencia,int numeroSerie, int numeroBrazos, double peso, string energiaImpacto, double velocidadVuelo, Dimension dimension) :
            base(numeroSerie, numeroBrazos,peso,energiaImpacto,velocidadVuelo,dimension)
        {
            Tipo = tipo;
            PotenciaMotorTrasero = potencia;          
        }
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                $"Tipo: {Tipo}\n" +
                $"Potencia Motor Trasero: {PotenciaMotorTrasero} [HP]";
        }
    }
}