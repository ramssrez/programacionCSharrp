using System;
using System.Text.RegularExpressions;
namespace UnidadTresA3
{
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            Presentacion();
        }
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema para imprimir LA con un tipo de caracter");
            int fila = ValidarNumero("Ingresa el valor de la fila: ");
            int columna = ValidarNumero("Ingresa el valor de la columna: ");
            string caracter = ValidarSoloCaracter("Ingrese el caracter: ");
            string[,] matriz = new string[fila, columna];
            matriz = IngresarValorVetor(fila, columna, caracter);
            ImprimirLetraL(fila, columna, matriz);
            Console.WriteLine();
            ImprimirLetraA(fila, columna, matriz);
            Console.WriteLine();

        }
        public static bool EsIgualMayorCuatro(int valor)
        {
            bool validacion = false;
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
        public static int ValidarNumero(string mensaje)
        {
            bool salir = false;
            int valor = 0;
            while (!salir)
            {
                try
                {
                    Console.Write(mensaje);
                    valor = Convert.ToInt32(Console.ReadLine());
                    salir = EsIgualMayorCuatro(valor);
                }
                catch (FormatException ex)
                {
                   Console.WriteLine("Error al ingresa valor, vuelve a intentarlo");
                }
            }
            return valor;
        }
        public static bool EsNuloCaracter(string s)
        {
            bool validacion = false;
            if (s.Length == 0)
            {
                Console.WriteLine("El caracter no tiene que ser nulo");
            }
            else if (s.Length > 1)
            {
                Console.WriteLine("Solo tiene que ser un caracter ");
            }
            else
            {
                validacion = true;
            }
            return validacion;
        }
        public static string ValidarSoloCaracter(string mensaje)
        {
            bool salir = false;
            string s = "";
            while (!salir)
            {
                Console.Write(mensaje);
                s = Console.ReadLine();
                salir = EsNuloCaracter(s);    
            }
            return s;
        }
        public static void ImprimirLetraA(int fila, int columna, string[,] matriz)
        {
            string espacio = "";
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    
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
                        Console.Write(espacio.PadRight(columna-2) + matriz[f, c]);
                    }
                }
                Console.WriteLine();

            }
        }
        public static void ImprimirLetraL(int fila, int columna, string[,] matriz)
        {
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
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
        public static string[,] IngresarValorVetor(int fila, int columna, string caracter)
        {
            string[,] ejemplo = new string[fila, columna];
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    ejemplo[f, c] = caracter;
                }
            }
            return ejemplo;
        }
        /*
        public static void PruebaTotal(int fila, int col)
        {
            string espacio = "";
            int columaTotal = (col * 2) + 1;
            string[,] matriz = IngresarValorVetor(fila,columaTotal,"&");
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columaTotal; c++)
                {
                    if (c == 0 && f <= fila)
                    {
                        Console.Write(matriz[f, c]);
                    }                    
                    else if (f == (fila - 1) && c > 0 && c<=col-1)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    
                    else if (c == (col+1) && f < fila-1)
                    {
                        Console.Write(espacio.PadRight(col) + matriz[f, c]);
                    }
                    else if (c == (col + 1) && f <= fila)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    
                    else if (f == 0)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    else if (f == 2)
                    {
                        Console.Write(matriz[f, c]);
                    }
                    else if (c == (columaTotal - 1) && f <= fila)
                    {
                        Console.Write(espacio.PadRight(columaTotal - 2) + matriz[f, c]);
                    }
                    

                    //Console.Write("+");

                }
                Console.WriteLine();
            }

        }
        */


    }
}