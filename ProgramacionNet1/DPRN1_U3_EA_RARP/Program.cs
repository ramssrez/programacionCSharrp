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
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema para transformar tu número en binario");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Ingresar datos");
                Console.WriteLine("2. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos necesarios para la impresión del número
                    case 1:
                        Console.WriteLine("Has elegido la opción 1");
                        IngresoDatosMatriz();
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
        //Método que llama a los otros metodos para poder realizar las operaciones necesarias
        public static void IngresoDatosMatriz()
        {
            //Declaración del número y llamada del método que verifica el número ingresado
            int numero = ValidarNumero("Ingresa el múmero del jugador: ");
            //Sentencia if/else para el caso de que en la consola se ingrese un valor negativo
            if (numero < 0)
            {
                Console.WriteLine("No hay números negativos");
            }
            else //En caso contrario continuar con el proceso del programa
            {
                //Llamado al método que asigna el valor de la fila/columna y el caracter con la verificación del número ingresado
                (int valorFila, string caracter) = ValoresMatriz(numero);
                //Declaración de la matriz de nxn
                string[,] matriz = new string[valorFila, valorFila];
                //Llenado de la matriz con el valor de la fila y el caracter ingresado por el usuario
                matriz = IngresarValorVetor(valorFila, caracter);
                //Metodo que retorna el binario del número ingresado por el usuario
                string binario = NumeroBinario(numero);
                //Método que imprime el binario del número ingresado por el usuario
                ImprimirBinario(binario, valorFila, matriz);
            }

        }
        //Método que imprime el binario del número ingresado desde la consola
        public static void ImprimirBinario(string binario, int valorFila, string [,] matriz)
        {
            //Mensaje de salida para el usuario con el binario del número ingresado
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Número del jugador en binario es: ");
            //Ciclo for para recorrer el string del binario
            for (int i = 0; i < binario.Length; i++)
            {
                //Condicional if para verificar si hay un uno en el binario
                if (binario[i] == '1')
                {
                    //En caso verdadero imprime la matriz para el digito uno
                    ImprimirUno(valorFila, matriz);
                }
                //En caso contrario se busca si tiene un cero dentro del binario
                else if (binario[i] == '0')
                {
                    //En caso de que haya un cero de imprime la matriz para el digito cero
                    ImprimirCero(valorFila, matriz);
                }
                Console.WriteLine();
            }
        }
        //Método que asigna el valor de la fila/columna de la matriz y el caracter con el número ingresado
        public static (int, string) ValoresMatriz(int numero)
        {
            //Declaración de variables para poder realizar las operaciones necesarias
            int valorFila = 0;
            string caracter = "";
            //Sentencia if/else para asignar el número de fila/columna de la matriz y su caracter en función del número ingresado
            if (numero >= 0 && numero <= 11)
            {
                valorFila = 7;
                caracter = "#";
            }
            else if (numero > 11 && numero <= 50)
            {
                valorFila = 6;
                caracter = "*";
            }
            else if (numero > 50)
            {
                valorFila = 5;
                caracter = "@";
            }
            //Retorno del valor de la fila/columna como del caracter
            return (valorFila, caracter);
        }
        //Método que crear un string que hace referencia al binario del número ingresado
        public static string NumeroBinario(int numero)
        {
            //Declaración de variables necesarias para poder realizar el calculo del binario
            int remanente;
            string binario = string.Empty; 
            //Sentencia if/else para el caso de que sea Cero el número ingresado
            if (numero == 0)
            {
                binario = "0";
            }

            //Ciclo while para el caso de que el número sea mayor a cero
            while (numero > 0)
            {
                //Calculo del remanente del numero
                remanente = numero % 2;
                //Calculo de la division del numero entre dos
                numero /= 2;
                //Asignación del remanente al string
                binario = remanente.ToString() + binario;
            }
            //Retorno del binario a partir del número
            return binario;
        }
        //Método que llena a la matriz con el caracter seleccionado
        public static string[,] IngresarValorVetor(int valor, string caracter)
        {
            //Declaración de la matriz de nxn
            string[,] matriz = new string[valor, valor];
            //Uso del primer for que representa las filas de la matriz
            for (int f = 0; f < valor; f++)
            {
                //Uso del segundo for que representa las columnas de la matriz
                for (int c = 0; c < valor; c++)
                {
                    //Llenado de todos los espacios de la matriz con el caracter seleccionado.
                    matriz[f, c] = caracter;
                }
            }
            //Retorno de la matriz
            return matriz;
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
                }catch (OverflowException)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine("Número demasiado grande, intenta con otro número");
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
        //Método que imprime el número uno de la matriz
        public static void ImprimirUno(int valor, string[,] matriz)
        {
            //Uso del primer for que representa las filas de la matriz
            for (int f = 0; f < valor; f++)
            {
                //Uso del segundo for que representa las columnas de la matriz
                for (int c = 0; c < valor; c++)
                {
                    //Sentencias if/else para las diferentes opciones para la impresión del número Uno
                    if (c == 0 && f <= valor)
                    {
                        Console.Write("  "+matriz[f, c]);
                    }

                }
                Console.WriteLine();
            }
        }
        //Método que imprime el número cero de la matriz.
        public static void ImprimirCero(int valor, string[,] matriz)
        {
            //Declaración de un string vacio
            string espacio = "";
            //Uso del primer for que representa las filas de la matriz
            for (int f = 0; f < valor; f++)
            {
                //Uso del segundo for que representa las columnas de la matriz
                for (int c = 0; c < valor; c++)
                {
                    //Uso de if, else para la impresión de los caracteres para la impresión del cero
                    if (c == 0 && f <= valor)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    
                    else if (f == 0)
                    {
                        Console.Write(matriz[f, c]);
                    }                    
                    else if (f == valor-1)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    
                    else if (c == ( valor - 1) && f <= valor)
                    {
                        //Para este caso se hacer uso de un metodo del string para poder darle espacio vacios entre caracter a otro
                        Console.Write(espacio.PadRight(valor - 2) + matriz[f, c]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}