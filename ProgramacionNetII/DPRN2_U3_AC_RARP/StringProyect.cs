namespace UnidadTresAC
{
    //Delclaración de la clase StringProyect
    public class StringProyect
    {
        public const string STRING_FORMATO = "**********************************************************************************************";
        public const string BIENVENIDO = "Bienvenidos al sistema de becas de Harvard";
        public const string OPCIONES_MENU = "1. Dar de alta una nueva beca. \n2. Eliminar una beca.\n3. Consultar becas por país\n4. Obtener resumen de becas disponibles\n5. Mostrar todas las becas actuales\n6. Salir";
        public const string OPCIONES_MENU_DOS = "1. Beca Academica. \n2. Beca Deportiva.\n3. Regresar....";
        public const string NUMERO_MAYOR_CERO = "El número debe ser mayor a cero";
        public const string OPCION_MENU = "Ingresa una opción del menú: ";
        public const string OPCION_SUBMENU = "Selecciona el tipo de beca: ";
        public const string SALIR = "Has elegido salir de la aplicación";
        public const string DATOS_BECA = "Ingresa los datos de la beca";
        public const string INGRESO_PAIS = "Ingresa el país del procedencia: ";
        public const string INGRESO_ID = "Ingresa el valor del Id de la beca: ";
        public const string INGRESO_UNIVERSIDAD = "Ingresa la universidad de procedencia: ";
        public const string INGRESO_DEPORTE = "Ingresa el nombre del deporte para la beca: ";
        public const string INGRESO_MONTO = "Ingresa el monto de la beca: $";
        public const string INGRESO_IDS = "Ingrese el ID de la beca a eliminar (separe los IDs por coma si desea eliminar varias):";
        public const string EXITO_BECA = "Se Ha agregado la beca con éxito";
        public const string RETORNO = "Retornando......";
        public const string DEPORTIVA = "Deportiva";
        public const string ACADEMICA = "Académica";

        //Errores
        public const string ERROR_INGRESAR_NUMERO = "Error al ingresa el número, vuelve a intentarlo";
        public const string ERROR_NUMERO_GRANDE = "Número demasiado grande, intenta con otro número";
        public const string ERROR_STRING = "Error al ingresar el texto, vuelve a intentarlo";
        public const string ERROR_STRING_ESPACIOS = "Ingresa un string sin espacios";
        public const string ERROR_STRING_EMPTY = "El string se encuentra vacío, vuelve a intentarlo";
        public const string ERROR_READ_CSV = "Error al leer el archivo CSV";
        public const string ERROR_UPDATE_CSV = "Error al guardar en el archivo CSV";
        public const string ERROR_FORMATO_STRING = "Error el formato de entrada es incorrecto";
        public const string ERROR_NO_BECA = "No se encontraron becas para ese país";

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
        //Método que concatena el pais que no esta permitido
        public static string ErrorPais(string v1)
        {
            return string.Format("No se puede dar de alta una beca para el país {0}", v1);
        }
        //Método que concatena el pais que no esta permitido
        public static string BecaEliminada(string v1)
        {
            return string.Format("Beca con id {0} eliminada con éxito", v1);
        }
        //Metodo que concatena si no se ha encontrado una beca con el id
        public static string BecaNoEncontrada(string v1)
        {
            return string.Format("Beca con id {0} no se ha encontrado", v1);
        }
        //Método que concatena si se ha encontrado becas de un pais determinado
        public static string BecaNoEncontradaPais(string v1)
        {
            return string.Format("No se encontraron becas para el país {0}", v1);
        }
    }
}