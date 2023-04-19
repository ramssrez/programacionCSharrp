namespace UnidadUnoA1
{
    //Declaración de la clase Tipo con sus atributos necesarios
    public class Tipo
    {
        /*
        * Identificadores por tipo y descripción
        * 1.-Lanzador de Conjuros
        * 2.-Demonio
        * 3.-Dragón
        * 4.-Insecto
        */
        //Declaración de las variables y métodos  getter y setter del objeto Tipo
        public int Id { get; set; }
        public string TipoName { get; set; }
        public bool IsEfect { get; set; }
        //Declaración del constructor vacio de la clase
        public Tipo()
        {

        }
        //Declaración del constructor con parametros de entrada
        public Tipo(int id, string tipo, bool isEfect)
        {
            Id = id;
            TipoName = tipo;
            IsEfect = isEfect;
        }
    }
}