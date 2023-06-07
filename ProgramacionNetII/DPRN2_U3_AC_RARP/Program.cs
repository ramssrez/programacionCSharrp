namespace UnidadTresAC
{
    class Program
    {
        //Declaración de las variables globales
        public static RepositorioBecas repositorio = new();
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Llamado al método de presentación
            Presentacion();
        }
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
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para para dar de alta una nueva beca
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        AltaBeca();
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para eliminar una beca de la lista de becas
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        EliminarBecas();
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para bucar las becas en función del país
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        BuscarBeca();
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 4:
                        //Caso para obtener el resumen de becas encontradas en la lista de becas
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        ResumenBecas();
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 5:
                        //Caso para mostrar todas las becas con las que se cuenta
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        MostrarTodasBecas();
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 6:
                        //Opción para la salida del programa
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.SALIR);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción del menú
                    default:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.RangoOpciones(1, 6));
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                }
            }
        }
        //Método que muestra la información de todas las becas
        private static void MostrarTodasBecas()
        {
            foreach (Beca b in repositorio.Becas)
            {
                Console.WriteLine(b.MostrarDetalles());
                Console.WriteLine(StringProyect.STRING_FORMATO);
            }
        }
        //Método que permite ver el resumen de becas con las que se cuenta
        private static void ResumenBecas()
        {
            var(monto, total) = repositorio.ResumenBecas();
            Console.WriteLine($"El monto de las becas es: ${monto}");
            Console.WriteLine($"El total de becas es: {total}");
        }

        //Método que permites la busqueda de becas por país
        private static void BuscarBeca()
        {
            string pais = ValidarString(StringProyect.INGRESO_PAIS);
            repositorio.ConsultarBecasPorPais(pais);
            //throw new NotImplementedException();
        }
        //Método que permite eliminar una beca de la lista de becas
        private static void EliminarBecas()
        {
            string s = ValidarString(StringProyect.INGRESO_IDS);
            repositorio.EliminarBeca(s);
        }

        //Método que muestra un menú secundario para la creación de diferentes tipos de becas
        private static void AltaBeca()
        {
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine(StringProyect.OPCIONES_MENU_DOS);
                int opcion = ValidarNumero(StringProyect.OPCION_SUBMENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para dar una beca academica
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(CrearBecaAcademica());
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para dar una beca deportiva
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(CrearBecaDeportiva());
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 3:
                        //Opción para la salida del programa
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.RETORNO);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        salir = true;
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
        //Método que envía la información para la creación de una beca deportiva
        private static string CrearBecaDeportiva()
        {
            Console.WriteLine(StringProyect.DATOS_BECA);
            string pais = ValidarString(StringProyect.INGRESO_PAIS);
            int id = ValidarNumero(StringProyect.INGRESO_ID);
            decimal monto = ValidarNumeroDecimal(StringProyect.INGRESO_MONTO);
            string deporte = ValidarString(StringProyect.INGRESO_DEPORTE);
            return repositorio.AltaNuevaBeca(id, pais, monto, StringProyect.DEPORTIVA, deporte);
        }
        //Método que envía la información para la creación de una beca académica
        private static string CrearBecaAcademica()
        {
            Console.WriteLine(StringProyect.DATOS_BECA);
            string pais = ValidarString(StringProyect.INGRESO_PAIS);
            int id = ValidarNumero(StringProyect.INGRESO_ID);
            decimal monto = ValidarNumeroDecimal(StringProyect.INGRESO_MONTO);
            string universidad = ValidarString(StringProyect.INGRESO_UNIVERSIDAD);
            return repositorio.AltaNuevaBeca(id,pais,monto,StringProyect.ACADEMICA,universidad);
        }
        //Método que valida el string ingresado desde la consola
        public static string ValidarString(string mensaje)
        {
            bool salir = false;
            string? s = null;
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
                        Console.WriteLine(StringProyect.ERROR_STRING_EMPTY);
                    }
                    else if (EspacioVacio(s))
                    {
                        Console.WriteLine(StringProyect.ERROR_STRING_ESPACIOS);
                    }
                    else
                    {
                        salir = true;
                    }
                }
                //Catch para el caso de que se cuente con un error
                catch (FormatException)
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
        public static decimal ValidarNumeroDecimal(string mensaje)
        {
            //Declaración de variables necesarias para realizar el programa
            bool salir = false;
            decimal valor = 0;
            //Ciclo while que se repite en caso de que no se haya  ingresado un entero o sea menor a cuatro
            while (!salir)
            {
                //Uso de la sentencia try/catch para el caso de que no se ingrese un entero
                try
                {
                    Console.Write(mensaje);
                    valor = Convert.ToDecimal (Console.ReadLine());
                    salir = true;
                }
                catch (FormatException)
                {
                    //Mensaje de error en caso de que no se haya ingresado un número
                    Console.WriteLine(StringProyect.ERROR_INGRESAR_NUMERO);
                }
                catch (OverflowException)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine(StringProyect.ERROR_NUMERO_GRANDE);
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
                catch (FormatException)
                {
                    //Mensaje de error en caso de que no se haya ingresado un entero
                    Console.WriteLine(StringProyect.ERROR_INGRESAR_NUMERO);
                }
                catch (OverflowException)
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