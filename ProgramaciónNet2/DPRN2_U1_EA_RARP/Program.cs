using System;
using System.Collections;
namespace UnidadUnoEA
{
    class Program
    {
        public static Pastel pastel = new Pastel();
        public static Ingredientes ingredientes = new Ingredientes();

        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Pastel pastel = new Pastel();
            //Ingrediente ingrediente = new Ingrediente();

            Presentacion();
        }
        public static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de pedidos de Pasteles Delicioso");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Mostrar ingredientes diponibles totales");
                Console.WriteLine("2. Mostrar información de los ingrediente");
                Console.WriteLine("3. Mostrar información de calorias por peso");
                Console.WriteLine("4. Realizar pedido");
                Console.WriteLine("5. Mostrar información del pedido");
                Console.WriteLine("6. Cerrar pedido");
                Console.WriteLine("7. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de los personajes
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1, los ingredientes disponibles son:");
                        ImpresionIngredientes();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder elegir un personaje
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        BuscarIngrediente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder realizar la pelea del personaje seleccionado
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        BuscarIngredienteCaloria();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Caso para poder realizar el ataque del personaje
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        RealizarPedido();
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
        private static void RealizarPedido()
        {
            Console.WriteLine("**********************************************************************************************");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                Console.WriteLine("Selecciona el tamaño del pastel");
                //Impresión de los diferentes opciones con las quese cuenta
                Console.WriteLine("1. Pequeño");
                Console.WriteLine("2. Mediano");
                Console.WriteLine("3. Grande");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                if (opcion == 1)
                {
                    Tamanio tamanio = new Tamanio(1, "Pequeño", "4 Rebanadas");
                    pastel.Rendimiento = tamanio;
                    salir = true;

                }
                else if (opcion == 2)
                {
                    Tamanio tamanio = new Tamanio(2, "Mediano", "8 Rebanadas");
                    pastel.Rendimiento = tamanio;
                    salir = true;

                }
                else if (opcion == 3)
                {
                    Tamanio tamanio = new Tamanio(3, "Grande", "16 Rebanadas");
                    pastel.Rendimiento = tamanio;
                    salir = true;
                }
                else
                {
                    Console.WriteLine("No se ha seleccionado una opción del menú");
                }
            }
            salir = false;
            while (!salir)
            {
                Console.WriteLine("Selecciona el Pan del Pastel");
                //Impresión de los diferentes opciones con las que se cuenta
                for(int i = 0;i< ingredientes.IngredientesPan().Count; i++)
                {
                    Console.WriteLine($"{i}. {ingredientes.IngredientesPan()[i].Nombre}");
                }
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                for (int i = 0; i < ingredientes.IngredientesPan().Count; i++)
                {
                    Console.WriteLine($"Se ejecuta");
                    if (i == opcion)
                    {
                        Console.WriteLine($"Se ha seleccionado Opcion: {opcion} e i: {i}");
                        //pastel.AgregarIngrediente(ingrediente);
                        /*
                        ingrediente = ingredientes.IngredientesPan()[i];
                        Console.WriteLine(ingrediente.RevisarIngrediente());
                        //pastel.AgregarIngrediente(ingrediente);
                        //pastel.Informacion();
                        salir = true;
                        */
                        salir = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"No se ha seleccionado un ingrediente");
                    }
                }
                /*Ingrediente ingrediente = new Ingrediente();
                foreach(Ingrediente i in ingredientes.IngredientesPan())
                {

                }
                */

                /*
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                if (ingredientes.IngredientesPan()[opcion].Equals(opcion))
                {
                    pastel.AgregarIngrediente = tamanio;
                    pastel.Informacion();
                    salir = true;

                }
                */

            }
        }
        //Método que permirte ver las calorías de los ingredientes por categorías por el peso que se ingrese
        private static void BuscarIngredienteCaloria()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Selecciona una categoría del ingrediente");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones con las quese cuenta
                Console.WriteLine("1. Pan");
                Console.WriteLine("2. Relleno");
                Console.WriteLine("3. Glaseado");
                Console.WriteLine("4. Dedicatoria");
                Console.WriteLine("5. Flan");
                Console.WriteLine("6. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.Write("Ingresa el peso del ingrediente: ");
                        string s = Console.ReadLine();
                        Console.WriteLine("************************************ Calorías del Pan ***************************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredientesPan(),float.Parse(s));
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.Write("Ingresa el peso del ingrediente: ");
                        string s1 = Console.ReadLine();
                        Console.WriteLine("************************************ Calorías Relleno *************************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredientesRelleno(), float.Parse(s1));
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.Write("Ingresa el peso del ingrediente: ");
                        string s2 = Console.ReadLine();
                        Console.WriteLine("************************************ Calorías Glaseado ***********************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredienteGlaseado(), float.Parse(s2));
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        Console.WriteLine("**********************************************************************************************");
                        Console.Write("Ingresa el peso del ingrediente: ");
                        string s3 = Console.ReadLine();
                        Console.WriteLine("************************************ Calorías Dedicatoria ***********************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredienteDedicatoria(), float.Parse(s3));
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        Console.WriteLine("**********************************************************************************************");
                        Console.Write("Ingresa el peso del ingrediente: ");
                        string s4 = Console.ReadLine();
                        Console.WriteLine("************************************ Calorías Flan ***********************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredienteFlan(), float.Parse(s4));
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 6:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido salir del menú secundario");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 6");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
            }
        }
        //Método de la impresión de las caracteristicas generales de la lista

        //Método que permite visualizar todos los ingredientes disponibles para realizar las combinaciones
        public static void ImpresionIngredientes()
        {
            //Utilización del ciclo for para visualizar el nombre del ingrediente
            for(int i = 0; i <ingredientes.IngredientesTotales.Count; i++)
            {
                //Impresión de los ingredientes disponibles
                Console.WriteLine($"{i+1}. {ingredientes.IngredientesTotales[i].Nombre}");
            }
        }
        public static void BuscarIngrediente()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Selecciona una categoría del ingrediente");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones con las quese cuenta
                Console.WriteLine("1. Pan");
                Console.WriteLine("2. Relleno");
                Console.WriteLine("3. Glaseado");
                Console.WriteLine("4. Dedicatoria");
                Console.WriteLine("5. Flan");
                Console.WriteLine("6. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("************************************ Datos de la categoría del Pan ***************************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredientesPan());
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 2:
                        Console.WriteLine("************************************ Datos de la categoría del Relleno *************************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredientesRelleno());
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 3:
                        Console.WriteLine("************************************ Datos de la categoría del Glaseado ***********************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredienteGlaseado());
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        Console.WriteLine("************************************ Datos de la categoría de Dedicatoria ***********************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredienteDedicatoria());
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        Console.WriteLine("************************************ Datos de la categoría del Flan ***********************************************");
                        ImpresionIngredienteGeneral(ingredientes.IngredienteFlan());
                        Console.WriteLine("**********************************************************************************************");

                        break;
                    case 6:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido salir del menú secundario");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 6");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
            }
        }
        //Método de la impresión de las caracteristicas generales de la lista
        public static void ImpresionIngredienteGeneral(List<Ingrediente> ingredientesList)
        {
            //Uso de foreach para recorrer la lista de los ingredientes
            foreach (Ingrediente i in ingredientesList)
            {
                Console.WriteLine("**********************************************************************************************");
                Console.WriteLine(i.RevisarIngrediente());
            }
        }
        public static void ImpresionIngredienteGeneral(List<Ingrediente> ingredientesList, float peso)
        {
            //Uso de foreach para recorrer la lista de los ingredientes
            foreach (Ingrediente i in ingredientesList)
            {
                Console.WriteLine(i.RevisarIngrediente(peso));
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
     
    }
}