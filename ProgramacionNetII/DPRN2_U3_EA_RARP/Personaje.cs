namespace UnidadTresEA
{
    //Declaración de la clase Personaje con sus atributos necesarios
    public class Personaje : EntidadMetaverso
    {
        //Declaración de las variables y métodos  getter y setter del objeto Tipo
        public string Rol { get; set; }
        //Declaración del constructor con parametros de entrada
        public Personaje(string nombre, string descripcion,string tipoObjeto, string rol)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            TipoObjeto = tipoObjeto;
            Rol = rol;
        }
        //Método heredado que simula la interacción con el usuario
        public override string Interactuar()
        {
            return $"{Nombre} te esta saludando, te esta invitando a codear un gran videojuego";
        }
        //Método que imprime la información de los datos de la entidad
        public override string DatosEntidad()
        {
            return $"{base.DatosEntidad()}\n" +
                    $"Rol: {Rol}";
        }
    }
}