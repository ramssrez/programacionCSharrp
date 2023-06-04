namespace UnidadDosEA
{
    //Declaración de la clase Cuentas con sus atributos necesarios
    public class Cuentas
    {
        //Declaración de las variables y métodos  getter y setter del objeto Cuentas
        public List<CuentaMaestra> MaestraList { get; set; }
        public List<Inversion> InversionList { get; set; }
        //Declaración de constructor de la clase para asignar las listas de los objetos
        public Cuentas()
        {
            MaestraList = CuentasMaestras();
            InversionList = CuentasInversion();
        }
        //Método que crea una lista de cuentas maestras
        private List<CuentaMaestra> CuentasMaestras()
        {
            return new List<CuentaMaestra>() { new CuentaMaestra("Maestra", 1000, 10), new CuentaMaestra("Maestra", 500, 5) };
        }
        //Método que crea una lista de cuentas de inversión
        private List<Inversion> CuentasInversion()
        {
            return new List<Inversion>() { new Inversion("Inversion", 1000, "20/05/2023", "Corto"), new Inversion("Inversion", 500, "21/05/2023", "Largo") };
        }
    }
}