using System.Runtime.Serialization;

namespace UnidadTresAC
{
    [Serializable]
    //Declaración de la clase para manejo de exepciones
    public class BecaNoPermitidaException : Exception
    {
        //Declaración de diferentes tipos de contructores para su utilización
        public BecaNoPermitidaException()
        {
        }

        public BecaNoPermitidaException(string? message) : base(message)
        {
        }

        public BecaNoPermitidaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BecaNoPermitidaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}