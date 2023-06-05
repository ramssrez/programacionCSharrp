namespace UnidadTresEA
{
    public class Lugar : EntidadMetaverso
    {
        public string Ubicacion { get; set; }
        public Lugar(string nombre, string descripcion, string ubicacion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Ubicacion = ubicacion;
        }
        public override string Interactuar()
        {
            return $"Estas interactuando en la ubicación {Nombre} en {Ubicacion}";
        }
        public override string DatosEntidad()
        {
            return $"{base.DatosEntidad()}\n" +
                    $"Ubicación: {Ubicacion}";
        }
    }
}