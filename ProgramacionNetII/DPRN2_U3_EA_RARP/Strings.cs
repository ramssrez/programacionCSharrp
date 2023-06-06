namespace UnidadTresEA
{
    //Delclaración de la clase Strings
    public class Strings
    {
        //Atributos de la clase que contiene los strings a utilizar en el proyecto
        public const string STRING_FORMATO = "**********************************************************************************************";
        public const string BIENVENIDO = "Bienvenidos al metaverso, selecciona una opción para interactuar con cada una de las entidades";
        public const string OPCIONES_MENU = "1. Interacturar Personajes. \n2. Interactuar Objetos.\n3. Interactuar Lugares\n4. Interactuar Eventos\n5. Mostrar información de las entidades\n6. Salir";
        public const string SALIR = "Has elegido salir de la aplicación";
        public const string OPCION_MENU = "Ingresa una opción del menú: ";
        public const string OPCION_ENTIDAD = "Selecciona una entidad del metaverso: ";
        public const string LUGAR = "Lugar";
        public const string PERSONAJE = "Personaje";
        public const string EVENTO = "Evento";
        public const string OBJETO = "Objeto";

        //Errores
        public const string ERROR_INGRESAR_NUMERO = "Error al ingresa el número, vuelve a intentarlo";
        public const string ERROR_NUMERO_GRANDE = "Número demasiado grande, intenta con otro número";

        //Método que concatena la opción del menú seleccionado
        public static string OpcionMenu(int valor)
        {
            return string.Format("Has elegido la opción {0}", valor);
        }
        //Método que concatena las opciones que puede tener el menú
        public static string RangoOpciones(int v1, int v2)
        {
            return string.Format("Elige una opcion entre {0} y {1}", v1, v2);
        }
        //Método que concatena el tipo de interacción
        public static string NoInteraccion(string s)
        {
            return string.Format("No se ha realizado una interaccion con el {0}", s);
        }
    }
}