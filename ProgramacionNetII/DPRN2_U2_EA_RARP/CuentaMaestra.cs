namespace UnidadDosEA
{
    //Declaración de la clase CuentaMaestra con sus atributos necesarios
    public class CuentaMaestra : Cuenta
    {
        //Declaración de las variables y métodos  getter y setter del objeto CuentaMaestra
        public double Comision { get; set; }
        //Declaración de constructor con parametros de entrada
        public CuentaMaestra(string tipoCuenta, double saldo, double comision)
        {
            TipoCuenta = tipoCuenta;
            Saldo = saldo;
            Comision = comision;
        }
        //Método para calcular el interes de la cuenta
        public override double CalcularIntereses(double interes)
        {
            Saldo = Saldo - interes - Comision;
            return Saldo;
        }
        // Métodos polimórficos para cerrar la cuenta
        public string CerrarCuenta(string motivo)
        {
            return $"Saldo actual: ${Saldo}\n" +
                $"Motivo de la cancelación: {motivo}";
        }
        public string CerrarCuenta(int motivo)
        {
            string mensaje = "";
            switch (motivo)
            {
                case 1:
                    mensaje = "Fallecimiento del titular";
                    break;
                case 2:
                    mensaje = "Cancelación por el titular";
                    break;
                case 3:
                    mensaje = "Cancelación por el banco";
                    break;
                case 4:
                    mensaje = "Motivo desconocido";
                    break;
            }
            return $"Saldo actual: ${Saldo}\n" +
                $"Motivo de la cancelación: {mensaje}";
        }
        //Método que imprime los atributos que componen al objeto
        public override string MostrarInformacion()
        {
            return $"{base.MostrarInformacion()}\n" +
                    $"Comisión: ${Comision}";
        }
    }
}