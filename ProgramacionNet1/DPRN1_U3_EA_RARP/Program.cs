using System;
namespace UnidadTresEA
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
            int numero = ValidarNumero("Ingresa el valor de la fila: ");
            Console.WriteLine(numero);
            int fila = ValidarNumero("Ingresa el valor de la fila: ");
            int columna = ValidarNumero("Ingresa el valor de la columna: ");
            string caracter = "#";

            //Declaración de la matriz de n*m
            string[,] matriz = new string[fila, columna];
            //Llamado al método que llena toda la matriz con un caracter
            matriz = IngresarValorVetor(fila, columna, caracter);
            ImprimirUno(fila, columna, matriz);
            ImprimirCero(fila, columna, matriz);

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
                    salir = true;
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
        //Método que imprime la letra L desde una matriz
        public static void ImprimirUno(int fila, int columna, string[,] matriz)
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
                        Console.Write("  "+matriz[f, c]);
                    }

                }
                Console.WriteLine();
            }
        }
        //Método que imprime la letra A desde una matriz.
        public static void ImprimirCero(int fila, int columna, string[,] matriz)
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
                    
                    else if (f == 0)
                    {
                        Console.Write(matriz[f, c]);
                    }                    
                    else if (f == fila-1)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    
                    else if (c == (columna - 1) && f <= fila)
                    {
                        //Para este caso se hacer uso de un metodo del string para poder darle espacio vacios entre caracter a otro
                        Console.Write(espacio.PadRight(columna - 2) + matriz[f, c]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}