namespace UnidadDosEA
{
    class Vehiculo
    {
        public int ModuloPanelSolar { get; set; }
        public int BateriaRegulacion { get; set; }
        public int SistemaCableado { get; set; }
        public int ModuloCarga { get; set; }
        public int Motores { get; set; }
        public Vehiculo()
        {
            
        }
        public Vehiculo(int moduloPanelsolar, int bateria, int cableado, int carga, int motor)
        {
            ModuloPanelSolar = moduloPanelsolar; 
            BateriaRegulacion = bateria;
            SistemaCableado = cableado;
            ModuloCarga = carga;
            Motores = motor;  
        }
        public string DatosVehiculo()
        {
            string info = $"Modulo Panel Solar: {ModuloPanelSolar} unidades\n" +
                $"Baterias de Regulación: {BateriaRegulacion} unidades\n" +
                $"Sistema de Cableado Eléctrico: {SistemaCableado} unidades\n" +
                $"Módulo de Carga: {ModuloCarga} unidades\n" +
                $"Motores: {Motores} unidades";
            return info;
        }
    }
}