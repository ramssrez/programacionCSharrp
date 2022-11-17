namespace UnidadTresEA
{
    class Program
    {
        public static List<Ingrediente> ingredientes;
        public static List<Pizza> pizzas;
        public static ManejadorPizzas pizzasManager = new();
        public static Reserva r = new Reserva();

        //Para modificar
        public static int hora = 19;
        public static Posicion ubicacion =new (19.4f,-99.2f);
        static void Main(string[] args)
        {
            //Inicio del método que contiene el menú de principal.
            Presentacion();
        }
        private static void Presentacion()
        {
            //CrearIngredientes();
            //CrearPizzas();

            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Posicion pizzeria = new(19.3934749F, -99.176846F);

            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                Console.WriteLine("Bienvenidos al sistema de compra de Carlos Pizza");
                Console.WriteLine("\n");
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Ingresar ubicación y horario del pedido.");
                Console.WriteLine("2. Selecciona pizza tradicional.");
                Console.WriteLine("3. Selecciona piza especial (escoge ingredientes)");
                Console.WriteLine("4. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de las monedas
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        //Console.WriteLine("Para poder realizar el pedido, ingresa las coordenadas de tu domicilio (latitud y longitud), así como la hora de entrega (0 -24)");
                        try
                        {
                            float latitud = ValidarNumeroFloat("Ingresa la latitud de tu ubicación: ");
                            float longitud = ValidarNumeroFloat("Ingresa la longitud de tu ubicación: ");
                            ubicacion = new(latitud, longitud);
                            float distancia = DistanciaKm(pizzeria, ubicacion);
                            if (distancia >= 8)
                            {
                                throw new DirecionException("La ubicación del lugar de entrega, no se encuentra dentro del radio de 8 kilometros");
                            }
                            hora = ValidarNumero("Ingresa la hora del pedido: ");
                            if (hora > 21 || hora < 9)
                            {
                                throw new HorarioException("El horario ingresado, no se encuentra dentro del horario de venta.");
                            }
                            Console.WriteLine("**********************************************************************************************");
                            Console.WriteLine("Se ha guardado los datos ingresados");
                            //r = new Reserva();
                        }
                        catch (HorarioException ex)
                        {
                            Console.WriteLine("**********************************************************************************************");
                            Console.WriteLine(ex.Message);
                            hora = 0;
                        }
                        catch (DirecionException ex)
                        {
                            Console.WriteLine("**********************************************************************************************");
                            Console.WriteLine(ex.Message);
                            ubicacion = null;
                        }
                        //monedas.MostrarMonedas();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la compra de monedas virtuales
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        if (!(hora == 0 && ubicacion == null))
                        {
                            Console.WriteLine("Selecciona una opcion");
                            MenuPizzas();
                        }
                        else
                        {
                            Console.WriteLine("No has ingresado los datos de tu domicilio y hora");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar la cartera del usuario
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        if (!(hora == 0 && ubicacion == null))
                        {
                            Console.WriteLine("Selecciona una opcion");
                        }
                        else
                        {
                            Console.WriteLine("No has ingresado los datos de tu domicilio y hora");
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
        private static void MenuPizzas()
        {
            Console.WriteLine("**********************************************************************************************");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                Console.WriteLine("Lista de Pizzas");
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Carlos especial.");
                Console.WriteLine("2. Hawaiana.");
                Console.WriteLine("3. Mexicana.");
                Console.WriteLine("4. Cubana.");
                Console.WriteLine("5. Vegetariana.");
                Console.WriteLine("6. Marinera.");
                Console.WriteLine("7. Peperoni.");
                Console.WriteLine("8. Anchoas.");
                Console.WriteLine("9. Retornar.");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de las monedas
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine($"Lista de pizzas");
                        MostrarPizzas(pizzasManager.PizzasCarlos);

                        try
                        {
                            int op = ValidarNumero("Selecciona una opción: ");
                            Pizza p = pizzasManager.PizzasCarlos.ElementAt(op);
                            //p.MostrarInfo();
                            //r.Pizza = p;
                            r.TiempoEntrega =p.Tiempo;
                            r.Pizzas.Add(p);
                            r.Hora = hora;
                            r.Posicion = ubicacion;
                            r.MostrarReserva();
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine("No se ha seleccionado una opción del menú");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la compra de monedas virtuales
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar la cartera del usuario
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 5");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 6:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 6");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 7:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción ");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 8:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 8");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 9:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Retornando........");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 9");
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
        public static float ValidarNumeroFloat(string mensaje)
        {
            //Declaración de variables necesarias para realizar el programa
            bool salir = false;
            float valor = 0.0f;
            //Ciclo while que se repite en caso de que no se haya  ingresado un entero o sea menor a cuatro
            while (!salir)
            {
                //Uso de la sentencia try/catch para el caso de que no se ingrese un entero
                try
                {
                    Console.Write(mensaje);
                    valor = Convert.ToSingle(Console.ReadLine());
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
        //Método que realiza el calculo de la distancia entre dos posiciones
        public static float DistanciaKm(Posicion posOrigen, Posicion posDestino)
        {
            //Desglose de la Fórmula de Haversine
            float RadioTierraKm = 6378.0F;
            float radianLat = EnRadianes(posDestino.Latitud - posOrigen.Latitud);
            float radianLon = EnRadianes(posDestino.Longitud - posOrigen.Longitud);
            var a = Math.Sin(AlCuadrado(radianLat / 2)) +
                      Math.Cos(EnRadianes(posOrigen.Latitud)) *
                      Math.Cos(EnRadianes(posDestino.Latitud)) *
                      Math.Sin(AlCuadrado(radianLon / 2));
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return RadioTierraKm * Convert.ToSingle(c);
        }
        //Método que realiza el cambio de coordenadas geograficas a coordenadas polares
        public static float EnRadianes(float valor)
        {
            return Convert.ToSingle(Math.PI / 180) * valor;
        }
        //Método que eleva al cuadrado un valor númerico
        static double AlCuadrado(double valor)
        {
            return Math.Pow(valor, 2);
        }
        public static void MostrarPizzas(List<Pizza> pizzas)
        {
            for (int i = 0;i<pizzas.Count;i++)
            {
                Console.WriteLine($"{i} - {pizzas[i].Type.Name}");
            }
        }
    }
}