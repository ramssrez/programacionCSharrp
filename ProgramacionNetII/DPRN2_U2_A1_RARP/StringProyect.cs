namespace UnidadDosA1
{
    class StringProyect
    {
        //Atributos de la clase que contiene los strings a utilizar en el proyecto
        public const string STRING_FORMATO = "**********************************************************************************************";
        public const string BIENVENIDO = "Bienvenidos al sistema de selección y alta de drones";
        public const string SALIR = "Has elegido salir de la aplicación";
        public const string OPCION_MENU = "Ingresa una opción del menú: ";

        public const string ERROR_INGRESAR_NUMERO = "Error al ingresa el número, vuelve a intentarlo";
        public const string ERROR_NUMERO_GRANDE = "Número demasiado grande, intenta con otro número";
        public const string ERROR_INGRESAR_STRING_VACIO = "El string se encuentra vacío, vuelve a intentarlo";
        public const string ERROR_INGRESAR_STRING_VACIO_ESPACIOS = "Ingresa un string sin espacios";
        public const string ERROR_INGRESAR_STRING_GRANDE = "Error al ingresar el texto, vuelve a intentarlo";

        public const string NO_SELECCION_DRON = "No se ha seleccionado una dron";
        public const string SELECCION_DRON = "Selecciona un dron: ";
        public const string SELECCION_DRON_LISTA = "Selecciona un dron de la lista";
        public const string OPCIONES_MENU = "1. Seleccionar drones tipo Tricóptero. \n2. Seleccionar drones tipo Cuadricóptero.\n3. Seleccionar drones tipo Hexacóptero\n4. Seleccionar drones tipo Coaxial\n5. Salir";
        public const string TRICOPTERO = "Tricóptero";
        public const string CUADRICOPTERO = "Cuadricóptero";
        public const string HEXACOPTERO = "Hexacóptero";
        public const string COAXIAL = "Coaxial";
        public const string OPCIONES_MENU_SECUNDARIO = "1. Crear un nuevo dron. \n2. Seleccionar un dron de la lista.\n3. Regresar....";
        public const string OPCIONES_MENU_SECUNDARIO_DRON = "1. Mostrar Información del dron. \n2. Modificar datos del dron.\n3. Regresar....";
        public const string OPCIONES_MENU_SECUNDARIO_DRON_DOS = "1. Mostrar Información del dron. \n2. Modificar datos del dron.\n3. Iniciar servomotor.\n4. Regresar....";
        public const string OPCIONES_MENU_SECUNDARIO_DRON_TRES = "1. Mostrar Información del dron. \n2. Modificar datos del dron.\n3. Iniciar grabación.\n4. Detener grabación.\n5. Regresar....";
        public const string OPCIONES_MENU_SECUNDARIO_DRON_CUATRO = "1. Mostrar Información del dron. \n2. Modificar datos del dron.\n3. Objeto transportados y carga máxima.\n4. Regresar....";

        public const string OPCIONES_MENU_DRON_UPDATE = "1. Modificar peso. \n2. Modificar velocidad de vuelo.\n3. Modificar energía de impacto.\n4. Modificar ancho.\n5. Modificar altura.\n6. Modificar base.\n7. Modificar potencia del motor.\n8. Regresar.....";
        public const string OPCIONES_MENU_DRON_UPDATE_DOS = "1. Modificar peso. \n2. Modificar velocidad de vuelo.\n3. Modificar energía de impacto.\n4. Modificar ancho.\n5. Modificar altura.\n6. Modificar base.\n7. Modificar altitud máxima del dron.\n8. Regresar....";
        public const string OPCIONES_MENU_DRON_UPDATE_TRES = "1. Modificar peso. \n2. Modificar velocidad de vuelo.\n3. Modificar energía de impacto.\n4. Modificar ancho.\n5. Modificar altura.\n6. Modificar base.\n7. Modificar resolución camara del dron.\n8. Regresar....";
        public const string OPCIONES_MENU_DRON_UPDATE_CUATRO = "1. Modificar peso. \n2. Modificar velocidad de vuelo.\n3. Modificar energía de impacto.\n4. Modificar ancho.\n5. Modificar altura.\n6. Modificar base.\n7. Modificar la capacidad de carga del dron.\n8. Regresar....";

        public const string SALIR_MENU_SECUNDARIO = "Retornando.......";
        public const string NUMERO_MAYOR_CERO = "El peso debe ser mayor a cero";
        public const string INGRESO_PESO_DRON = "Ingresa el peso del dron [kg]: ";
        public const string INGRESO_ENERGIA_IMPACTO = "Ingresa la energía de impacto [Julios]: ";
        public const string INGRESO_VELOCIDAD_DRON = "Ingresa la velocidad del dron [m/s]: ";
        public const string INGRESO_ANCHO_DRON = "Ingresa el ancho del dron [cm]: ";
        public const string INGRESO_ALTURA_DRON = "Ingresa la altura del dron [cm]: ";
        public const string INGRESO_BASE_DRON = "Ingresa la base del dron [cm]: ";
        public const string INGRESO_MOTOR_TRASERO_DRON = "Ingresa la potencia del motor trasero [W]: ";
        public const string INGRESO_ALTITUD_MAXIMA_DRON = "Ingresa la altitud de vuelo máximo [m]: ";
        public const string INGRESO_RESOLUCION_CAMARA_DRON = "Ingresa la resolucion de la camara [px]: ";
        public const string INGRESO_CAPACIDAD_CARGA_DRON = "Ingresa la capacidad de carga [kg]: ";

        public const string SUCCESS_PESO_DRON = "¡Se ha modificado el peso!";
        public const string SUCCESS_ENERGIA_IMPACTO = "¡Se ha modificado la energía de impacto del dron!";
        public const string SUCCESS_VELOCIDAD_DRON = "¡Se ha modificado la velocidad del dron!";
        public const string SUCCESS_ANCHO_DRON = "¡Se ha modificado el ancho del dron!";
        public const string SUCCESS_ALTURA_DRON = "¡Se ha modificado la altura del dron!";
        public const string SUCCESS_BASE_DRON = "¡Se ha modificado la base del dron!";
        public const string SUCCESS_MOTOR_TRASERO_DRON = "¡Se ha modificado la potencia del motor trasero del dron!";
        public const string SUCCESS_ALTITUD_MAXIMA_DRON = "¡Se ha modificado la altitud máxima del dron!";
        public const string SUCCESS_RESOLUCION_CAMARA_DRON = "¡Se ha modificado la resolución de la camara del dron!";
        public const string SUCCESS_CAPACIDAD_CARGA_DRON = "¡Se ha modificado la capacidad de carga del dron!";
        public const string CREANDO_DRON = "Creando un nuevo dron ......";
        //Método que concatena la opción del menú seleccionado
        public static string OpcionMenu(int valor)
        {
            return string.Format("Has elegido la opción {0}", valor);
        }
        public static string SeleccionDron(int valor)
        {
            return string.Format("Se ha seleccionado el dron con numero de serie: {0}", valor);
        }
        public static string SeleccionDron(string valor)
        {
            return string.Format("Drones {0}s", valor);
        }
        public static string SeleccionDronLista(int valor, string valorDos, int valorTres)
        {
            return string.Format("{0}. {1} # de serie: {2}", valor, valorDos, valorTres);
        }
        public static string SeleccionDronLista(int valor, string valorDos)
        {
            return string.Format("{1} # de serie: {0}", valor, valorDos);
        }
        public static string RangoOpciones(int v1, int v2)
        {
            return string.Format("Elige una opcion entre {0} y {1}", v1, v2);
        }
        public static string CreacionDron(int valor)
        {
            return string.Format("¡Se ha creado un nuevo dron con número de serie: {0}!", valor);
        }
    }
}