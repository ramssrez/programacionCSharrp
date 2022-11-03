namespace UnidadDosA1
{
    //Declaración de la clase CuentaBancaria
    class CuentaBancaria
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public string Tipo { get; set;}
        //Declaración de constructor con atributos
        public CuentaBancaria(int numero, double saldo, string tipo)
        {
            Numero = numero;
            Saldo = saldo;
            Tipo = tipo;
        }
        //Método que muesta el motivo por el cual se ha cerrado una cuenta
        public string CerrarCuenta(int entero)
        {
            string info = string.Empty;
            if (entero == 1)
            {
                info = "Sobregiro";
            } else if (entero == 2)
            {
                info = "Indicación del cuenta ambiente";
            }else if (entero == 3)
            {
                info = "Defunción del cuenta ambiente";
            }
            return info;
        }
        //Método que muestra la información de la cuenta bancaria
        public virtual string MostrarInformacion()
        {
            string info = $"Número: {Numero}\n" +
                $"Saldo: ${Saldo} \n" +
                $"Tipo: {Tipo}";
            return info;
        }
    }
}