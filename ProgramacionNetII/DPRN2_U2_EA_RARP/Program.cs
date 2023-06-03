namespace UnidadDosEA
{
    class Program
    {
        //Declaración de las variables globales
        public static Cuentas cuentas = new Cuentas();
        //public static Drones drones = new Drones();
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Llamado al método de presentación
            Presentacion();
        }
        //Declaración del método presentación
        public static void Presentacion()
        {
            // Mensaje de presentación del programa
            Console.WriteLine(StringProyect.STRING_FORMATO);
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine(StringProyect.BIENVENIDO);
                Console.WriteLine(StringProyect.OPCIONES_MENU);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                switch (opcion)
                {
                    //Caso para crear una cuenta
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        CrearCuenta(cuentas.MaestraList,cuentas.InversionList);
                        //SeleccionListas(drones.TricopteroList);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para calcular el interes de una cuenta
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //SeleccionListas(drones.CuadricopteroList);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para cerrar una cuenta
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //SeleccionListas(drones.HexacopteroList);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 4:
                        //Caso para mostrar la información de todas las cuentas
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        for (int i = 0; i<cuentas.MaestraList.Count;i++)
                        {
                            Console.WriteLine(cuentas.MaestraList[i].MostrarInformacion());
                            Console.WriteLine(StringProyect.STRING_FORMATO);
                        }
                        for (int i = 0; i < cuentas.InversionList.Count; i++)
                        {
                            Console.WriteLine(cuentas.InversionList[i].MostrarInformacion());
                            Console.WriteLine(StringProyect.STRING_FORMATO);
                        }
                        //SeleccionListas(drones.CoaxialList);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 5:
                        //Opción para la salida del programa
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.SALIR);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción del menú
                    default:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.RangoOpciones(1, 5));
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;

                }
            }




            /*
            CuentaMaestra cuenta = new CuentaMaestra("Maestra",1000,10);
            CuentaMaestra cuenta2 = new CuentaMaestra("Maestra", 1000, 10);
            Inversion inversion = new Inversion("Inversion",1000,"20/05/2023","Largo plazo");
            Console.WriteLine(cuenta.MostrarInformacion());
            Console.WriteLine(cuenta2.MostrarInformacion());
            Console.WriteLine(inversion.MostrarInformacion());
            */
        }

        private static void CrearCuenta(List<CuentaMaestra> maestraList, List<Inversion> inversionList)
        {
            //Variable para salir del ciclo.
            bool salir = false;
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine(StringProyect.OPCIONES_MENU_SECUNDARIO);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                switch (opcion)
                {
                    //Caso para crear una cuenta maestra
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        CuentaMaestra ma = CuentaMaestra();
                        Console.WriteLine(StringProyect.CREANDO_CUENTA);
                        Console.WriteLine(StringProyect.CreacionCuenta(ma.NumeroCuenta,StringProyect.MAESTRA));
                        maestraList.Add(ma);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para crear una cuenta de inversión
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Inversion inv = CuentaInversion();
                        Console.WriteLine(StringProyect.CREANDO_CUENTA);
                        Console.WriteLine(StringProyect.CreacionCuenta(inv.NumeroCuenta,StringProyect.INVERSION));
                        inversionList.Add(inv);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para salir del menú secundario
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(StringProyect.SALIR);
                        salir = true;
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción del menú
                    default:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.RangoOpciones(1, 3));
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                }
            }

        }

        private static CuentaMaestra CuentaMaestra()
        {
            double saldo = VerificarMayorCero(StringProyect.INGRESO_SALDO);
            double comision = VerificarMayorCero(StringProyect.INGRESO_COMISION);
            return new CuentaMaestra(StringProyect.MAESTRA, saldo, comision);
        }
        private static Inversion CuentaInversion()
        {
            double saldo = VerificarMayorCero(StringProyect.INGRESO_SALDO);
            string fecha = ValidarString(StringProyect.FECHA_INVERSION);
            string tipo = ValidarString(StringProyect.TIPO_INVERSION);
            return new Inversion(StringProyect.INVERSION, saldo,fecha,tipo);
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
        //Método que permite la verificación de que el valor ingresado por el usuario sea mayor a cero
        private static double VerificarMayorCero(string v)
        {
            bool salida = false;
            double valor = 0;
            //Utilización del ciclo while que solicita el valor hasta que sea un número mayor a cero
            while (!salida)
            {
                valor = ValidarNumeroDouble(v);
                if (valor <= 0)
                {
                    Console.WriteLine(StringProyect.NUMERO_MAYOR_CERO);
                }
                else
                {
                    salida = true;
                }
            }
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
                    Console.WriteLine(StringProyect.ERROR_STRING);
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
    }
}