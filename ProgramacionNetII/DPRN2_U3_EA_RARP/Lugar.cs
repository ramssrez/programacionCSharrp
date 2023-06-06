namespace UnidadTresEA
{
    //Declaración de la clase Lugar con sus atributos necesarios
    public class Lugar : EntidadMetaverso
    {
        //Declaración de las variables y métodos  getter y setter del objeto Tipo
        public string Ubicacion { get; set; }
        //Declaración del constructor con parametros de entrada
        public Lugar(string nombre, string descripcion, string tipoObjeto,string ubicacion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            TipoObjeto = tipoObjeto;
            Ubicacion = ubicacion;
        }
        //Método heredado que simula la interacción con el usuario
        public override string Interactuar()
        {
            return $"Estas interactuando en la ubicación {Nombre} en {Ubicacion}";
        }
        //Método que imprime la información de los datos de la entidad
        public override string DatosEntidad()
        {
            return $"{base.DatosEntidad()}\n" +
                    $"Ubicación: {Ubicacion}";
        }
    }
}