namespace UnidadDosA1
{
    //Declaración de la clase CuetasBancarias
    class CuentasBancarias
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public List<CuentaCorriente> CuentaCorrientes { get; set; }
        public List<CuentaAhorro> CuentaAhorros { get; set; }
        //Declaración de constructor de la clase
        public CuentasBancarias()
        {
            CuentaCorrientes = new List<CuentaCorriente>();
            CuentaAhorros = new List<CuentaAhorro>();
            CuentaAhorros.AddRange(CuentasAhorros());
            CuentaCorrientes.AddRange(CuentasCorrientes());
        }
        //Método que crea una lista de cuentas de ahorro con sus respectivos atributos
        private List<CuentaAhorro> CuentasAhorros()
        {
            List<CuentaAhorro> cuentaAhorros = new List<CuentaAhorro>();
            CuentaAhorro cuentaAhorro = new("15/10/2022", 15.0, 4, 1500.0, "Cuenta de ahorro");
            CuentaAhorro cuentaAhorroUno = new("01/11/2022", 20.0, 5, 2000.0, "Cuenta de ahorro");
            CuentaAhorro cuentaAhorroDos = new("01/11/2022", 5.0, 6, 1000.0, "Cuenta de ahorro");
            cuentaAhorros.Add(cuentaAhorro);
            cuentaAhorros.Add(cuentaAhorroUno);
            cuentaAhorros.Add(cuentaAhorroDos);
            return cuentaAhorros;
        } 
        //Método que crea una lista de cuentas corrientes con sus respectivos atricutos 
        private List<CuentaCorriente> CuentasCorrientes()
        {
            List<CuentaCorriente> cuentaCorrientes = new List<CuentaCorriente>();
            CuentaCorriente cuentaCorriente = new("17/10/2022", 50.0, 1, 6000.0, "Cuenta corriente");
            CuentaCorriente cuentaCorrienteUno = new("18/10/2022", 70.0, 2, 7000.0, "Cuenta corriente");
            CuentaCorriente cuentaCorrienteDos = new("19/10/2022", 80.0, 3, 8000.0, "Cuenta corriente");
            cuentaCorrientes.Add(cuentaCorriente);
            cuentaCorrientes.Add(cuentaCorrienteUno);
            cuentaCorrientes.Add(cuentaCorrienteDos);
            return cuentaCorrientes;
        }
    }
}