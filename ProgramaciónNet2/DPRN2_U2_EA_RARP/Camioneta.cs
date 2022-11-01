namespace UnidadDosEA
{
    class Camioneta :Vehiculo
    {
        public string Tipo { get; set; }
        public Camioneta()
        {
            base.ModuloPanelSolar = 10;
            base.BateriaRegulacion = 15;
            base.SistemaCableado = 5;
            base.ModuloCarga = 3;
            base.Motores = 5;
            Tipo = "Camioneta";
        }
        public new string DatosVehiculo()
        {
            string info = $"Tipo: {Tipo} \n" + base.DatosVehiculo();
            return info;
        }
    }
}