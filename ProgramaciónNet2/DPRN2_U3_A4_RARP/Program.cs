namespace UnidadTresA4
{
    class Program
    {
        //Declaración de la variable global de la aplicación
        public static Inmuebles inmuebles = new();
        public static List<Inmueble> mesasDesayuno = inmuebles.MesasDesayuno;
        public static List<Inmueble> mesasComida = inmuebles.MesasComida;
        public static List<Inmueble> mesasCena = inmuebles.MesasCena;
        public static List<Inmueble> salasDesayuno = inmuebles.SalasDesayuno;
        public static List<Inmueble> salasComida = inmuebles.SalasComida;
        public static List<Inmueble> salasCena = inmuebles.SalasCena;
        public static int conMeDe= 0;
        public static int conMeCo = 0;
        public static int conMeCe = 0;
        public static int conSaDe = 0;
        public static int conSaCo = 0;
        public static int conSaCe = 0;

        //public static Reserva? reserva = null;
        public static List<Reserva> reservas = new();
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
            Console.WriteLine("Reservación OnCeat");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Reservar lugar.");
                Console.WriteLine("2. Cancelar reservación");
                Console.WriteLine("3. Mostrar información de la cartera");
                Console.WriteLine("4. Salir");
                int opcion = ValidarNumero("¿Qué deseas hacer?: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder ralizar la reserva de una mesa.d
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        TiempoReserva();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la compra de monedas virtuales
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                         CancelarReserva();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar la cartera del usuario
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        //cartera.MostrarCarteraVitual();
                        foreach (Reserva r in reservas)
                        {
                            Console.WriteLine(r.MostrarInformacion());
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
        //
        private static void CancelarReserva()
        {
            int id = ValidarNumero("Ingresa el valor ID de la reserva: ");
            try
            {
                Reserva r = reservas.ElementAt(id - 1);
                r.Inmueble.IsOcupada = false;
                if (r.Inmueble.Tipo.Equals("Mesa"))
                {
                    r.Inmueble.Espacios = 4;
                    if (r.Tiempo.Equals("Desayuno"))
                    {
                        conMeDe--;
                    }
                    else if (r.Tiempo.Equals("Comida"))
                    {
                        conMeCo--;
                    }
                    else if (r.Tiempo.Equals("Cena"))
                    {
                        conMeCe--;
                    }
                }
                else if (r.Inmueble.Tipo.Equals("Sala"))
                {
                    r.Inmueble.Espacios = 10;
                }


                Console.WriteLine("1. Desayuno.");
                Console.WriteLine("2. Comida");
                Console.WriteLine("3. Cena");
                reservas.RemoveAt(id-1);
                Console.WriteLine($"Se ha eliminado la reserva con ID: {id}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("No se cuenta con la información del ID ingresado");
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
        public static void TiempoReserva()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                Console.WriteLine("Selección de tiempo para reservar");
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Desayuno.");
                Console.WriteLine("2. Comida");
                Console.WriteLine("3. Cena");
                Console.WriteLine("4. Salir");
                int opcion = ValidarNumero("Selecciona una opción: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de las monedas
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        TipoReserva("Desayuno", mesasDesayuno,conMeDe);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la compra de monedas virtuales
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        TipoReserva("Comida",mesasComida,conMeCo);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar la cartera del usuario
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        TipoReserva("Cena",mesasCena,conMeCe);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Retornando.............");
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
        public static void TipoReserva(string tiempo, List<Inmueble> inmuebl, int contador)
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine($"Selección el lugar para reservar en {tiempo}");
                Console.WriteLine("1. Mesas.");
                Console.WriteLine("2. Salas");
                Console.WriteLine("3. Salir");
                int opcion = ValidarNumero("Selecciona una opción: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de las monedas
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        if (InmuebleDisponibles(inmuebl))
                        {
                            int numeroPersonas = ValidarNumero("Ingresa la cantidad de personas: ");
                            if (!(numeroPersonas > 4))
                            {
                                string nombre = ValidarSoloString("Ingresa el nombre de la persona: ");
                                string apellido = ValidarSoloString("Ingresa el apellido de la persona: ");
                                inmuebl[contador].IsOcupada = true;
                                inmuebl[contador].Espacios = numeroPersonas;
                                CrearReserva(inmuebl[contador], tiempo, nombre, apellido);
                                if (tiempo.Equals("Desayuno"))
                                {
                                    conMeDe++;
                                }
                                else if (tiempo.Equals("Comida"))
                                {
                                    conMeCo++;
                                }
                                else if (tiempo.Equals("Cena"))
                                {
                                    conMeCe++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Solo se pueden 4 personas por mesa");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya no se cuenta con mesas disponibles");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la compra de monedas virtuales
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        if (InmuebleDisponibles(inmuebl))
                        {
                            int numeroPersonas = ValidarNumero("Ingresa la cantidad de personas: ");
                            if (!(numeroPersonas > 10))
                            {
                                string nombre = ValidarSoloString("Ingresa el nombre de la persona: ");
                                string apellido = ValidarSoloString("Ingresa el apellido de la persona: ");
                                inmuebl[contador].IsOcupada = true;
                                inmuebl[contador].Espacios = numeroPersonas;
                                CrearReserva(inmuebl[contador], tiempo, nombre, apellido);
                                contador++;
                            }
                            else
                            {
                                Console.WriteLine("Solo se pueden 4 personas por mesa");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya no se cuenta con mesas disponibles");
                        }
                        //inmuebles.MostrarSalasDisponibles();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar la cartera del usuario
                    case 3:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Retornando............");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 3");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
            }
        }
        //Método que crea una reserva con el ingreso de varios parametros de entrada
        public static void CrearReserva(Inmueble inmueble, string tiempo, string nombre, string apellido)
        {
            //Creación de la reserva
            Reserva reserva = new (nombre, apellido, tiempo, inmueble);
            reservas.Add(reserva);
            MostrarReserva(reserva);
        }

        private static void MostrarReserva(Reserva reserva)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("La reservación ha sido creada con la siguiente información, guarda el ID de la reservación");
            Console.WriteLine($"{reserva.MostrarInformacion()}");
            Console.WriteLine("**********************************************************************************************");

        }

        public static bool InmuebleDisponibles(List<Inmueble> inmueble)
        {
            //inmueble.Contains();
            bool bandera = true;
            int contador = 0;
            foreach (Inmueble i in inmueble)
            {
                if (!i.IsOcupada)
                {
                    contador++;
                }
            }
            if (contador == 0)
            {
                bandera = false;
            }
            return bandera;
        }
    }
}
