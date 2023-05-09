namespace UnidadDosA1
{
    class StringProyect
    {
        //Atributos de la clase que contiene los strings a utilizar en el proyecto
        public const string STRING_FORMATO = "**********************************************************************************************";
        public const string BIENVENIDO = "Bienvenidos al sistema de selección y alta de drones";
        public const string SALIR = "Has elegido salir de la aplicación";
        public const string RANGO_OPCIONES = "Elige una opcion entre 1 y 5";
        public const string OPCION_MENU = "Ingresa una opción del menú: ";
        public const string NO_SELECCION_IRIS = "No se ha ingresado los datos de la iris uno u iris dos";
        public const string ERROR_INGRESAR_NUMERO = "Error al ingresa el número, vuelve a intentarlo";
        public const string ERROR_NUMERO_GRANDE = "Número demasiado grande, intenta con otro número";
        public const string ERROR_INGRESAR_STRING_VACIO = "El string se encuentra vacío, vuelve a intentarlo";
        public const string ERROR_INGRESAR_STRING_VACIO_ESPACIOS = "Ingresa un string sin espacios";
        public const string ERROR_INGRESAR_STRING_GRANDE = "Error al ingresar el texto, vuelve a intentarlo";
        
        public const string OPCIONES_MENU = "1. Seleccionar drones tipo Tricóptero. \n2. Seleccionar drones tipo Cuadricóptero.\n3. Seleccionar drones tipo Hexacóptero\n4. Seleccionar drones tipo Coaxial\n5. Salir";
        public const string TRICOPTERO = "Tricóptero";
        public const string CUADRICOPTERO = "Cuadricóptero";
        public const string HEXACOPTERO = "Hexacóptero";
        public const string COAXIAL = "Coaxial";
        public const string OPCIONES_MENU_SECUNDARIO = "1. Crear un nuevo dron Tricóptero. \n2. Seleccionar un dron de la lista.\n3. Salir";
        public const string STRING_MENU_SECUNDARIO = "Selección una opción del menú secundario";
        public const string RANGO_OPCIONES_DOS = "Elige una opcion entre 1 y 3";
        public const string SALIR_MENU_SECUNDARIO = "Retornando al menú principal...";
        /*
        public const string TEXTURA = "Ingresa la textura de la iris: ";
        public const string FORMA = "Ingresa la forma de la iris: ";
        public const string COLOR = "Ingresa el color de la iris: ";
        public const string INTENSIDAD = "Ingresa la intensidad de la iris: ";
        public const string PATRON = "Ingresa el patron de la iris: ";
        public const string CURVATURA = "Ingresar la curvatura de la iris: ";
        public const string OTROS = "Ingresa si la iris tiene manchas o cicatrices: ";
        public const string OPCIONES_IRIS = "1. Iris Uno\n2. Iris dos";
        public const string OPCIONES_ENVEJECIMIENTO = "1. Intensidad del color\n2. Cambiar forma del iris (curvatura)\n3. Añadir manchas y cicatrices";
        public const string NO_OPCION_MENU = "No es una opción del menú";
        public const string SELECCION_IRIS = "Selecciona una iris de la lista: ";
        public const string RANGO_OPCIONES_SUBMENU = "Elige una opcion entre 1 y 3";
        public const string NO_SELECCION_SUBMENU = "No se ha selecciono una opción del menú";
        public const string INGRESO_INTENSIDAD = "Ingresa la intensidad del color del iris: ";
        public const string INGRESO_CURVATURA = "Ingresa la curvatura del iris: ";
        public const string INGRESO_OTRO = "Ingresa la cicatriz o mancha del iris: ";
        */
        //Método que concatena la opción del menú seleccionado
        public static string OpcionMenu(int valor)
        {
            return string.Format("Has elegido la opción {0}", valor);
        }
    }
}