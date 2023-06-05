namespace UnidadTresEA
{
    public class Evento : EntidadMetaverso
    {
        public string Fecha { get; set; }
        public Lugar Lugar { get; set; }
        public string DescripcionDetallada { get; set; }
        public Evento(string nombre, string descripcion, string tipoObjeto,string fecha, Lugar lugar, string descripcionDetallada)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            TipoObjeto = tipoObjeto;
            Fecha = fecha;
            Lugar = lugar;
            DescripcionDetallada = descripcionDetallada;
        }
        public override string Interactuar()
        {
            return $"Haz entrado al evento especial de {Nombre} en la fecha {Fecha}";
        }
        public override string DatosEntidad()
        {
            return $"{base.DatosEntidad()}\n" +
                    $"Fecha: {Fecha}\n" +
                    $"Lugar: {Lugar.Nombre} en {Lugar.Ubicacion}\n" +
                    $"Descripción detallada: {DescripcionDetallada}";
        }
    }
}