namespace UnidadDosA1
{
    //Declaración de la clase CuentaCorriente
    class CuentaCorriente : CuentaBancaria
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public string FechaPago { get; set; }
        public double ComisionPago { get; set; }
        //Declaración de constructor con atributos
        public CuentaCorriente(string fechaPago, double comisionPago, int numero, double saldo, string tipo)
            : base(numero, saldo, tipo)
        {
            FechaPago = fechaPago;
            ComisionPago = comisionPago;
        }
        //Método que realiza la resta del salfo con la comisión de pago
        public double Comision()
        {
            return Saldo-ComisionPago;
        }
        public override string  MostrarInformacion()
        {
            base.MostrarInformacion();
            string info = $"{base.MostrarInformacion()} \n" +
                $"Fecha pago: {FechaPago} \n" +
                $"Comisión pago: { ComisionPago}";
            return info;
        }
    }
}