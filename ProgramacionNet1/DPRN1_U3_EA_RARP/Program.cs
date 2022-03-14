﻿using System;
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
            
            int valorFila = 0;
            string caracter = "";
            if (numero >= 0 && numero <= 11)
            {
                valorFila = 7;
                caracter = "#";
            }
            else if(numero > 11 && numero <= 50){
                valorFila = 6;
                caracter = "*";
            }
            else if (numero > 50)
            {
                valorFila = 5;
                caracter = "@";
            }
            string[,] matriz = new string[valorFila, valorFila];
            //Llamado al método que llena toda la matriz con un caracter
            matriz = IngresarValorVetor(valorFila, caracter);
            /*
            ImprimirUno(valorFila, matriz);
            ImprimirCero(valorFila, matriz);
            */
            string binario = NumeroBinario(numero);
            Console.WriteLine(binario);
            Console.WriteLine("hay uno" + binario.Contains("1"));
            Console.WriteLine("hay cero" + binario.Contains("0"));



            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    ImprimirUno(valorFila, matriz);
                }
                else if(binario[i] == '0') {
                    ImprimirCero(valorFila, matriz);
                }
                /*
                if(binario.Contains("0"))
                {
                    Console.WriteLine("Hay un 0");
                }
                */
                Console.WriteLine();
            }
            
        }
        public static string NumeroBinario(int decimalNumber)
        {
            //int decimalNumber = 15;
            int remainder;
            string binary = string.Empty;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                binary = remainder.ToString() + binary;
            }
            Console.WriteLine($"Binary: {binary}");
            return binary;
        }
        //Método que llena a la matriz con el caracter ingresado por parte del usuario
        public static string[,] IngresarValorVetor(int valor, string caracter)
        {
            //Declaración de la matriz de nxm
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
        public static void ImprimirUno(int valor, string[,] matriz)
        {
            //Uso del primer for que representa las filas de la matriz
            for (int f = 0; f < valor; f++)
            {
                //Uso del segundo for que representa las columnas de la matriz
                for (int c = 0; c < valor; c++)
                {
                    //Sentencias if/else para las diferentes opciones para la impresión de la L
                    if (c == 0 && f <= valor)
                    {
                        Console.Write("  "+matriz[f, c]);
                    }

                }
                Console.WriteLine();
            }
        }
        //Método que imprime la letra A desde una matriz.
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
                    //Uso de if, else para la impresión de los caracteres de la letra con las diferentes opciones para su impresión 
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