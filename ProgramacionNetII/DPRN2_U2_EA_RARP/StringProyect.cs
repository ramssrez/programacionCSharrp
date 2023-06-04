namespace UnidadDosEA
{
    //Delclaración de la clase StringProyect
    public class StringProyect
    {
        //Atributos de la clase que contiene los strings a utilizar en el proyecto
        public const string STRING_FORMATO = "**********************************************************************************************";
        public const string BIENVENIDO = "Bienvenidos al sistema de cuentas bancarias";
        public const string OPCIONES_MENU = "1. Crear una cuenta. \n2. Calcular intereses de una cuenta.\n3. Cerrar una cuenta\n4. Mostrar todas las cuentas\n5. Salir";
        public const string OPCION_MENU = "Ingresa una opción del menú: ";
        public const string SALIR = "Has elegido salir de la aplicación";
        public const string OPCIONES_MENU_SECUNDARIO = "1. Crear cuenta maestra. \n2. Crear cuenta de inversión.\n3. Regresar....";
        public const string OPCIONES_MENU_TERCIARIO = "1. Cuentas Maestras. \n2. Cuentas de Inversión.\n3. Regresar....";
        public const string OPCIONES_MENU_CUARTO = "1. Fallecimiento titular. \n2. Cancelación por titular.\n3. Cancelación por el banco.\n4. Motivo desconocido.\n5. Ingresar el motivo.\n6. Regresar....";
        public const string RETORNO = "Retornando al menú principal.......";
        public const string CREANDO_CUENTA = "Creando una nueva cuenta ......";
        public const string MAESTRA = "Maestra";
        public const string INVERSION = "Inversión";
        public const string FECHA_INVERSION = "Ingresa la fecha de la inversión (dd/MM/AAAA): ";
        public const string TIPO_INVERSION = "Ingresa el tipo de inversión (Corto, Mediano, Largo): ";
        public const string INGRESO_SALDO = "Ingresa el saldo de la cuenta: $";
        public const string INGRESO_COMISION = "Ingresa la comisión de la cuenta: $";
        public const string SELECCION_CUENTA = "Selecciona una cuenta de la lista";
        public const string INGRESO_INTERES = "Ingresa el valor del interes: $";
        public const string INGRESO_CANCELACION = "Ingresa el motivo de cancelación: ";

        //Warnings
        public const string STRING_VACIO = "El string se encuentra vacío, vuelve a intentarlo";
        public const string NUMERO_MAYOR_CERO = "El número debe ser mayor a cero";
        public const string STRING_WITHOUT_ESPACIO = "Ingresa un string sin espacios";
        public const string NO_CUENTA = "No se ha seleccinado una cuenta";
        public const string CERRARDO_CUENTA = "Cerrando cuenta...........\n!Se ha cerrado la cuenta¡";

        //Errores
        public const string ERROR_INGRESAR_NUMERO = "Error al ingresa el número, vuelve a intentarlo";
        public const string ERROR_NUMERO_GRANDE = "Número demasiado grande, intenta con otro número";
        public const string ERROR_STRING = "Error al ingresar el texto, vuelve a intentarlo";

        //Métodos
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
        //Método que concatena el número de cuenta
        public static string CreacionCuenta(int valor, string v2)
        {
            return string.Format("¡Se ha creado una nueva cuenta de {1} con número de cuenta: {0}!", valor,v2);
        }
        //Método que concatena la opción seleccionada de la cuenta
        public static string OpcionCuenta(int valor)
        {
            return string.Format("Cuenta seleccionada con número de cuenta: {0}", valor);
        }
        //Método que concatena el nuevo saldo de la cuenta
        public static string NuevoSueldo(double valor)
        {
            return string.Format("El nuevo saldo de la cuenta es: ${0}", valor);
        }
    }
}