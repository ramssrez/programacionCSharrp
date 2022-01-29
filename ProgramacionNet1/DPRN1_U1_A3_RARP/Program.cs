//Declaración de las biblitecas utilizadas
using System;
namespace UnidadUnoA3
{
    /*
     * Un investigador necesita un programa para calcular el valor de la siguiente función matemática, 
     * el investigador desea ingresar por teclado el valor de x y el valor de k (donde k es cualquier número real). 
     * Finalmente necesita que el programa determine el resultado de la función dependiendo los valores ingresados.
     */
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Instancia del objeto de tipo Presentación el cual retorna información
            Console.WriteLine("*************************************************************************************");
            Presentacion presentacion = new Presentacion();
            presentacion.ToString();

            //Declaración de variables necesarias para el desarrollo del programa
            double xValor, kValor;
       
            //Presentación del programa de lo que realizar
            Console.Write("El siguiente programa realiza el cálculo de una función, con los parámetros de entrada como los son x y k \n");
            Console.Write("Ingresa el valor de x: ");
            //Lectura del valor de x con su respectivo parseo del tipo de datos
            xValor = double.Parse(Console.ReadLine());
            //Lectura del valor de k con su respectivo parseo del tipo de datos
            Console.Write("Ingresa el valor de k: ");
            kValor = double.Parse(Console.ReadLine());

            //Impresión de pantalla del valor de la función de x, con el llamado de un método
            Console.Write("\n");
            Console.Write($"El valor de la función es: f(x)={funcionX(xValor,kValor)}");
            Console.WriteLine("\n");
            Console.WriteLine("Gracias por usar este programa, nos vemos");
            Console.WriteLine("*************************************************************************************");


        }
        //Declaracion del método que realizar la verificación de los datos de entrada que el usuario asigno
        static double funcionX(double xValor, double kValor)
        {
            //Declaración del valor de retorno
            double funcion = 0;
            //Sentencia if/else anidado para validar los datos de entrada con lo que ingresa el usuario
            if (xValor <= 0)
            {
                double valorCambio = -(xValor);
                funcion = Math.Sqrt(valorCambio);
            }
            else if (xValor <= 4 && xValor > 0)
            {
                double valor = xValor * kValor;
                funcion = Math.Sin(valor);
            }
            else
            {
                funcion = 4 + 3 * xValor - (xValor * xValor);
            }
            //Retorno del valor que se obtuvo de la función
            return funcion;
        }
    }
    //Declaración de la clase Presentación
    class Presentacion
    {
        //Declaración del constructor sin parámetros de entrada y la impresión de los datos
        public Presentacion()
        {
            //Decalración de parámetros necesarios para la impresión de los datos
            string nombre = "Raúl Ramírez Pérez";
            string matricula = "ES1921023412";
            string actividad = "Actividad 3 Resolver problemas con C#";
            //Impresión de bienvenida de los datos previamente asignados
            Console.WriteLine("Bienvenido a la actividad número 3 de esta unidad DPRN1_U1_A3_RARP");
            Console.WriteLine($"Programa desarrollado por: {nombre}");
            Console.WriteLine($"Matricula: {matricula}");
            Console.WriteLine($"Actividad: {actividad}");
            //Impresión de la fecha del sistema con el uso de la clase DateTime.Now para obtenerla del sistema
            Console.WriteLine($"Fecha del sistema: {DateTime.Now}");
            Console.Write("\n");
        }

    }

}