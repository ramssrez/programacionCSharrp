using System;
using System.Runtime.Serialization;
//Delclaración de la clase Progra,
class Program
{
    //Declaración del método main para el caso 
    static void Main(string[] args)
    {
        try
        {
            //Solicitud del año de nacimiento del usuario
            Console.Write("Ingresa el año de nacimiento ");
            //Parseo del string a un entero para utilizarlo en el programa
            int s = Convert.ToInt32(Console.ReadLine());
            //Sentencia if/else para verificar que el año sea menor a 2006
            if (s > 2006)
            {
                //Creación de la excepción para el caso de que año de nacimiento sea mayor a 2006 YearExcepcion
                throw new YearException("El año de nacimiento es mayor a 2006");
            }
            //Declaración de la cada nula para posteriormente imprimirla, para ello se hace uso de la 
            //excepcion ArgumentNullException
            string cadena = null;
            int numero = int.Parse(cadena);

            //Declaración de una arreglo con 3 elementos, pero que se solicita la impresión de
            //un elemento del arreglo que no existe, por lo que, se hace uso de la excepción IndexOutOfRangeException
            int[] arreglo = { 1, 2, 3 };
            Console.WriteLine(arreglo[4]);

            //Declaración del objeto de tipo objeto, pero que se solicita parsear a un entero
            //Se hace uso de la excepción InvalidCastException, ya que se trata de parsear un string a un entero
            object obj = "Hola";
            int entero = (int)obj;

            //Declaraicón para un resultado dividido en cero, sin embargo, el IDE lanza un error en la compilación,
            //pero se agrega la excepción DivideByZeroException que lanza un mensaje de que división entre cero
            /*
            int resultado = 10 / 0;
            Console.WriteLine(resultado);
            */
        }
        //Catch para el caso de que el argumento es nulo
        catch (ArgumentNullException ex)
        {
            //Mensaje de salida del error identificado
            Console.WriteLine($"ERORR: {ex.Message}");
        }
        //Catch para el caso de que no exista un indice de un arreglo
        catch (IndexOutOfRangeException ex)
        {
            //Mensaje de salida del error identificado
            Console.WriteLine($"ERORR: {ex.Message}");
        }
        //Catch para el caso de que no se pueda realizar el casteo entre variables
        catch(InvalidCastException ex)
        {
            //Mensaje de salida del error identificado
            Console.WriteLine($"ERORR: {ex.Message}");
        }
        //Catch para el caso de que la división se tenga en el númerado un cero
        catch (DivideByZeroException ex)
        {
            //Mensaje de salida del error identificado
            Console.WriteLine($"ERORR: {ex.Message}");
        }
        //Catch que contiene la excepción personalizada
        catch (YearException ex)
        {
            //Mensaje de salida del error identificado
            Console.WriteLine($"ERORR: {ex.Message}");
        }
    }
}

[Serializable]
//Declaración de la excepción personalizaca
public class YearException : Exception
{
    //Declaración de los constructores para utilizarlos a conveniencia
    public YearException()
    {
    }

    public YearException(string? message) : base(message)
    {
    }

    public YearException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected YearException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}