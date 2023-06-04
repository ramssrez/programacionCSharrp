namespace UnidadTresEA
{
    public abstract class EntidadMetaverso
    {
        public int ID { get; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public static int contador = 1;
        public abstract string Interactuar();
        public EntidadMetaverso()
        {
            ID = contador;
            contador++;
        }
        public virtual string DatosEntidad()
        {
            return $"Entidad número: {ID} \n" +
                    $"Nombre: {Nombre}\n" +
                    $"Descripción: {Descripcion}";
        }
    }
}