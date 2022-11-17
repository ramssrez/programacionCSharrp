namespace UnidadTresEA
{
    public class DirecionException : Exception
    {
        public DirecionException()
        {

        }
        public DirecionException(string message) 
            : base(message)
        {

        }
        public DirecionException(string message, Exception inner) 
            : base(message, inner)
        {

        }
    }
}