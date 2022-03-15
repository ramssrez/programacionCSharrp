using System;
namespace UnidadTresEA
{
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            string s = ValidarSoloString("Ingresa un string: ");
            Console.WriteLine("sdfsdfsdf: " +s);
            //Llamado el método que realiza la presentación del programa
            //Presentacion();
        }
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema para transformar tu número en binario");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Ingresar datos");
                Console.WriteLine("2. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos necesarios para la impresión del número
                    case 1:
                        Console.WriteLine("Has elegido la opción 1");
                        //IngresoDatosMatriz();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Opción para la finalización del programa
                    case 2:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 2");
                        break;
                }
            }

        }
        //Método que varifica si es un entero el valor ingresado desde la consola, se repite hasta que sea correcto
        public static int ValidarNumero(string mensaje)
        {
            //Declaración de variables necesarias para realizar el programa
            bool salir = false;
            int valor = 0;
            //Ciclo while que se repite en caso de que no se haya  ingresado un entero o sea menor a cuatro
            while (!salir)
            {
                //Uso de la sentencia try/catch para el caso de que no se ingrese un entero
                try
                {
                    Console.Write(mensaje);
                    valor = Convert.ToInt32(Console.ReadLine());
                    //Llamado al metodo para verificar que el valor ingresado sea mayor a cuatro
                    salir = true;
                }
                catch (FormatException ex)
                {
                    //Mensaje de error en caso de que no se haya ingresado un entero
                    Console.WriteLine("Error al ingresa valor, vuelve a intentarlo");
                }
                catch (OverflowException)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine("Número demasiado grande, intenta con otro número");
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
        /*
        public static bool EsNuloCaracter(string s)
        {
            bool validacion = false;
            //Declaración de la sentencia if/else para los casos presentados
            if (s. Length == 0)
            {
                //Opción cuando el string es igual a cero o nulo
                Console.WriteLine("El caracter no tiene que ser nulo");
            }
            else if (s.Length > 1)
            {
                //Opción cuando el string es mayor a uno
                Console.WriteLine("Solo tiene que ser un caracter ");
            }
            else
            {
                validacion = true;
            }
            //Retorno de booleano para continuar con las opciones
            return validacion;
        }
        */
        //Método que reliza la validación de un caracter hasta que se cumpla que sea correcto
        public static string ValidarSoloString(string mensaje)
        {
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas de un caracter
            while (!salir)
            {
                try
                {
                    Console.Write(mensaje);
                    s = Console.ReadLine();
                    
                    if (!SoloLetras(s))
                    {
                        Console.WriteLine("Error al ingresar el string, intenta de nuevo");
                    }
                    else
                    {
                        salir = true;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.Write("Error al ingresar el string, intenta de nuevo");
                }

            }
            //Retorno del string que se ha ingresado
            return s;
        }
        /*
         *     public static String validarString(String argumento){
        boolean bandera = false;
        String string = "";
        while (!bandera){
            try {
                System.out.print(argumento);
                string = System.console().readLine();
                if (!soloLetras(string) || string.isEmpty()){
                    System.err.println("Nombre incorrecto, intenta de nuevo");
                }else {
                    bandera = true;
                }
            }catch (Exception e){
                System.out.println("Valor incorrecto, se espera un string");
            }
        }
        return string;
    }
         */

        //Metodo que permite identificar si los caracteres son letras o no
        static bool SoloLetras(string sCaracteres)
        {
            foreach (char ch in sCaracteres)
            {
                if (!Char.IsLetter(ch) && ch == 32)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
