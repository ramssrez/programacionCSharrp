namespace UnidadTresEA
{
    class Program
    {
        //Variables globales del programa
        public static List<Ingrediente> ingredientes;
        public static List<Pizza> pizzas;
        public static ManejadorPizzas pizzasManager = new();
        public static Reserva r = new Reserva();
        public static int hora = 0;
        public static Posicion ubicacion =null;
        public static double distancia = 0.0;
        static void Main(string[] args)
        {
            //Inicio del método que contiene el menú de principal.
            Presentacion();
        }
        private static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            //Ubicación de la pizzería
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
                Console.WriteLine("3. Selecciona piza especial (escoge ingredientes).");
                Console.WriteLine("4. Terminar reservación de pizzas");
                Console.WriteLine("5. Salir.");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para ingresar la ubicación y horario del pedido
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        try
                        {
                            float latitud = ValidarNumeroFloat("Ingresa la latitud de tu ubicación: ");
                            float longitud = ValidarNumeroFloat("Ingresa la longitud de tu ubicación: ");
                            ubicacion = new(latitud, longitud);
                            distancia = DistanciaKm(pizzeria, ubicacion);
                            //Uso de la excepción personalizada para la distancia
                            if (distancia >= 8)
                            {
                                throw new DirecionException("La ubicación del lugar de entrega, no se encuentra dentro del radio de 8 kilometros");
                            }
                            hora = ValidarNumero("Ingresa la hora del pedido: ");
                            //Uso de la excepción personalizada para la hora
                            if (hora > 21 || hora < 9)
                            {
                                throw new HorarioException("El horario ingresado, no se encuentra dentro del horario de venta.");
                            }
                            Console.WriteLine("**********************************************************************************************");
                            Console.WriteLine("Se ha guardado los datos ingresados");
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
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para seleccionar las pizzas tradicionales
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        if (!(hora == 0 && ubicacion == null))
                        {
                            MenuPizzas();
                        }
                        else
                        {
                            Console.WriteLine("No has ingresado los datos de tu domicilio y hora");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar el pedido para ingresar los ingredientes
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        if (!(hora == 0 && ubicacion == null))
                        {
                            MenuEspecial();
                        }
                        else
                        {
                            Console.WriteLine("No has ingresado los datos de tu domicilio y hora");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para visualizar el pedido con la información de la reserva
                    case 4:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        if (!(hora == 0 && ubicacion == null))
                        {
                            Console.WriteLine("A continuación se muestra la información de la reserva");
                            r.MostrarReserva();
                            r = null; hora = 0; ubicacion = null; distancia = 0.0;
                        }
                        else
                        {
                            Console.WriteLine("No has ingresado los datos de tu domicilio y hora");
                        }
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
        //Método que muestra las opciones del menú para seleccionar las caracteristicas de la pizza especial
        private static void MenuEspecial()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            //Declaración de variables para el menú
            List<Tipo> tipos = new List<Tipo>();
            Tipo type = new Tipo("Chica", 20.0);
            Tipo type1 = new Tipo("Mediana", 50.0);
            Tipo type2 = new Tipo("Grande", 100.0);
            List<Ingrediente> ingredientesGeneral = new List<Ingrediente>();
            tipos.Add(type);
            tipos.Add(type1);
            tipos.Add(type2);
            Tipo tipoGeneral = null;
            Pizza pizza = null;

            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                Console.WriteLine("Escoge una las opciones para ingresar los datos de la pizza tradicional");
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Seleccionar el tamaño de la pizza.");
                Console.WriteLine("2. Selecciona los ingredientes de la pizza.");
                Console.WriteLine("3. Terminar pedido");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para seleccionar el tamaño de la pizza especial
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        for (int i = 0; i < tipos.Count; i++)
                        {
                            Console.WriteLine($"{i} - {tipos[i].Name}");
                        }
                        try
                        {
                            int op = ValidarNumero("Selecciona una opción: ");
                            tipoGeneral = tipos.ElementAt(op);
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine("No se ha seleccionado una opción del menú");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para seleccionar los ingredientes de la pizza especial
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        if (tipoGeneral != null)
                        {
                            MostrarIngredientes(pizzasManager.Ingredientes);
                            try
                            {
                                int op = ValidarNumero("Selecciona una opción: ");
                                Ingrediente ing = pizzasManager.Ingredientes.ElementAt(op);
                                ingredientesGeneral.Add(ing);
                            }
                            catch (ArgumentOutOfRangeException ex)
                            {
                                Console.WriteLine("No se ha seleccionado una opción del menú");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se ha escogido el tamaño de la pizza.");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso terminar el pedido de la pizza especial
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        if (tipoGeneral != null || ingredientesGeneral.Count != 0)
                        {
                            Console.WriteLine("Se ha generado la reserva, volviendo al menú principal.");
                            pizza = new("Especial", ingredientesGeneral, tipoGeneral, 45);
                            //r.TiempoEntrega = pizza.Tiempo;
                            r.Precio = ingredientesGeneral.Count * 50.0;
                            r.Pizzas.Add(pizza);
                            r.Hora = hora;
                            r.Distancia = distancia;
                            r.Posicion = ubicacion;
                            salir = true;
                        }
                        else
                        {
                            Console.WriteLine("No se ha escogido el tamaño de la pizza, ni los ingredientes.");
                        }
                        Console.WriteLine("**********************************************************************************************");
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
        //Menú que muesta las pizzas con las que se cuenta
        private static void MenuPizzas()
        {
            Console.WriteLine("**********************************************************************************************");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                Console.WriteLine("Lista de Pizzas");
                //Impresión de los diferentes opciones de pizzas del menú
                Console.WriteLine("1. Carlos especial.");
                Console.WriteLine("2. Hawaiana.");
                Console.WriteLine("3. Mexicana.");
                Console.WriteLine("4. Cubana.");
                Console.WriteLine("5. Vegetariana.");
                Console.WriteLine("6. Marinera.");
                Console.WriteLine("7. Peperoni.");
                Console.WriteLine("8. Anchoas.");
                Console.WriteLine("9. Terminar escoger pizzas.");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Muestra de las opciones disponibles
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        ImpresionPizzas(pizzasManager.PizzasCarlos);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        ImpresionPizzas(pizzasManager.PizzasHuawaina);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        ImpresionPizzas(pizzasManager.PizzasMexicana);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        ImpresionPizzas(pizzasManager.PizzasCubana);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 5");
                        ImpresionPizzas(pizzasManager.PizzasVegetariana);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 6:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 6");
                        ImpresionPizzas(pizzasManager.PizzasMarinera);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 7:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción ");
                        ImpresionPizzas(pizzasManager.PizzasPeperoni);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 8:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 8");
                        ImpresionPizzas(pizzasManager.PizzasAnchoas);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 9:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Retornando........");
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
        //Método que realiza el guardado de la információn de las pizzas seleccionadas
        private static void ImpresionPizzas(List<Pizza> listPizzas)
        {
            Console.WriteLine($"Lista de tamaños");
            MostrarPizzas(listPizzas);
            try
            {
                int op = ValidarNumero("Selecciona una opción: ");
                Pizza p = listPizzas.ElementAt(op);
                r.Pizzas.Add(p);
                r.Hora = hora;
                r.Distancia = distancia;
                r.Precio = 0.0;
                r.Posicion = ubicacion;
                Console.WriteLine("**********************************************************************************************");
                Console.WriteLine("Se ha seleccionado una opción");

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("No se ha seleccionado una opción del menú");
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
        //Método que varifica si es un float el valor ingresado desde la consola, se repite hasta que sea correcto
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
        //Método que imprime el listado de las pizzas
        public static void MostrarPizzas(List<Pizza> pizzas)
        {
            for (int i = 0;i<pizzas.Count;i++)
            {
                Console.WriteLine($"{i} - {pizzas[i].Type.Name}");
            }
        }
        //Método que imprime el listado de los ingredientes
        public static void MostrarIngredientes(List<Ingrediente> ingredientes)
        {
            for (int i = 0; i < ingredientes.Count; i++)
            {
                Console.WriteLine($"{i} - {ingredientes[i].Name}");
            }
        }
    }
}