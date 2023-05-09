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
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Instancia de las variables globales
            //cartas = new Cartas();

            //cartasList = cartas.CartasList;
            Drones drones = new Drones();
            foreach (Tricoptero tr in drones.TricopteroList)
            {
                Console.WriteLine(StringProyect.STRING_FORMATO);
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
            /*
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
                    //Caso para ingresar los datos del primer Iris
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para ingresar los datos del segundo Iris
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para poder mostrar la autentificación de los dos iris ingresados, así como el porcentaje de similitud
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 4:
                        //Caso para poder simular el envejecimiento de la iris
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
    }
}