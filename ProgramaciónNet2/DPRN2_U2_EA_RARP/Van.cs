namespace UnidadDosEA
{
    class Van : Vehiculo
    {
        public string Tipo { get; set; }
        public Van()
        {
            base.ModuloPanelSolar = 8;
            base.BateriaRegulacion = 14;
            base.SistemaCableado = 4;
            base.ModuloCarga = 3;
            base.Motores = 3;
            Tipo = "Van";
        }
        public new string DatosVehiculo()
        {
            string info = $"Tipo: {Tipo} \n" + base.DatosVehiculo();
            return info;
        }
    }
}