namespace UnidadDosA1
{
    //Declaración de la clase CuentaAhorro
    class CuentaAhorro : CuentaBancaria
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public string FechaAhorro { get; set; }
        public double GananciaMensual { get; set; }
        //Declaración de constructor con atributos
        public CuentaAhorro(string fechaAhorro, double ganaciaMensual, int numero, double saldo, string tipo)
            :base(numero,saldo,tipo)
        {
            FechaAhorro = fechaAhorro;
            GananciaMensual= ganaciaMensual;
        }
        //Método que realiza la suma del saldo con la ganancia mensual de la cuenta
        public double Beneficios()
        {
            return Saldo + GananciaMensual;
        }
        public override string MostrarInformacion()
        {
            base.MostrarInformacion();
            string info = $"{base.MostrarInformacion()} \n" +
                $"Fecha Ahorro: {FechaAhorro} \n" +
                $"Ganancia Mensual: {GananciaMensual}";
            return info;
        }
    }
}