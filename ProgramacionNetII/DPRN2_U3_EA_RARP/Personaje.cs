namespace UnidadTresEA
{
    public class Personaje : EntidadMetaverso
    {
        public string Rol { get; set; }
        public Personaje(string nombre, string descripcion,string tipoObjeto, string rol)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            TipoObjeto = tipoObjeto;
            Rol = rol;
        }
        public override string Interactuar()
        {
            return $"{Nombre} te esta saludando, te esta invitando a codear un gran videojuego";
        }
        public override string DatosEntidad()
        {
            return $"{base.DatosEntidad()}\n" +
                    $"Rol: {Rol}";
        }
    }
}