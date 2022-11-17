namespace UnidadTresEA
{
    class Program
    {
        public static List<Ingrediente> ingredientes;
        public static List<Pizza> pizzas;
        public static int hora = 0;
        public static Posicion ubicacion = null;
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
                        if (!(hora == 0 && ubicacion == null) )
                        {
                            Console.WriteLine("Selecciona una opcion");
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
            float radianLat = EnRadianes(posDestino.Latitud-posOrigen.Latitud);
            float radianLon = EnRadianes(posDestino.Longitud - posOrigen.Longitud);
            var a = Math.Sin(AlCuadrado(radianLat / 2)) +
                      Math.Cos(EnRadianes(posOrigen.Latitud)) *
                      Math.Cos(EnRadianes(posDestino.Latitud)) *
                      Math.Sin(AlCuadrado(radianLon / 2));
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a));
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
        private static void CrearPizzas()
        {
            pizzas = new List<Pizza>();
            Pizza pizza = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Chica", 100.0), "30");
            Pizza pizza1 = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Mediana", 150.0), "30");
            Pizza pizza2 = new("Carlos especial", new List<Ingrediente> { new Ingrediente("Secretos") }, new Tipo("Grande", 200.0), "30");

            Pizza pizza3 = new("Hawaiana", new List<Ingrediente> { ingredientes[0], ingredientes[1], ingredientes[2], ingredientes[3] }, new Tipo("Chica", 100.0), "28");
            Pizza pizza4 = new("Hawaiana", new List<Ingrediente> { ingredientes[0], ingredientes[1], ingredientes[2], ingredientes[3] }, new Tipo("Mediana", 150.0), "28");
            Pizza pizza5 = new("Hawaiana", new List<Ingrediente> { ingredientes[0], ingredientes[1], ingredientes[2], ingredientes[3] }, new Tipo("Grande", 200.0), "28");

            Pizza pizza6 = new("Mexicana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[5], ingredientes[6] }, new Tipo("Chica", 100.0), "45");
            Pizza pizza7 = new("Mexicana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[5], ingredientes[6] }, new Tipo("Mediana", 150.0), "45");
            Pizza pizza8 = new("Mexicana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[5], ingredientes[6] }, new Tipo("Grande", 200.0), "45");

            Pizza pizza9 = new("Cubana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[1], ingredientes[7], ingredientes[8] }, new Tipo("Chica", 100.0), "30");
            Pizza pizza10 = new("Cubana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[1], ingredientes[7], ingredientes[8] }, new Tipo("Mediana", 150.0), "30");
            Pizza pizza11 = new("Cubana", new List<Ingrediente> { ingredientes[0], ingredientes[4], ingredientes[1], ingredientes[7], ingredientes[8] }, new Tipo("Grande", 200.0), "30");

            Pizza pizza12 = new("Vegetariana", new List<Ingrediente> { ingredientes[0], ingredientes[9], ingredientes[10] }, new Tipo("Chica", 100.0), "32");
            Pizza pizza13 = new("Vegetariana", new List<Ingrediente> { ingredientes[0], ingredientes[9], ingredientes[10] }, new Tipo("Mediana", 150.0), "32");
            Pizza pizza14 = new("Vegetariana", new List<Ingrediente> { ingredientes[0], ingredientes[9], ingredientes[10] }, new Tipo("Grande", 200.0), "32");

            Pizza pizza15 = new("Marinera", new List<Ingrediente> { ingredientes[0], ingredientes[11] }, new Tipo("Chica", 200.0), "45");
            Pizza pizza16 = new("Marinera", new List<Ingrediente> { ingredientes[0], ingredientes[11] }, new Tipo("Mediana", 250.0), "45");
            Pizza pizza17 = new("Marinera", new List<Ingrediente> { ingredientes[0], ingredientes[11] }, new Tipo("Grande", 300.0), "45");

            Pizza pizza18 = new("Peperoni", new List<Ingrediente> { ingredientes[0], ingredientes[12] }, new Tipo("Chica", 100.0), "30");
            Pizza pizza19 = new("Peperoni", new List<Ingrediente> { ingredientes[0], ingredientes[12] }, new Tipo("Mediana", 150.0), "30");
            Pizza pizza20 = new("Peperoni", new List<Ingrediente> { ingredientes[0], ingredientes[12] }, new Tipo("Grande", 200.0), "30");

            Pizza pizza21 = new("Anchoas", new List<Ingrediente> { ingredientes[0], ingredientes[10] }, new Tipo("Chica", 100.0), "29");
            Pizza pizza22 = new("Anchoas", new List<Ingrediente> { ingredientes[0], ingredientes[10] }, new Tipo("Mediana", 150.0), "29");
            Pizza pizza23 = new("Anchoas", new List<Ingrediente> { ingredientes[0], ingredientes[10] }, new Tipo("Grande", 200.0), "29");

            pizzas.Add(pizza);
            pizzas.Add(pizza1);
            pizzas.Add(pizza2);
            pizzas.Add(pizza3);
            pizzas.Add(pizza4);
            pizzas.Add(pizza5);
            pizzas.Add(pizza6);
            pizzas.Add(pizza7);
            pizzas.Add(pizza8);
            pizzas.Add(pizza9);
            pizzas.Add(pizza10);
            pizzas.Add(pizza11);
            pizzas.Add(pizza12);
            pizzas.Add(pizza13);
            pizzas.Add(pizza14);
            pizzas.Add(pizza15);
            pizzas.Add(pizza16);
            pizzas.Add(pizza17);
            pizzas.Add(pizza18);
            pizzas.Add(pizza19);
            pizzas.Add(pizza20);
            pizzas.Add(pizza21);
            pizzas.Add(pizza22);
            pizzas.Add(pizza23);

            foreach (Pizza p in pizzas)
            {
                p.MostrarInfo();
            }
        }
        private static void CrearIngredientes()
        {
            ingredientes = new List<Ingrediente>();
            Ingrediente ing1 = new("Queso");
            Ingrediente ing2 = new("Jamón");
            Ingrediente ing3 = new("Tocino");
            Ingrediente ing4 = new("Piña");
            Ingrediente ing5 = new("Pierna");
            Ingrediente ing6 = new("Pollo");
            Ingrediente ing7 = new("Jalapeño");
            Ingrediente ing8 = new("Mayonesa");
            Ingrediente ing9 = new("Atún");
            Ingrediente ing10 = new("Champiñón");
            Ingrediente ing11 = new("Anchoas");
            Ingrediente ing12 = new("Mariscos");
            Ingrediente ing13 = new("Peperoni");
            //Ingrediente ing14 = new("Peperoni");
            ingredientes.Add(ing1);
            ingredientes.Add(ing2);
            ingredientes.Add(ing3);
            ingredientes.Add(ing4);
            ingredientes.Add(ing5);
            ingredientes.Add(ing6);
            ingredientes.Add(ing7);
            ingredientes.Add(ing8);
            ingredientes.Add(ing9);
            ingredientes.Add(ing10);
            ingredientes.Add(ing11);
            ingredientes.Add(ing12);
            ingredientes.Add(ing13);
            foreach (Ingrediente i in ingredientes)
            {
                Console.WriteLine($"{i.Id} - {i.Name}");
            }
        }
    }
}