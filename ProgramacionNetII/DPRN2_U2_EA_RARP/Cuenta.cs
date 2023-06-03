namespace UnidadDosEA
{
    public abstract class Cuenta
    {
        public int NumeroCuenta { get; }
        public string TipoCuenta { get; set; }
        public double Saldo { get; set; }
        private static int Contador = 1;
        public Cuenta()
        {
            NumeroCuenta = Contador;
            Contador++;
        }
        public virtual double CalcularIntereses(double interes)
        {
            return Saldo+=interes;
        }
        //Método que imprime los atributos que componen al objeto
        public virtual string MostrarInformacion()
        {
            return $"Datos de la cuenta: \n" +
                    $"Número de cuenta: {NumeroCuenta}\n" +
                    $"Tipo de cuenta: {TipoCuenta}\n" +
                    $"Saldo: ${Saldo}";
        }
    }
}