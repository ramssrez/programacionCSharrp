namespace UnidadDosEA
{
    class Produccion
    {
        public int CostoPanel { get; set; }
        public int CostoBateria { get; set; }
        public int CostoCableado { get; set; }
        public int CostoCarga { get; set; }
        public int CostoMotor { get; set; }
        public int CostoLaminado { get; set; }
        public Camioneta Camioneta { get; set; }
        public Auto Auto { get; set; }
        public Van Van { get; set; }
        public Produccion()
        {
            Van = CrearVan();
            Auto = CrearAuto();
            Camioneta = CrearCamioneta();
            CostoPanel = 1650;
            CostoBateria = 890;
            CostoCableado = 5890;
            CostoCarga = 2145;
            CostoMotor = 9874;
            CostoLaminado = 30000;
        }
        private Camioneta CrearCamioneta()
        {
            Camioneta camioneta = new();
            return camioneta;
        }
        private Auto CrearAuto()
        {
            Auto auto = new();
            return auto;
        }
        private Van CrearVan()
        {
            Van van = new();
            return van;
        }
        public int CostoAuto()
        {
            int suma = Auto.ModuloPanelSolar*CostoPanel + Auto.BateriaRegulacion*CostoBateria + Auto.SistemaCableado* CostoCableado
                + Auto.ModuloCarga*CostoCarga + Auto.Motores*CostoMotor + CostoLaminado;
            return suma; 
        }
        public int CostoCamioneta()
        {
            int suma = Camioneta.ModuloPanelSolar * CostoPanel + Camioneta.BateriaRegulacion * CostoBateria + Camioneta.SistemaCableado * CostoCableado
                + Camioneta.ModuloCarga * CostoCarga + Camioneta.Motores * CostoMotor + CostoLaminado;
            return suma;
        }
        public int CostoVan()
        {
            int suma = Van.ModuloPanelSolar * CostoPanel + Van.BateriaRegulacion * CostoBateria + Van.SistemaCableado * CostoCableado
                + Van.ModuloCarga * CostoCarga + Van.Motores * CostoMotor + CostoLaminado;
            return suma;
        }
        public string  Piezas(int presupuesto, int produccionAuto, int produccionCamioneta, int produccionVan, string mes)
        {
            string info;
            int costo = produccionAuto * CostoAuto() + produccionCamioneta * CostoCamioneta() + produccionVan * CostoVan();
            info = $"El presupuesto de {mes} es: ${presupuesto} \n" +
                $"Producción de autos: {produccionAuto} \n" +
                $"Producción de camionetas: {produccionCamioneta}\n" +
                $"Producción de vans: {produccionVan} \n" +
                $"Costo total ${costo} \n" +
                $"Ahorros del mes ${presupuesto-costo}";
            return info;
        }
    }
}