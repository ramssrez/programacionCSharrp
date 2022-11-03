namespace UnidadDosEA
{
    //Declaración de la clase Camioneta que hereda de Vehiculo
    class Camioneta :Vehiculo
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public string Tipo { get; set; }
        //Declaración de constructor con atributos
        public Camioneta()
        {
            base.ModuloPanelSolar = 10;
            base.BateriaRegulacion = 15;
            base.SistemaCableado = 5;
            base.ModuloCarga = 3;
            base.Motores = 5;
            Tipo = "Camioneta";
        }
        //Método que muestra la información de la Camioneta
        public new string DatosVehiculo()
        {
            string info = $"Tipo: {Tipo} \n" + base.DatosVehiculo();
            return info;
        }
    }
}