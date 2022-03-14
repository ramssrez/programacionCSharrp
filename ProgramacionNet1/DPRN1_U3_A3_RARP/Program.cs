using System;
namespace UnidadTresA3
{
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Llamado el método que realiza la presentación del programa
            Presentacion();
        }
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema para imprimir LA con un tipo de caracter");
            //Varaible para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Ingresar datos");
                Console.WriteLine("2. Salir");;
                Console.Write("Ingresa una opción del menú: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos para la impresión de los caracters 
                    case 1:
                        Console.WriteLine("Has elegido la opción 1");
                        IngresarDatos();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Opción para la finalización del programa
                    case 2:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 2");
                        break;
                }
            }

        }
        //Método que ingresa el usuairo desde la consola
        public static void IngresarDatos()
        {
            //Declaración de variables y llamado a los métodos para su declaración
            int fila = ValidarNumero("Ingresa el valor de la fila: ");
            int columna = ValidarNumero("Ingresa el valor de la columna: ");
            string caracter = ValidarSoloCaracter("Ingrese el caracter: ");
            //Declaración de la matriz de n*m
            string[,] matriz = new string[fila, columna];
            //Llamado al método que llena toda la matriz con un caracter
            matriz = IngresarValorVetor(fila, columna, caracter);
            Console.WriteLine($"La letra L con el caracter {caracter} se ve de esta manera");
            Console.WriteLine();
            //Llamado al método para la impresión de la letra L
            ImprimirLetraL(fila, columna, matriz);
            Console.WriteLine();
            Console.WriteLine($"La letra A con el caracter {caracter} se ve de esta manera");
            Console.WriteLine();
            //Llamado del método para la impresion de la letra A
            ImprimirLetraA(fila, columna, matriz);
            Console.WriteLine();
        }
        //Método que verifica que el valor sea igual o mayor a cuatro
        public static bool EsIgualMayorCuatro(int valor)
        {
            bool validacion = false;
            //Uso de la sentencia if/else con las posibles opciones
            if (valor >= 4)
            {
                validacion = true;
            }
            else
            {
                Console.WriteLine("Solicitud no valida, numero tiene que ser mayor a cuatro");
            }
            return validacion;
        }
        //Método que varifica si es un entero el valor ingresado desde la consola, se repite hasta que sea correcto
        public static int ValidarNumero(string mensaje)
        {
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
                    salir = EsIgualMayorCuatro(valor);
                }
                catch (FormatException ex)
                {
                    //Mensaje de error en caso de que no se haya ingresado un entero
                   Console.WriteLine("Error al ingresa valor, vuelve a intentarlo");
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
        //Método que verifica si el string ingresado sea mayoy a uno y no nulo
        public static bool EsNuloCaracter(string s)
        {
            bool validacion = false;
            //Declaración de la sentencia if/else para los casos presentados
            if (s.Length == 0)
            {
                //Opción cuando el string es igual a cero o nulo
                Console.WriteLine("El caracter no tiene que ser nulo");
            }
            else if (s.Length > 1)
            {
                //Opción cuando el string es mayor a uno
                Console.WriteLine("Solo tiene que ser un caracter ");
            }
            else
            {
                validacion = true;
            }
            //Retorno de booleano para continuar con las opciones
            return validacion;
        }
        //Método que reliza la validación de un caracter hasta que se cumpla que sea correcto
        public static string ValidarSoloCaracter(string mensaje)
        {
            bool salir = false;
            string s = "";
            //Ciclo while para verificar las caracteristicas de un caracter
            while (!salir)
            {
                Console.Write(mensaje);
                s = Console.ReadLine();
                salir = EsNuloCaracter(s);    
            }
            //Retorno del string que se ha ingresado
            return s;
        }
        //Método que imprime la letra A desde una matriz.
        public static void ImprimirLetraA(int fila, int columna, string[,] matriz)
        {
            //Declaración de un string vacio
            string espacio = "";
            //Uso del primer for que representa las filas de la matriz
            for (int f = 0; f < fila; f++)
            {
                //Uso del segundo for que representa las columnas de la matriz
                for (int c = 0; c < columna; c++)
                {
                    //Uso de if, else para la impresión de los caracteres de la letra con las diferentes opciones para su impresión 
                    if (c == 0 && f <= fila)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    else if(f == 0)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    else if (f == 2)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    else if (c == (columna - 1) && f <= fila)
                    {
                        //Para este caso se hacer uso de un metodo del string para poder darle espacio vacios entre caracter a otro
                        Console.Write(espacio.PadRight(columna-2) + matriz[f, c]);
                    }
                }
                Console.WriteLine();
            }
        }
        //Método que imprime la letra L desde una matriz
        public static void ImprimirLetraL(int fila, int columna, string[,] matriz)
        {
            //Uso del primer for que representa las filas de la matriz
            for (int f = 0; f < fila; f++)
            {
                //Uso del segundo for que representa las columnas de la matriz
                for (int c = 0; c < columna; c++)
                {
                    //Sentencias if/else para las diferentes opciones para la impresión de la L
                    if (c == 0 && f <= fila)
                    {
                        Console.Write(matriz[f, c]);
                    } else if (f == (fila-1) && c >0)
                    {
                        Console.Write(matriz[f, c]);
                    }
                   
                }
                Console.WriteLine();
            }
        }
        //Método que llena a la matriz con el caracter ingresado por parte del usuario
        public static string[,] IngresarValorVetor(int fila, int columna, string caracter)
        {
            //Declaración de la matriz de nxm
            string[,] matriz = new string[fila, columna];
            //Uso del primer for que representa las filas de la matriz
            for (int f = 0; f < fila; f++)
            {
                //Uso del segundo for que representa las columnas de la matriz
                for (int c = 0; c < columna; c++)
                {
                    //Llenado de todos los espacios de la matriz con el caracter seleccionado.
                    matriz[f, c] = caracter;
                }
            }
            return matriz;
        }     
    }
}