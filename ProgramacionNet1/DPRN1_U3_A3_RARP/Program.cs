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
            int fila = 4;
            int columna = 10;
            string cara = "%";
            var input = "147812357898";
            var reg = @"\d{3}";
            string result = Regex.Replace(input, reg, " $000");
            Console.WriteLine(result);
            string str = "";

            Console.Write("|");
            Console.Write(str.PadRight(15));
            Console.WriteLine("|");

            //string valor = " ";
            //string valorDos = valor.Insert(0, " ");
            //Console.WriteLine(valorDos.);

            string[,] matriz = new string[fila,columna];
            matriz = IngresarValorVetor(fila, columna,cara);
            ImprimirLetraL(fila, columna, matriz);
            Console.WriteLine();
            ImprimirLetraA(fila, columna, matriz);

            //Llamado el método que realiza la presentación del programa
            //Presentacion();
        }
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {

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
        public static string[,] IngresarValorVetor(int fila, int columna,string caracter)
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


    }
}