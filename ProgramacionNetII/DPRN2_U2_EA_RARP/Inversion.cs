namespace UnidadDosEA
{
    public class Inversion : Cuenta
    {
        public string FechaInversion { get; set; }
        public string TipoInversion { get; set;}
        public Inversion(string tipoCuenta, double saldo, string fechaInversion, string tipoInversion)
        {
            //NumeroCuenta = numeroCuenta;
            TipoCuenta = tipoCuenta;
            Saldo = saldo;
            FechaInversion = fechaInversion;
            TipoInversion = tipoInversion;
        }
        public override double CalcularIntereses(double interes)
        {
            return Saldo=+interes;
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