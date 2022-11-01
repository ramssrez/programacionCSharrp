namespace UnidadDosEA
{
    class Auto : Vehiculo
    {
        public string Tipo { get; set; }
        public Auto()
        {
            base.ModuloPanelSolar = 6;
            base.BateriaRegulacion = 9;
            base.SistemaCableado = 2;
            base.ModuloCarga = 1;
            base.Motores = 2;
            Tipo = "Auto";
        }
        public new string DatosVehiculo()
        {
            string info = $"Tipo : {Tipo} \n" + base.DatosVehiculo();
            return info;
        }
    }
}