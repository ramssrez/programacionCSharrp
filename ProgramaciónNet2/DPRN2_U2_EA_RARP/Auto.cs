namespace UnidadDosEA
{
    //Declaración de la clase Auto que hereda de Vehiculo
    class Auto : Vehiculo
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public string Tipo { get; set; }
        //Declaración de constructor con atributos
        public Auto()
        {
            base.ModuloPanelSolar = 6;
            base.BateriaRegulacion = 9;
            base.SistemaCableado = 2;
            base.ModuloCarga = 1;
            base.Motores = 2;
            Tipo = "Auto";
        }
        //Método que muestra la información del Auto
        public new string DatosVehiculo()
        {
            string info = $"Tipo: {Tipo} \n" + base.DatosVehiculo();
            return info;
        }
    }
}