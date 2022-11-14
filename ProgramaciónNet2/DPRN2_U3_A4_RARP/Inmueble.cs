namespace UnidadTresA4
{
    class Inmueble
    {
        public int ID { get; set; }
        public int TotalPersonas { get; set; }
        public int Espacios { get; set; }
        public bool IsOcupada { get; set; }
        public string Tipo { get; set; }
        public Inmueble()
        {

        }
        public Inmueble(int id,string tipo)
        {
            ID = id;
            Tipo = tipo;
            AsignarTipo();
        }
        public void AsignarTipo()
        {
            if (Tipo.Equals("Mesa"))
            {
                TotalPersonas = 4;
                Espacios = 4;
            }else if (Tipo.Equals("Sala"))
            {
                TotalPersonas = 8;
                Espacios = 8;
            }
        } 
        
        //Método que muestra la información de los inmuebles
        public string MostrarInformacion()
        {
            string info = $"Id: {ID} \n" +
                $"Total: {TotalPersonas} \n" +
                $"Espacios diponibles: {Espacios} \n" +
                $"Tipo: {Tipo} \n" +
                $"¿Esta ocupada?: {IsOcupada} \n";
            return info;
        }
    }
}