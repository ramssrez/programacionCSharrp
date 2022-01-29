using System;
namespace UnidadUnoA3
{
    /*
     * Un investigador necesita un programa para calcular el valor de la siguiente función matemática, 
     * el investigador desea ingresar por teclado el valor de x y el valor de k (donde k es cualquier número real). 
     * Finalmente necesita que el programa determine el resultado de la función dependiendo los valores ingresados.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Presentacion presentacion = new Presentacion();
            presentacion.ToString();
            double xValor, kValor, funcion = 0;
            
            Console.Write("El siguiente programa realiza el cálculo de una función, con los parámetros de entrada como los son x y k \n");
            Console.Write("Ingresa el valor de x: ");
            xValor = double.Parse(Console.ReadLine());
            
            Console.Write("Ingresa el valor de k: ");
            kValor = double.Parse(Console.ReadLine());
            Console.WriteLine($"El valor de x es: {xValor}");
            Console.WriteLine($"El valor de k es: {kValor}");

            if (xValor <= 0)
             {
                Console.WriteLine("dentro de menor a x");
                double valorCambio = -(xValor);
                funcion = Math.Sqrt(valorCambio);
             }else if(xValor <=4 && xValor >0)
            {
                Console.WriteLine("dentro de mayor a cero y menor a 4");
                double valor = xValor * kValor;
                funcion = Math.Sin(valor);
            }
            else
            {
                Console.WriteLine("Valor mayor a 4");
                funcion = 4 + 3 * xValor - (xValor *xValor);
            }
            

            Console.Write($"El valor de la función es: f(x)={funcion}");

        }
    }

    class Presentacion
    {
        public Presentacion()
        {
            //String nombre = "Nombre del autor, matrícula y título de la actividad así como la fecha y hora actual";
            string nombre = "Raúl Ramírez Pérez";
            string matricula = "ES1921023412";
            string actividad = "Actividad 3 Resolver problemas con C#";

            Console.WriteLine("Bienvenido a la actividad número 3 de esta unidad DPRN1_U1_A3_RARP");
            Console.WriteLine($"Programa desarrollado por: {nombre}");
            Console.WriteLine($"Matricula: {matricula}");
            Console.WriteLine($"Actividad: {actividad}");
            Console.WriteLine($"Fecha del sistema: {DateTime.Now}");
            Console.Write("\n");
        }

    }

}