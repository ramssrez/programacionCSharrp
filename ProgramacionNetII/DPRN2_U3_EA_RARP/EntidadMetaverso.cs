namespace UnidadTresEA
{
    //Declaración de la clase abstracta EntidadMetaverso con sus atributos necesarios
    public abstract class EntidadMetaverso
    {
        //Declaración de las variables y métodos  getter y setter del objeto Tipo
        public int ID { get; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string TipoObjeto { get; set; }
        public static int contador = 1;
        public abstract string Interactuar();
        //Declaración del constructor vacío
        public EntidadMetaverso()
        {
            ID = contador;
            contador++;
        }
        //Método que imprime la información de los datos de la entidad
        public virtual string DatosEntidad()
        {
            return $"Entidad número: {ID} \n" +
                    $"Nombre: {Nombre}\n" +
                    $"Descripción: {Descripcion}\n" +
                    $"Tipo: {TipoObjeto}";
        }
    }
}