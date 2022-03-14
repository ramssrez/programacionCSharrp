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
            /*
            int fila = ValidarNumero("Ingresa el valor de la fila: ");
            Console.WriteLine(fila);
            int columna = ValidarNumero("Ingresa el valor de la columna: ");
            Console.WriteLine(columna);
            Console.Write("Ingrese el valor del caracter: ");
            */
            string caracter = ValidarSoloCaracter("Ingrese el caracter: ");
            

            Console.WriteLine("caracteres: " + caracter.Length);
           //ValidarNumero("Ingresa el valor de la columna: ");
           Console.WriteLine(caracter);


            /*
            int fila = 5;
            int columna = 5;
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
            Console.WriteLine();
            */

            //PruebaTotal(4,5);

            //Llamado el método que realiza la presentación del programa
            //Presentacion();
        }
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema para imprimir LA con un tipo de caracter");
            Console.Write("Ingresa el tamaño de la fila: ");
            int fila = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el tamaño de la columna: ");
            int columna = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el caracter a imprimir: ");
            string caracter = Console.ReadLine();

            //Varaible para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Área y perímetro de un Trapecio");
                Console.WriteLine("2. Área y perímetro de una Estrella de 6 puntas");
                Console.WriteLine("3. Área y perímetro de un Círculo");
                Console.WriteLine("4. Área y perímetro de una Estrella de 5 puntas");
                Console.WriteLine("5. Salir");
                Console.Write("Ingresa una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {

                }
            }
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