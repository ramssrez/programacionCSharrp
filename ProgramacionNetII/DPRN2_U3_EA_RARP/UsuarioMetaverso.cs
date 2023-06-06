namespace UnidadTresEA
{
    //Declaración de la clase UsuarioMetaverso con sus atributos necesarios
    public class UsuarioMetaverso
    {
        //Declaración de las variables y métodos  getter y setter del objeto Tipo
        public string TipoMenbresia { get; set; }
        public int InteraccionesPermitidas { get; set; }
        public int interacciones = 0;
        public bool PuedeInteractuar = true;
        //Declaración del constructor con parametros de entrada
        public UsuarioMetaverso(string tipoMembresia)
        {
            TipoMenbresia = tipoMembresia;
        }
        //Método que hace el conteo de las interacciones que hace el usuario con la entidad del metaverso
        public void RealizarInteraccion()
        {
            try
            {
                InteraccionesPermitidas = ObtenerLimiteInteracciones();
                if (interacciones >= InteraccionesPermitidas)
                {
                    PuedeInteractuar = false;
                    throw new LimitesInteraccionException($"El usuario ha llegado a su límite de interacciones de {InteraccionesPermitidas}, regresa en 24 horas para volver a interactuar con el Metaverso");
                }
                interacciones++;
            } catch (LimitesInteraccionException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //Método que asigna la cantidad de interacciones en función del tipo de membresia
        private int ObtenerLimiteInteracciones()
        {
            int tipo = 0;
            if (TipoMenbresia.Equals("Gratuita"))
            {
                tipo = 7;
            }else if (TipoMenbresia.Equals("Platino"))
            {
                tipo = 100;
            }else if (TipoMenbresia.Equals("Oro"))
            {
                tipo = int.MaxValue;
            }
            return tipo;
        }
    }
}