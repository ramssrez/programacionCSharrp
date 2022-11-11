namespace UnidadTresA3
{
    class Program
    {
        //Declaración de la variable global de la aplicación
        public static MonedaVirtual moneda = null;
        public static MonedasVirtual monedas = new();

        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Inicio del método que contiene el menú de principal.
            Presentacion();
        }
        //Método que muesta el menú de opciones para el caso de estudio
        public static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de alta y compra de monedas virtuales");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Ingresa los datos de la moneda virtual.");
                Console.WriteLine("2. Mostrar información de la moneda virtual");
                Console.WriteLine("3. Comprar monedas virtuales");
                Console.WriteLine("4. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de todos los ingredientes disponibles
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        monedas.MostrarMonedas();
                        /*
                        moneda = new MonedaVirtual();
                        string nombre = ValidarSoloString("Ingresa el nombre de maneda virtual: ");
                        int numero = ValidarNumero("Ingresa la posición de la moneda virtual: ");
                        string id = ValidarString("Ingresa el identificador de la moneda: ");
                        double precio = ValidarNumeroDouble("Ingresa el precio de la moneda: ");
                        moneda.GuardarInformacion(numero, nombre, id, precio);
                        */
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar los ingredientes por categoría
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        if (moneda != null)
                        {
                            Console.WriteLine($"{moneda.MostrarInformacion()}");
                        }
                        else
                        {
                            Console.WriteLine("No se han ingresado datos de la moneda, vuelve a la opción uno del menú");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar las calorias de los ingredientes por peso
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        if (moneda != null)
                        {
                            double monto = ValidarNumeroDouble("Ingresa el monto a invertir: ");
                            RealizarCompra(monto, moneda.Precio);
                        }
                        else
                        {
                            Console.WriteLine("No se han ingresado datos de la moneda, vuelve a la opción uno del menú");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido salir de la aplicación");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 4");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
            }
        }
        //Método que realiza la compra de una moneda, con parametros de entrada como el monto a invertir y el precio de la moneda
        private static void RealizarCompra(double monto, double precio)
        {
            //Uso de la sentecia try/catch para el caso de que no se cuente aún con información de la moneda
            try
            {
                double monedas = monto / precio;
                Console.WriteLine($"Se han comprado {monedas} monedas {moneda.Nombre}");
            }
            catch (NullReferenceException ex)
            {
                //Mensaje de error para el caso de que no se cuente con información de la cuenta
                Console.WriteLine("No se han ingresado los valores de la moneda, vuelve a la opción uno del menú");
            }
        }

        //Método que varifica si es un entero el valor ingresado desde la consola, se repite hasta que sea correcto
        public static double ValidarNumeroDouble(string mensaje)
        {
            //Declaración de variables necesarias para realizar el programa
            bool salir = false;
            double valor = 0.0d;
            //Ciclo while que se repite en caso de que no se haya  ingresado un entero o sea menor a cuatro
            while (!salir)
            {
                //Uso de la sentencia try/catch para el caso de que no se ingrese un entero
                try
                {
                    Console.Write(mensaje);
                    valor = Convert.ToDouble(Console.ReadLine());
                    salir = true;
                }
                catch (FormatException ex)
                {
                    //Mensaje de error en caso de que no se haya ingresado un número
                    Console.WriteLine("Error al ingresa valor, vuelve a intentarlo");
                }
                catch (OverflowException ex)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine("Número demasiado grande, intenta con otro número");
                }
            }
            //Retorno del valor ingresado
            return valor;
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
                    salir = true;
                }
                catch (FormatException ex)
                {
                    //Mensaje de error en caso de que no se haya ingresado un entero
                    Console.WriteLine("Error al ingresa valor, vuelve a intentarlo");
                }
                catch (OverflowException ex)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine("Número demasiado grande, intenta con otro número");
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
        //Métod que valida el string ingresado desde la consola
        public static string ValidarString(string mensaje)
        {
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas del string
            while (!salir)
            {
                //Uso de la sentencia try/catch para el caso de que no se haya ingresado de manera adecuada la información 
                try
                {
                    Console.Write(mensaje);
                    s = Console.ReadLine();
                    //Sentencia if/else para verificar si esta escrito sin espacios y vacios el string
                    if (string.IsNullOrEmpty(s))
                    {
                        Console.WriteLine("El string se encuentra vacío, vuelve a intentarlo");
                    }
                    else if (EspacioVacio(s))
                    {
                        Console.WriteLine("Ingresa un string sin espacios");
                    }
                    else
                    {
                        salir = true;
                    }
                }
                //Catch para el caso de que se cuente con un error
                catch (FormatException ex)
                {
                    Console.WriteLine("Error al ingresar el texto, vuelve a intentarlo");
                }
            }
            //Retorno de string obtenido desde la consola
            return s;
        }
        //Método que reliza la validación del string sea solo string sin números 
        public static string ValidarSoloString(string mensaje)
        {
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas del string
            while (!salir)
            {
                Console.Write(mensaje);
                s = Console.ReadLine();
                //Sentencia if/else para verificar el string ingresado por el usuario
                if (!SoloLetras(s))
                {
                    //Sentencia donde solo se necesita letra sin número ni espacios
                    Console.WriteLine("Ingresa solo letras, sin espacios");
                }
                else if (string.IsNullOrEmpty(s))
                {
                    //Snetencia para el caso de que el string se encuentre vacio
                    Console.WriteLine("El string se encuentra vacío, vuelve a intentarlo");
                }
                else
                {
                    //En caso contrario se puede salir del programa
                    salir = true;
                }
            }

            //Retorno del string que se ha ingresado
            return s;
        }
        //Metodo que permite identificar si al inicio del string haya un espacio
        public static bool EspacioVacio(string s)
        {
            foreach (char ch in s)
            {
                //Verificación del codigo ASCII para el espacio vacio
                if (ch != 32)
                {
                    return false;
                }
            }
            return true;
        }
        //Metodo que permite identificar si los caracteres son letras o no
        public static bool SoloLetras(string s)
        {
            //Recorrido del string con un foreach
            foreach (char ch in s)
            {
                //Verificación de si solo hay letras en el string
                if (!Char.IsLetter(ch) && ch != 32)
                {
                    return false;
                }
            }
            return true;
        }
        //Método que valida la fecha ingresada desde un string
        public static string ValidarFecha(string mensaje)
        {
            //Declaración de las variables necesarias para esta sección de codigo
            DateTime fecha;
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas de la fehca
            while (!salir)
            {
                //Sentencia try para el caso de que el string no sea agregao de manera correcta
                try
                {
                    Console.Write(mensaje);
                    s = Console.ReadLine();
                    //Sentencia if/else para veriicar si el string ingesado se puede parsear a un tipo DateTiem
                    if (!DateTime.TryParse(s, out fecha))
                    {
                        Console.WriteLine("La fecha no cuenta con el formato establecido, vuelve a intentarlo");
                    }
                    else
                    {
                        salir = true;
                    }
                }
                //Sentencia catch para el caso de que no se ingrese información adecuada
                catch (FormatException ex)
                {
                    Console.WriteLine("Error al ingresar la fecha, intenta de nuevo");
                }
            }
            //Retorno del string que se genero
            return s;
        }
    }
}
