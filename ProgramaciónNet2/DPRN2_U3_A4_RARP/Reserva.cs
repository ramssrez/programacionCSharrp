namespace UnidadTresA4
{
    class Reserva
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tiempo { get; set; }
        public Inmueble Inmueble { get; set; }
        public static int contador = 1;
        public Reserva()
        {
        }
        public Reserva(string nombre, string apellido, string tiempo, Inmueble inmueble)
        {
            Nombre = nombre;
            Apellido = apellido;
            Tiempo = tiempo;
            Inmueble = inmueble;
            ID = contador++;
        }
        //Método que muestra la información de las mesas
        public string MostrarInformacion()
        {
            string info = $"ID reservación: {ID} \n" +
                $"Nombre: {Nombre} \n" +
                $"Apellido: {Apellido} \n" +
                $"Tiempo comida: {Tiempo} \n" +
                $"Tipo: {Inmueble.Tipo} \n" +
                $"Número de personas: {Inmueble.Espacios}";
            return info;
        }
    }
}