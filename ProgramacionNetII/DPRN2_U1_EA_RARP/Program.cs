namespace UnidadUnoEA
{
    class Program
    {
        //Declaración de las variables globales
        public static Iris? irisUno = null;
        public static Iris? irisDos = null;
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Llamado al método de presentación
            Presentacion();
        }
        //Declaración del método presentación
        public static void Presentacion()
        {
            irisUno = new Iris("AEECAwQF", "Oval", new ColorIris("Verde", 100), "bbbaaaabbb", 1.3, new List<string>() { "Mancha" });
            irisDos = new Iris("AEECAwQF", "Oval", new ColorIris("Verde", 100), "bbbaaaabbb", 1.3, new List<string>() { "Mancha"});
            //Mensaje de presentación del programa
            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(StringProyect.BIENVENIDO);
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine(StringProyect.OPCIONES_MENU);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de las cartas
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        irisUno = CrearIris();
                        //irisUno.AtributosConsole();
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para poder elegir una carta
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        irisDos = CrearIris();
                        //irisDos.AtributosConsole();
                        //SeleccionCarta();
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para poder mostrar la defensa del monstruo
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        if (irisUno != null && irisDos != null)
                        {
                            Reconocimiento re = new Reconocimiento(irisUno, irisDos);
                            re.AtributosConsole();
                        }
                        else
                        {
                            Console.WriteLine(StringProyect.NO_SELECCION_IRIS);
                        }
                        //string i = (irisUno != null && irisDos != null) ? new Reconocimiento(irisUno, irisDos).AtributosConsole() : StringProyect.NO_SELECCION_IRIS;

                        //Reconocimiento re = new Reconocimiento(i,i2);
                        //Console.WriteLine($"total iguales {re.ContadorVerdaderos()}");
                        //re.AtributosConsole();
                        //Console.WriteLine(irisDos != null && irisDos != null ? $"{carta.DefensaMonstruo()}" : StringProyect.NO_SELECCION_PERSONAJE);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 4:
                        //Caso para poder mostrar el ataque del monstruo
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        if (irisUno != null && irisDos != null)
                        {
                            int opc = SeleccionIris();
                            if (opc == 1)
                            {
                                SelecionEnvejecimiento(irisUno);
                            }
                            else if(opc == 2)
                            {
                                SelecionEnvejecimiento(irisDos);
                            }
                            else
                            {
                                Console.WriteLine(StringProyect.NO_SELECCION_SUBMENU);
                            }
                        }
                        else
                        {
                            Console.WriteLine(StringProyect.NO_SELECCION_IRIS);
                        }
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 5:
                        //Caso para poder mostrar el ataque del monstruo
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //Console.WriteLine(carta != null ? PoscionCarta() : StringProyect.NO_SELECCION_PERSONAJE);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 6:
                        //Opción para la salida del programa
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.SALIR);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.RANGO_OPCIONES);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                }
            }
        }

        private static void SelecionEnvejecimiento(Iris iris)
        {
            Console.WriteLine(StringProyect.STRING_FORMATO);
            bool salir = false;
            //Uso del switch para seleccion de las opciones ingresadas desde la consola
            while (!salir)
            {
                Console.WriteLine(StringProyect.OPCIONES_ENVEJECIMIENTO);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        int intensidad = ValidarNumero(StringProyect.INGRESO_INTENSIDAD);
                        iris.SimularEnvejecimiento(intensidad);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        salir = true;
                        break;
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        double curvatura = ValidarNumeroDouble(StringProyect.INGRESO_CURVATURA);
                        iris.SimularEnvejecimiento(curvatura);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        salir = true;
                        break;
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        string otro = ValidarString(StringProyect.INGRESO_OTRO);
                        iris.SimularEnvejecimiento(otro);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.RANGO_OPCIONES_SUBMENU);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                }
            }
            
        }

        private static int  SeleccionIris()
        {
            //List<Iris> listIris = new List<Iris>() { };
            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(StringProyect.OPCIONES_IRIS);
            int opcion = ValidarNumero(StringProyect.SELECCION_IRIS);
            return opcion;
        }

        public static Iris CrearIris()
        {
            string textura = ValidarString(StringProyect.TEXTURA);
            string forma = ValidarString(StringProyect.FORMA);
            string color = ValidarString(StringProyect.COLOR);
            int intensidad = ValidarNumero(StringProyect.INTENSIDAD);
            string patron = ValidarString(StringProyect.PATRON);
            double curvatura = ValidarNumeroDouble(StringProyect.CURVATURA);
            string otros = ValidarString(StringProyect.OTROS);
            return new Iris(textura,forma,new ColorIris(color,intensidad),patron,curvatura,new List<string> { otros});
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
                    Console.WriteLine(StringProyect.ERROR_INGRESAR_NUMERO);
                }
                catch (OverflowException ex)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine(StringProyect.ERROR_NUMERO_GRANDE);
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
        //Método que valida el string ingresado desde la consola
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
                        Console.WriteLine(StringProyect.ERROR_INGRESAR_STRING_VACIO);
                    }
                    else if (EspacioVacio(s))
                    {
                        Console.WriteLine(StringProyect.ERROR_INGRESAR_STRING_VACIO_ESPACIOS);
                    }
                    else
                    {
                        salir = true;
                    }
                }
                //Catch para el caso de que se cuente con un error
                catch (FormatException ex)
                {
                    Console.WriteLine(StringProyect.ERROR_INGRESAR_STRING_GRANDE);
                }
            }
            //Retorno de string obtenido desde la consola
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
                    Console.WriteLine(StringProyect.ERROR_INGRESAR_NUMERO);
                }
                catch (OverflowException ex)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine(StringProyect.ERROR_NUMERO_GRANDE);
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
    }
}

