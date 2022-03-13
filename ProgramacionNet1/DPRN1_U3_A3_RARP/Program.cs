using System;
namespace UnidadTresA3
{
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            int fila = 4;
            int columna = 5;
            string cara = "S";
            string[,] matriz = new string[fila,columna];
            matriz = IngresarValorVetor(fila, columna,cara);
            ImprimirLetraL(fila, columna, matriz);

            //Llamado el método que realiza la presentación del programa
            //Presentacion();
        }
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {

        }

        public static void ImprimirLetraL(int fila, int columna, string[,] matriz)
        {
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {

                    if (c == 0 && f <= fila)
                    {
                        Console.Write(matriz[f, c] + " ");
                    } else if (f == (fila-1) && c >0)
                    {
                        Console.Write(matriz[f, c] + " ");
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