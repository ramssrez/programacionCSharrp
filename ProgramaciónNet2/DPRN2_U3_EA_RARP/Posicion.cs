namespace UnidadTresEA
{
    class Posicion
    {
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public Posicion(float latitud, float longitud)
        {
            Latitud = latitud;
            Longitud = longitud;
        }
    }
}