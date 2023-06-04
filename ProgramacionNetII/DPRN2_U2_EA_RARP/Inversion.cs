namespace UnidadDosEA
{
    //Declaración de la clase Inversion con sus atributos necesarios
    public class Inversion : Cuenta
    {
        //Declaración de las variables y métodos  getter y setter del objeto Inversión
        public string FechaInversion { get; set; }
        public string TipoInversion { get; set;}
        //Declaración de constructor con parametros de entrada
        public Inversion(string tipoCuenta, double saldo, string fechaInversion, string tipoInversion)
        {
            //NumeroCuenta = numeroCuenta;
            TipoCuenta = tipoCuenta;
            Saldo = saldo;
            FechaInversion = fechaInversion;
            TipoInversion = tipoInversion;
        }
        //Método para calcular el interes de la cuenta
        public override double CalcularIntereses(double interes)
        {
            Saldo = Saldo + interes;
            return Saldo;
        }
        //Método que imprime los atributos que componen al objeto
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                    $"Fecha Inversión: {FechaInversion}\n" +
                    $"Tipo Inversión: {TipoInversion} plazo";
        }
    }
}