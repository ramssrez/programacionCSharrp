﻿namespace UnidadDosA1
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
            
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine(StringProyect.BIENVENIDO);
                Console.WriteLine(StringProyect.OPCIONES_MENU);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para mostrar y modificar información de la lista de drones tipo Tricópteros
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        SeleccionListas(drones.TricopteroList);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para mostrar y modificar información de la lista de drones tipo Cuadricóptero
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        SeleccionListas(drones.CuadricopteroList);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para mostrar y modificar información de la lista de drones tipo Hexacóptero
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        SeleccionListas(drones.HexacopteroList);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 4:
                        //Caso para mostrar y modificar información de la lista de drones tipo Coaxial
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        SeleccionListas(drones.CoaxialList);
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

        private static void SeleccionListas(List<Coaxial> coaxialList)
        {
            throw new NotImplementedException();
        }

        private static void SeleccionListas(List<Hexacoptero> hexacopteroList)
        {
            throw new NotImplementedException();
        }

        private static void SeleccionListas(List<Cuadricoptero> cuadricopteros)
        {
            //throw new NotImplementedException();
            Console.WriteLine(StringProyect.STRING_FORMATO);
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones y presentación
                Console.WriteLine(StringProyect.STRING_MENU_SECUNDARIO);
                Console.WriteLine(StringProyect.OPCIONES_MENU_SECUNDARIO);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para la creación de un nuevo dron
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //Instancia para recuperar los datos que ingrese el usuario
                        Cuadricoptero cr = CreacionCuadricoptero();
                        Console.WriteLine(StringProyect.CREANDO_DRON);
                        Console.WriteLine(StringProyect.CreacionDron(cr.NumeroSerie));
                        //Agregación de un nuevo Dron a la lista de drones
                        cuadricopteros.Add(cr);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para la selección de un dron de la lista que se tiene 
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //SeleccionTricoptero(tricopteros);
                        SeleccionCuadricoptero(cuadricopteros);
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



        //Método que permite la creación de un menú secundario para la lista de los drones seleccioando
        private static void SeleccionListas(List<Tricoptero> tricopteros)
        {
            Console.WriteLine(StringProyect.STRING_FORMATO); 
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones y presentación
                Console.WriteLine(StringProyect.STRING_MENU_SECUNDARIO);
                Console.WriteLine(StringProyect.OPCIONES_MENU_SECUNDARIO);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para la creación de un nuevo dron
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        //Instancia para recuperar los datos que ingrese el usuario
                        Tricoptero tr = CreacionTricoptero();
                        Console.WriteLine(StringProyect.CREANDO_DRON);
                        Console.WriteLine(StringProyect.CreacionDron(tr.NumeroSerie));
                        //Agregación de un nuevo Dron a la lista de drones
                        tricopteros.Add(tr);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para la selección de un dron de la lista que se tiene 
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        SeleccionTricoptero(tricopteros);
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
        private static void SeleccionCuadricoptero(List<Cuadricoptero> cuadricopteros)
        {
            Console.WriteLine(StringProyect.SELECCION_DRON_LISTA);
            //Ciclo for que imprime todo los drones de la lista
            for (int i = 0; i < cuadricopteros.Count; i++)
            {
                Console.WriteLine(StringProyect.SeleccionDronLista(i, cuadricopteros[i].NumeroSerie));
            }
            int dronSeleccionado = ValidarNumero(StringProyect.SELECCION_DRON);
            //Sentencia para el caso de que el usuario no haya seleccioanado una opción de los drones
            if (dronSeleccionado >= 0 && dronSeleccionado < cuadricopteros.Count)
            {
                Opcionescuadricopteros(cuadricopteros, dronSeleccionado);
            }
            else
            {
                Console.WriteLine(StringProyect.NO_SELECCION_DRON);
            }
        }

        private static void Opcionescuadricopteros(List<Cuadricoptero> cuadricopteros, int dronSeleccionado)
        {
            Console.WriteLine(StringProyect.STRING_FORMATO);
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones y presentación
                Console.WriteLine(StringProyect.SeleccionDron(cuadricopteros[dronSeleccionado].NumeroSerie));
                Console.WriteLine(StringProyect.OPCIONES_MENU_SECUNDARIO_DRON);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para que se muetre la información del dron
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(cuadricopteros[dronSeleccionado].MostrarInformacion());
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para modificar los datos del dron
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        ModificarDatosDron(cuadricopteros, dronSeleccionado);
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
            //throw new NotImplementedException();
        }

        private static void ModificarDatosDron(List<Cuadricoptero> cuadricopteros, int dronSeleccionado)
        {

            throw new NotImplementedException();
        }

        //Método que muestra la lista de drones tricopteros para poder seleccionar uno de ellos
        private static void SeleccionTricoptero(List<Tricoptero> tricopteros)
        {
            Console.WriteLine(StringProyect.SELECCION_DRON_LISTA);
            //Ciclo for que imprime todo los drones de la lista
            for (int i = 0; i < tricopteros.Count; i++)
            {
                Console.WriteLine(StringProyect.SeleccionDronLista(i, tricopteros[i].NumeroSerie));
            }
            int dronSeleccionado = ValidarNumero(StringProyect.SELECCION_DRON);
            //Sentencia para el caso de que el usuario no haya seleccioanado una opción de los drones
            if (dronSeleccionado >= 0 && dronSeleccionado < tricopteros.Count)
            {
                OpcionesTricopteros(tricopteros, dronSeleccionado);
            }
            else
            {
                Console.WriteLine(StringProyect.NO_SELECCION_DRON);
            }
        }
        //Método que muestra la opciones que se puede realizar al seleccionar un dron
        private static void OpcionesTricopteros(List<Tricoptero> tricopteros, int dron)
        {
            Console.WriteLine(StringProyect.STRING_FORMATO);
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones y presentación
                Console.WriteLine(StringProyect.SeleccionDron(tricopteros[dron].NumeroSerie));
                Console.WriteLine(StringProyect.OPCIONES_MENU_SECUNDARIO_DRON);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para que se muetre la información del dron
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        Console.WriteLine(tricopteros[dron].MostrarInformacion());
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para modificar los datos del dron
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        ModificarDatosDron(tricopteros,dron);
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
        //Menú que permite modificar los atributos del dron
        private static void ModificarDatosDron(List<Tricoptero> tricopteros, int dron)
        {
            Console.WriteLine(StringProyect.STRING_FORMATO); 
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones así como la presentación del submenu
                Console.WriteLine(StringProyect.STRING_MENU_SECUNDARIO);
                Console.WriteLine(StringProyect.OPCIONES_MENU_DRON_UPDATE);
                int opcion = ValidarNumero(StringProyect.OPCION_MENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para modificar el peso del dron
                    case 1:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        tricopteros[dron].Peso = VerificarMayorCero(StringProyect.INGRESO_PESO_DRON);
                        Console.WriteLine(StringProyect.SUCCESS_PESO_DRON);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para modificar la velocidad de vuelo
                    case 2:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        tricopteros[dron].VelocidadVuelo = VerificarMayorCero(StringProyect.INGRESO_VELOCIDAD_DRON);
                        Console.WriteLine(StringProyect.SUCCESS_VELOCIDAD_DRON);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para modificar la energia de impacto
                    case 3:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        tricopteros[dron].EnergiaImpacto = VerificarMayorCero(StringProyect.INGRESO_ENERGIA_IMPACTO);
                        Console.WriteLine(StringProyect.SUCCESS_ENERGIA_IMPACTO);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para modificar el ancho del dron
                    case 4:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        tricopteros[dron].Dimension.Ancho = VerificarMayorCero(StringProyect.INGRESO_ANCHO_DRON);
                        Console.WriteLine(StringProyect.SUCCESS_ANCHO_DRON);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para modificar la altura del dron
                    case 5:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        tricopteros[dron].Dimension.Altura = VerificarMayorCero(StringProyect.INGRESO_ALTURA_DRON);
                        Console.WriteLine(StringProyect.SUCCESS_ALTURA_DRON);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para modificar la base del dron
                    case 6:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        tricopteros[dron].Dimension.BaseDron = VerificarMayorCero(StringProyect.INGRESO_BASE_DRON);
                        Console.WriteLine(StringProyect.SUCCESS_BASE_DRON);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    //Caso para modificar la potencia del motor trasero del dron
                    case 7:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.OpcionMenu(opcion));
                        tricopteros[dron].PotenciaMotorTrasero = VerificarMayorCero(StringProyect.INGRESO_MOTOR_TRASERO_DRON);
                        Console.WriteLine(StringProyect.SUCCESS_MOTOR_TRASERO_DRON);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                    case 8:
                        //Opción para la salida del programa
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.SALIR_MENU_SECUNDARIO);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción del menú
                    default:
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        Console.WriteLine(StringProyect.RANGO_OPCIONES_TRES);
                        Console.WriteLine(StringProyect.STRING_FORMATO);
                        break;
                }
            }
        }
        //Método que permite la creación de un cuadricóptero con la información que agregue el cliente
        private static Cuadricoptero CreacionCuadricoptero()
        {
            double peso = VerificarMayorCero(StringProyect.INGRESO_PESO_DRON);
            double energiaImpacto = VerificarMayorCero(StringProyect.INGRESO_ENERGIA_IMPACTO);
            double velocidad = VerificarMayorCero(StringProyect.INGRESO_VELOCIDAD_DRON);
            double ancho = VerificarMayorCero(StringProyect.INGRESO_ANCHO_DRON);
            double altura = VerificarMayorCero(StringProyect.INGRESO_ALTURA_DRON);
            double baseDron = VerificarMayorCero(StringProyect.INGRESO_BASE_DRON);
            double vueloMaximo = VerificarMayorCero(StringProyect.INGRESO_ALTITUD_MAXIMA_DRON);
            //Retorno del hexacóptero creado
            return new Cuadricoptero(StringProyect.CUADRICOPTERO, vueloMaximo, 4, peso, energiaImpacto, velocidad, new Dimension(altura, ancho, baseDron));
        }
        //Método que permite la creación de un tricóptero con la información que agregue el cliente
        private static Tricoptero CreacionTricoptero()
        {
            //Intancia de las variables necesarias para la creación del objeto Tricoptero
            double peso = VerificarMayorCero(StringProyect.INGRESO_PESO_DRON);
            double energiaImpacto = VerificarMayorCero(StringProyect.INGRESO_ENERGIA_IMPACTO);
            double velocidad = VerificarMayorCero(StringProyect.INGRESO_VELOCIDAD_DRON);
            double ancho = VerificarMayorCero(StringProyect.INGRESO_ANCHO_DRON);
            double altura = VerificarMayorCero(StringProyect.INGRESO_ALTURA_DRON);
            double baseDron = VerificarMayorCero(StringProyect.INGRESO_BASE_DRON);
            double potencia = VerificarMayorCero(StringProyect.INGRESO_MOTOR_TRASERO_DRON);
            Tricoptero tricoptero = new Tricoptero(StringProyect.TRICOPTERO, potencia, 3, peso, energiaImpacto, velocidad, new Dimension(altura, ancho, baseDron));
            //Retorno del tricoptero creado
            return tricoptero;
        }
        //Método que permite la verificación de que el valor ingresado por el usuario sea mayor a cero
        private static double VerificarMayorCero(string v)
        {
            bool salida = false;
            double valor = 0;
            //Utilización del ciclo while que solicita el valor hasta que sea un número mayor a cero
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