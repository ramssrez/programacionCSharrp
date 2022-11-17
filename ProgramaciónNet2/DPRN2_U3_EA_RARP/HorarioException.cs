namespace UnidadTresEA
{
    public class HorarioException:Exception
    {
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