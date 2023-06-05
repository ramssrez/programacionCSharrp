namespace UnidadTresEA
{
    public class Objeto : EntidadMetaverso
    {
        public string Tipo { get; set; }
        public Objeto(string nombre, string descripcion, string tipoObjeto,string tipo)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            TipoObjeto = tipoObjeto;
            Tipo = tipo;
        }

        public override string Interactuar()
        {
            return $"Estas interactuando con el objeto {Nombre}";
        }
        public override string DatosEntidad()
        {
            return $"{base.DatosEntidad()}\n" +
                    $"Tipo: {Tipo}";
        }
    }
}