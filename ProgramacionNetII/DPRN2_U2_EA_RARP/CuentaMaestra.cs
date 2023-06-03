namespace UnidadDosEA
{
    public class CuentaMaestra : Cuenta
    {
        public double Comision { get; set; }
        public CuentaMaestra(string tipoCuenta, double saldo, double comision)
        {
            TipoCuenta = tipoCuenta;
            Saldo = saldo;
            Comision = comision;
        }
        public override double CalcularIntereses(double interes)
        {
            Saldo = Saldo - interes - Comision;
            return Saldo;
        }
        // Métodos polimórficos para cerrar la cuenta
        public void CerrarCuenta(string motivo)
        {
            Console.WriteLine("Saldo actual: {0}", Saldo);
            Console.WriteLine("Motivo de la cancelación: {0}", motivo);
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
                default:
                    mensaje = "Motivo desconocido";
                    break;
            }
            //Console.WriteLine($"Saldo actual: {Saldo}");
            //Console.WriteLine($"Motivo de la cancelación: {mensaje}");
            return $"Saldo actual: {Saldo}\n" +
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