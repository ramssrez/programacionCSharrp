namespace UnidadTresEA
{
    public class UsuarioMetaverso
    {
        public string TipoMenbresia { get; set; }
        public int InteraccionesPermitidas { get; set; }
        public int interacciones = 0;
        public UsuarioMetaverso(string tipoMembresia)
        {
            TipoMenbresia = tipoMembresia;
        }
        public void RealizarInteraccion()
        {
            try
            {
                InteraccionesPermitidas = ObtenerLimiteInteracciones();
                if (interacciones >= InteraccionesPermitidas)
                {
                    throw new LimitesInteraccionException($"El usuario ha llegado a su límite de interacciones de {InteraccionesPermitidas}, regresa en 24 horas para volver a interactuar con el Metaverso");
                }
                interacciones++;
            } catch (LimitesInteraccionException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private int ObtenerLimiteInteracciones()
        {
            int tipo = 0;
            if (TipoMenbresia.Equals("Gratuita"))
            {
                tipo = 7;
            }else if (TipoMenbresia.Equals("Platino"))
            {
                tipo = 10;
            }else if (TipoMenbresia.Equals("Oro"))
            {
                tipo = int.MaxValue;
            }
            return tipo;
        }
    }
}