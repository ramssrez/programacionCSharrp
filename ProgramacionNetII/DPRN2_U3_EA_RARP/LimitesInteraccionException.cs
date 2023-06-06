using System.Runtime.Serialization;

namespace UnidadTresEA
{
    //Declaración de la clase para manejo de exepciones
    public class LimitesInteraccionException : Exception
    {
        //Declaración de diferentes tipos de contructores para su utilización
        public LimitesInteraccionException()
        {
        }

        public LimitesInteraccionException(string? message) : base(message)
        {
        }

        public LimitesInteraccionException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}