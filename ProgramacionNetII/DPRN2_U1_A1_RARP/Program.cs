namespace UnidadUnoA1
{
    class Program
    {
        //Decalración de las variables globales
        public static Cartas? cartas;
        public static List<Carta>? cartasList;
        public static Carta? carta;
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Instancia de las variables globales
            cartas = new Cartas();
            cartasList = cartas.CartasList;
            //Llamado al método de presentación
            Presentacion();
        }
        //Declaración del método presentación
        public static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de cartas de YuGi-Oh");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Mostrar información de las cartas");
                Console.WriteLine("2. Seleccionar carta");
                Console.WriteLine("3. Mostrar defensa del monstruo");
                Console.WriteLine("4. Mostrar ataque del monstruo");
                Console.WriteLine("5. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de las cartas
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1, información de las cartas");
                        InfoCartas(cartasList);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder elegir una carta
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        SeleccionCarta();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder mostrar la defensa del monstruo
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        Console.WriteLine(carta != null ? $"{carta.DefensaMonstruo()}" : "No se ha seleccionado al personaje");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Caso para poder mostrar el ataque del monstruo
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        Console.WriteLine(carta != null ? $"{carta.AtaqueMonstruo()}" : "No se ha seleccionado al personaje");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido salir de la aplicación");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 5");
                        Console.WriteLine("**********************************************************************************************");
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
                catch (OverflowException ex)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine("Número demasiado grande, intenta con otro número");
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
        //Método que imprime la información de las cartas
        public static void InfoCartas(List<Carta> cartaList)
        {
            //Recorrido de la lista de las cartas
            foreach (Carta ca in cartaList)
            {
                //Impresión de la informaición de las cartas
                Console.WriteLine("**********************************************************************************************");
                ca.AtributosConsole();
                Console.WriteLine("**********************************************************************************************");
            }
        }
        //Método que permite seleccionar una carta de un menú
        public static void SeleccionCarta()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Selecciona una carta de YuGi-Oh");
            for (int i = 0; i<cartasList.Count; i++)
            {
                Console.WriteLine($"{i}. {cartasList[i].NombreMonstruo}");
            }
            int opcion = ValidarNumero("Ingresa una opción del menú: ");
            carta = opcion >= 0 && opcion < cartasList.Count ? cartasList[opcion] : null;

            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine(carta != null ? $"Has elegido al monstruo: {carta.NombreMonstruo}" : "No se ha seleccionado al personaje");
            Console.WriteLine("**********************************************************************************************");
        }
    }
}

