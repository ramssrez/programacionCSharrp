namespace UnidadUnoA1
{
    class Program
    {
        public static Cartas? cartas;
        public static List<Carta>? cartasList;
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            cartas = new Cartas();
            cartasList = cartas.CartasList;
            //Instancia de las variables globales
            //personajes = new Personajes();
            //personajeList = personajes.PersonajesDC();
            //Llamado al método de presentación
            Presentacion();
        }
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
                Console.WriteLine("3. Pelea");
                Console.WriteLine("4. Ataque");
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
                        /*
                        Carta carta = new Carta("Mago obscuro", new Atributo(1,"Agua"), new Tipo(1,"Dragon",true),"Es el mamadisimo mago obscuro"
                            ,10,1500,2000);
                        carta.AtributosConsole();
                        */
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder elegir un personaje
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        //seleccionPersonaje();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la pelea del personaje seleccionado
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        /*
                        if (personaje != null)
                        {
                            personaje.Pelea();
                        }
                        else
                        {
                            Console.WriteLine("No se ha seleccionado al personaje");
                        }
                        */
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Caso para poder realizar el ataque del personaje
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        /*
                        if (personaje != null)
                        {
                            personaje.Ataque();
                        }
                        else
                        {
                            Console.WriteLine("No se ha seleccionado al personaje");
                        }
                        */
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
        public static void InfoCartas(List<Carta>? cartaList)
        {
            //Recorrido de la lista de los personajes
            foreach (Carta ca in cartaList)
            {
                //Impresión de la informaición de los personajes
                Console.WriteLine("**********************************************************************************************");
                ca.AtributosConsole();
                Console.WriteLine("**********************************************************************************************");
            }
        }
    }
}

