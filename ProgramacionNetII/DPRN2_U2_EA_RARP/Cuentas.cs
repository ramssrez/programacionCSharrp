namespace UnidadDosEA
{
    public class Cuentas
    {
        public List<CuentaMaestra> MaestraList { get; set; }
        public List<Inversion> InversionList { get; set; }
        public Cuentas()
        {
            MaestraList = CuentasMaestras();
            InversionList = CuentasInversion();
        }
        private List<CuentaMaestra> CuentasMaestras()
        {
            return new List<CuentaMaestra>() { new CuentaMaestra("Maestra", 1000, 10), new CuentaMaestra("Maestra", 500, 5) };
        }

        private List<Inversion> CuentasInversion()
        {
            return new List<Inversion>() { new Inversion("Inversion", 1000, "20/05/2023", "Corto"), new Inversion("Inversion", 500, "21/05/2023", "Largo") };
        }
    }
}