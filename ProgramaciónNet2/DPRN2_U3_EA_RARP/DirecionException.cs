namespace UnidadTresEA
{
    //Declaración de la clase DireccionException
    public class DirecionException : Exception
    {
        //Constructores de la clase para diferentes parametros de entrada
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