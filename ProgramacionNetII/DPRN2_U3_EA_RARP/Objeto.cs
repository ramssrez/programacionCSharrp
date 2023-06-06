namespace UnidadTresEA
{
    //Declaración de la clase Objeto con sus atributos necesarios
    public class Objeto : EntidadMetaverso
    {
        //Declaración de las variables y métodos  getter y setter del objeto Tipo
        public string Tipo { get; set; }
        //Declaración del constructor con parametros de entrada
        public Objeto(string nombre, string descripcion, string tipoObjeto,string tipo)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            TipoObjeto = tipoObjeto;
            Tipo = tipo;
        }
        //Método heredado que simula la interacción con el usuario
        public override string Interactuar()
        {
            return $"Estas interactuando con el objeto {Nombre}";
        }
        //Método que imprime la información de los datos de la entidad
        public override string DatosEntidad()
        {
            return $"{base.DatosEntidad()}\n" +
                    $"Tipo: {Tipo}";
        }
    }
}