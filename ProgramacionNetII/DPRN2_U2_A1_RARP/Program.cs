namespace UnidadDosA1
{
    class Program
    {
        //Declaración de las variables globales
        /*
        public static Cartas? cartas;
        public static List<Carta>? cartasList;
        public static Carta? carta;
        public static StringProyect strings;
        */
        public static Drones drones = new Drones();
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Instancia de las variables globales
            //cartas = new Cartas();

            //cartasList = cartas.CartasList;
            /*
            drones.TricopteroList[0].NumeroBrazos = 1;
            foreach (Tricoptero tr in drones.TricopteroList)
            {
                Console.WriteLine(StringProyect.STRING_FORMATO);
                //tr.Tipo("Waka");
                Console.WriteLine(tr.MostrarInformacion());
            }
            foreach (Cuadricoptero tr in drones.CuadricopteroList)
            {
                Console.WriteLine(StringProyect.STRING_FORMATO);
                Console.WriteLine(tr.MostrarInformacion());
            }
            foreach (Hexacoptero tr in drones.HexacopteroList)
            {
                Console.WriteLine(StringProyect.STRING_FORMATO);
                Console.WriteLine(tr.MostrarInformacion());
            }
            foreach (Coaxial tr in drones.CoaxialList)
            {
                Console.WriteLine(StringProyect.STRING_FORMATO);
                Console.WriteLine(tr.MostrarInformacion());
            }
            //Dron dron = new Dron(4,1.2,"12",15,new Dimension(12,15,3));
            
            Tricoptero tricoptero = new Tricoptero(StringProyect.TRICOPTERO,20, 3, 1.2, "12", 15, new Dimension(15, 12, 5));
            Cuadricoptero cuadricoptero = new Cuadricoptero(StringProyect.CUADRICOPTERO, 1.3, 4, 1.2, "12", 15, new Dimension(20, 18, 8));
            Hexacoptero hexacoptero = new Hexacoptero(StringProyect.HEXACOPTERO, 14,  6, 1.2, "12", 15, new Dimension(22, 20, 3));
            Coaxial coaxial = new Coaxial(StringProyect.COAXIAL, 14.5, 4, 1.2, "12", 15, new Dimension(30, 30, 15));
            //Cuadricoptero Hexacoptero Coaxial 

            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(tricoptero.MostrarInformacion());
            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(cuadricoptero.MostrarInformacion());
            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(hexacoptero.MostrarInformacion());
            Console.WriteLine(hexacoptero.IniciarGrabacion());
            Console.WriteLine(hexacoptero.DetenerGrabacion());
            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(coaxial.MostrarInformacion());
            Console.WriteLine(coaxial.TransportarCarga());
            */
            //Llamado al método de presentación
            Presentacion();
        }
        //Declaración del método presentación
        public static void Presentacion()
        {
            // Mensaje de presentación del programa
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
                    //Caso para mostrar y modificar información de la lista de drones tipo Tricópteros
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //FuncionesTricopteros();
                        SeleccionListas(drones.TricopteroList);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para mostrar y modificar información de la lista de drones tipo Cuadricóptero
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para mostrar y modificar información de la lista de drones tipo Hexacóptero
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 4:
                        //Caso para mostrar y modificar información de la lista de drones tipo Coaxial
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
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
                        Console.WriteLine(StringProyect.RANGO_OPCIONES);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                }
            }
        }
        private static void SeleccionListas(List<Tricoptero> tricopteros)
        {
            // Mensaje de presentación del programa
            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(StringProyect.STRING_MENU_SECUNDARIO);
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine(StringProyect.OPCIONES_MENU_SECUNDARIO);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para ingresar los datos del primer Iris
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        double peso = VerificarMayorCero("Ingresa el peso del dron [kg]: ");
                        /*
                        bool salida = false;
                        while (salida)
                        {
                            double peso = ValidarNumeroDouble("Ingresa el peso del dron [kg]: ");
                            if (peso <= 0)
                            {
                                Console.WriteLine("El peso debe ser mayor a cero");
                            }
                            else
                            {
                                salida = true;
                        }
                        */
                        double energiaImpacto = ValidarNumeroDouble("Ingresa la energía de impacto [Julios]: ");
                        double velocidad = ValidarNumeroDouble("Ingresa la velocidad del dron [m/s]: ");
                        double ancho = ValidarNumeroDouble("Ingresa el ancho del dron [cm]: ");
                        double altura = ValidarNumeroDouble("Ingresa la altura del dron [cm]: ");
                        double baseDron = ValidarNumeroDouble("Ingresa la base del dron [cm]: ");
                        double potencia = ValidarNumeroDouble("Ingresa la potencia del motor trasero [W]: ");
                        tricopteros.Add(new Tricoptero(StringProyect.TRICOPTERO, potencia,3,peso,energiaImpacto,velocidad,new Dimension(altura,ancho,baseDron)));
                        Console.WriteLine("Creando un nuevo dron ......");
                        Console.WriteLine("Se ha creado un nuevo dron");
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para ingresar los datos del segundo Iris
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        foreach (Tricoptero tr in tricopteros)
                        {
                            Console.WriteLine(StringProyect.STRING_FORMATO);
                            //tr.Tipo("Waka");
                            Console.WriteLine(tr.MostrarInformacion());
                        }
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 3:
                        //Opción para la salida del programa
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.SALIR_MENU_SECUNDARIO);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción del menú
                    default:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.RANGO_OPCIONES_DOS);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                }
            }
        }

        private static double VerificarMayorCero(string v)
        {
            bool salida = false;
            double valor = 0;
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

        private static void FuncionesTricopteros()
        {
            for (int i = 0; i < drones.TricopteroList.Count; i++)
            {
                Console.WriteLine("");
            }
            /*
            foreach (Tricoptero tr in drones.TricopteroList)
            {
                Console.WriteLine(StringProyect.STRING_FORMATO);
                //tr.Tipo("Waka");
                Console.WriteLine(tr.MostrarInformacion());
            }
            */
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