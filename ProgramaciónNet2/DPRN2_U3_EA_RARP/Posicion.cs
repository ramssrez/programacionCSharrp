namespace UnidadTresEA
{
    //Declaración de la clase Posicion
    class Posicion
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        //Declaración del constructor con parametros
        public Posicion(float latitud, float longitud)
        {
            Latitud = latitud;
            Longitud = longitud;
        }
    }
}