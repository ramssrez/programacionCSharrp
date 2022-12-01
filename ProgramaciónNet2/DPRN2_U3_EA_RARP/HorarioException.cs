namespace UnidadTresEA
{
    //Declaración de la clase HorarioException
    public class HorarioException:Exception
    {
        //Constructores de la clase para diferentes parametros de entrada
        public HorarioException()
        {

        }
        public HorarioException(string message)
            : base(message)
        {

        }
        public HorarioException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}