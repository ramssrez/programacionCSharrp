namespace UnidadUnoA1
{
    //Delclaración de la clase StringProyect
    public class StringProyect
    {
        //Atributos de la clase que contiene los strings a utilizar en el proyecto
        public const string STRING_FORMATO = "**********************************************************************************************";
        public const string BIENVENIDO = "Bienvenidos al sistema de cartas de YuGi-Oh";
        public const string SALIR = "Has elegido salir de la aplicación";
        public const string RANGO_OPCIONES = "Elige una opcion entre 1 y 6";
        public const string OPCION_MENU = "Ingresa una opción del menú: ";
        public const string NO_SELECCION_PERSONAJE = "No se ha seleccionado la carta";
        public const string SELECCION_CARTA = "Selecciona una carta de YuGi-Oh";
        public const string ERROR_INGRESAR_NUMERO = "Error al ingresa valor, vuelve a intentarlo";
        public const string ERROR_NUMERO_GRANDE = "Número demasiado grande, intenta con otro número";
        public const string OPCIONES_MENU = "1. Mostrar información de las cartas \n2. Seleccionar carta\n3. Mostrar defensa del monstruo\n4. Mostrar ataque del monstruo\n5. Posicionar carta ATK/DEF\n6. Salir";
        public const string OPCIONES_ATAQUE_DEFENSA = "1. Pocisionar la carta en ataque (ATK)\n2. Posicionar la carta en defensa (DEF)";
        public const string NO_OPCION_MENU = "No es una opción del menú";
        //Método que concatena la opción del menú seleccionado
        public static string OpcionMenu(int valor)
        {
            return string.Format("Has elegido la opción {0}", valor);
        }
        //Método que concatena el monstruo seleccionado
        public static string SeleccionMonstruo(string valor)
        {
            return string.Format("Has elegido al monstruo: {0}", valor);
        }
    }
}