namespace UnidadTresEA
{
    //Declaración de la clase Evento con sus atributos necesarios
    public class Evento : EntidadMetaverso
    {
        //Declaración de las variables y métodos  getter y setter del objeto Tipo
        public string Fecha { get; set; }
        public Lugar Lugar { get; set; }
        public string DescripcionDetallada { get; set; }
        //Declaración del constructor con parametros de entrada
        public Evento(string nombre, string descripcion, string tipoObjeto,string fecha, Lugar lugar, string descripcionDetallada)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            TipoObjeto = tipoObjeto;
            Fecha = fecha;
            Lugar = lugar;
            DescripcionDetallada = descripcionDetallada;
        }
        //Método heredado que simula la interacción con el usuario
        public override string Interactuar()
        {
            return $"Haz entrado al evento especial de {Nombre} en la fecha {Fecha}";
        }
        //Método que imprime la información de los datos de la entidad
        public override string DatosEntidad()
        {
            return $"{base.DatosEntidad()}\n" +
                    $"Fecha: {Fecha}\n" +
                    $"Lugar: {Lugar.Nombre} en {Lugar.Ubicacion}\n" +
                    $"Descripción detallada: {DescripcionDetallada}";
        }
    }
}