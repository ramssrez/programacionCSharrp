namespace UnidadUnoEA
{
    class Program
    {
        //Decalración de las variables globales
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
            /*
            
            cartas = new Cartas();
            cartasList = cartas.CartasList;
            */

            //Llamado al método de presentación
            //Presentacion();
            Iris i = new Iris(1,"AEECAwQF", "Oval", new ColorIris("Verde", 100), 
                new List<string>() { "aabbaaaabb", "bbbaaaabbb" }, new List<double>() { 1.1, 1.2, 1.3 },new List<string>() { "Mancha"});
            Iris iris2 = new Iris(2, "AEECAW1QF", "Oval", new ColorIris("Azul", 80),
                new List<string>() { "aabbaaabbb", "bbbaaabbbb" }, new List<double>() { 1.1, 1.2, 1.3 ,1.4}, new List<string>() { "Mancha","Cicatriz"});
            i.AtributosConsole();
            i.SimularEnvejecimiento(90);
            i.AtributosConsole();
            i.SimularEnvejecimiento(new List<double>() { 1.4,1.5,1.6});
            i.AtributosConsole();
            i.SimularEnvejecimiento("Cicatriz");
            i.AtributosConsole();
            iris2.AtributosConsole();
            Reconocimiento re = new Reconocimiento();
        }
        //Declaración del método presentación
        public static void Presentacion()
        {
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
                        //InfoCartas(cartasList);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para poder elegir una carta
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //SeleccionCarta();
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para poder mostrar la defensa del monstruo
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //Console.WriteLine(carta != null ? $"{carta.DefensaMonstruo()}" : StringProyect.NO_SELECCION_PERSONAJE);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 4:
                        //Caso para poder mostrar el ataque del monstruo
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //Console.WriteLine(carta != null ? $"{carta.AtaqueMonstruo()}" : StringProyect.NO_SELECCION_PERSONAJE);
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
        /*
        //Método que imprime la información de las cartas
        public static void InfoCartas(List<Carta> cartaList)
        {
            //Recorrido de la lista de las cartas
            foreach (Carta ca in cartaList)
            {
                //Impresión de la informaición de las cartas
                Console.WriteLine(StringProyect.STRING_FORMATO);
                ca.AtributosConsole();
                Console.WriteLine(StringProyect.STRING_FORMATO);
            }
        }
        //Método que permite seleccionar una carta de un menú
        public static void SeleccionCarta()
        {
            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(StringProyect.SELECCION_CARTA);
            for (int i = 0; i < cartasList.Count; i++)
            {
                Console.WriteLine($"{i}. {cartasList[i].NombreMonstruo}");
            }
            int opcion = ValidarNumero(StringProyect.OPCION_MENU);
            carta = opcion >= 0 && opcion < cartasList.Count ? cartasList[opcion] : null;

            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(carta != null ? StringProyect.SeleccionMonstruo(carta.NombreMonstruo) : StringProyect.NO_SELECCION_PERSONAJE);
            Console.WriteLine(StringProyect.STRING_FORMATO);
        }
        //Método que permite posicionar la carta seleccionada
        public static string PoscionCarta()
        {
            Console.WriteLine(StringProyect.STRING_FORMATO);
            Console.WriteLine(StringProyect.OPCIONES_ATAQUE_DEFENSA);
            int opcion = ValidarNumero(StringProyect.OPCION_MENU);
            return opcion > 0 && opcion <= 2 ? carta.PosicionCarta(opcion) : StringProyect.NO_OPCION_MENU;
        }
        */
    }
}

