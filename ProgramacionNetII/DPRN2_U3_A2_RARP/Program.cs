using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Ingresa el año de nacimiento ");
            int s = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(s);
            if (s > 2006)
            {
                throw new YearException("El año de nacimiento es mayor a 2006");
            }
            string cadena = null;
            int numero = int.Parse(cadena);
            int[] arreglo = { 1, 2, 3 };
            Console.WriteLine(arreglo[4]);
            object obj = "Hola";
            int entero = (int)obj;
            /*
            int resultado = 10 / 0;
            Console.WriteLine(resultado);
            */
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"ERORR: {ex.Message}");
        }catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"ERORR: {ex.Message}");
        }catch(InvalidCastException ex)
        {
            Console.WriteLine($"ERORR: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"ERORR: {ex.Message}");
        }
        catch (YearException ex)
        {
            Console.WriteLine($"ERORR: {ex.Message}");
        }


    }
}

[Serializable]
internal class YearException : Exception
{
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