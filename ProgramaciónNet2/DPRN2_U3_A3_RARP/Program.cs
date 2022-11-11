namespace UnidadTresA3
{
    class Program
    {
        //Declaración de la variable global de la aplicación
        public static MonedaVirtual moneda = null;
        public static MonedasVirtual monedas = new();
        public static Cartera cartera = new("Raúl","Ramirez",1500.0);

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
            Console.WriteLine("Bienvenidos al sistema de alta y compra de monedas virtuales");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Mostrar las monedas disponibles para comprar.");
                Console.WriteLine("2. Comprar moneda virtual");
                Console.WriteLine("3. Mostrar información de la cartera");
                Console.WriteLine("4. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de las monedas
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        monedas.MostrarMonedas();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la compra de monedas virtuales
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        if (cartera.Presupuesto != 0.0)
                        {
                            try
                            {
                                moneda = new MonedaVirtual();
                                monedas.MostrarMonedasPorID();
                                int op = ValidarNumero("Selecciona una moneda para comprar: ");
                                moneda = monedas.Monedas[op - 1];
                                double montoInvertir = ValidarNumeroDouble("Ingresa el monto a invertir: ");
                                if (cartera.Presupuesto < montoInvertir)
                                {
                                    Console.WriteLine($"{cartera.Nombre} {cartera.Apellido}, no cuentas con suficiente presupuesto");
                                }
                                else
                                {
                                    double monedasCompradas = montoInvertir / moneda.Precio;
                                    Console.WriteLine($"Se han comprado {monedasCompradas} monedas {moneda.Nombre}");
                                    cartera.GuardarInformacion(moneda, monedasCompradas, montoInvertir);
                                }

                            }
                            catch (ArgumentOutOfRangeException ex)
                            {
                                Console.WriteLine("No se ha seleccionado una opción del menú, vuelve seleccionar la opcion 2");
                                moneda = null;
                            }
                            finally
                            {
                                moneda = null;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{cartera.Nombre} {cartera.Apellido}, ya no cuentas con suficiente saldo para comprar monedas virtuales");
                        }
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar la cartera del usuario
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        cartera.MostrarCarteraVitual();
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
    }
}
