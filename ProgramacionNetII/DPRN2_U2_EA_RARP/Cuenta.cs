namespace UnidadDosEA
{
    //Declaración de la clase abstracta Cuenta con sus atributos necesarios
    public abstract class Cuenta
    {
        //Declaración de las variables y métodos  getter y setter del objeto Cuenta
        public int NumeroCuenta { get; }
        public string TipoCuenta { get; set; }
        public double Saldo { get; set; }
        private static int Contador = 1;
        //Declaración del constructor vacío pero que genera el numero de cuenta
        public Cuenta()
        {
            NumeroCuenta = Contador;
            Contador++;
        }
        //Método que calcula el interes de la cuenta
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