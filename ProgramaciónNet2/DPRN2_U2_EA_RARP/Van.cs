namespace UnidadDosEA
{
    //Declaración de la clase Van que hereda de Vehiculo
    class Van : Vehiculo
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public string Tipo { get; set; }
        //Declaración de constructor con atributos
        public Van()
        {
            base.ModuloPanelSolar = 8;
            base.BateriaRegulacion = 14;
            base.SistemaCableado = 4;
            base.ModuloCarga = 3;
            base.Motores = 3;
            Tipo = "Van";
        }
        //Método que muestra la información de la Van
        public new string DatosVehiculo()
        {
            string info = $"Tipo: {Tipo} \n" + base.DatosVehiculo();
            return info;
        }
    }
}