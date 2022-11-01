using System;
using System.Collections;
namespace UnidadDosEA
{
    class Program
    {
        static void Main(string[] args)
        {            
            Presentacion();
        }

        public static void Presentacion()
        {
            Produccion produccion = new();
            Console.WriteLine(produccion.Piezas(950000, 7, 1, 2, "enero"));

            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de construcción de vehiculos de Tesla");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Mostrar cantidad de componentes de los autos.");
                Console.WriteLine("2. Mostrar costo de los autos");
                Console.WriteLine("3. Mostrar producción mensual de los autos");
                Console.WriteLine("4. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder mostrar la información de todos los ingredientes disponibles
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1, los componentes de los vehiculos son:");
                        //ImpresionIngredientes();
                        InfoComponentes(produccion);
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar los ingredientes por categoría
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        Console.WriteLine($"Costo del auto: ${produccion.CostoAuto()}");
                        Console.WriteLine($"Costo de la camioneta: ${produccion.CostoCamioneta()}");
                        Console.WriteLine($"Costo de la van: ${produccion.CostoVan()}");
                        //BuscarIngrediente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar las calorias de los ingredientes por peso
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        //BuscarIngredienteCaloria();
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
        public static void InfoComponentes(Produccion produccion)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine($"Componentes del auto: \n{produccion.Auto.DatosVehiculo()}");
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine($"Componentes de la camioneta: \n{produccion.Camioneta.DatosVehiculo()}");
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine($"Componentes de la van: \n{produccion.Van.DatosVehiculo()}");
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
