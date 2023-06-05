using System.Runtime.Serialization;

namespace UnidadTresEA
{
    public class LimitesInteraccionException : Exception
    {
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