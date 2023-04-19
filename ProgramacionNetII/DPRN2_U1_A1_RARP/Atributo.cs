namespace UnidadUnoA1
{
    //Declaración de la clase Atributo con sus atributos necesarios
    public class Atributo
    {
        /*
         * Identificadores por tipo y descripción
         * 1.-Oscuridad
         * 2.-Luz
         * 3.-Tierra
         * 4.-Agua
         * 5.-Fuego
         * 6.-Viento
         */
        //Declaración de las variables y métodos  getter y setter del objeto Atributo
        public int Id { get; }
        public string Name { get; set; }
        //Declaración del constructor vacio de la clase
        public Atributo()
        {

        }
        //Declaración del constructor con parametros de entrada
        public Atributo(int identificador, string nombre)
        {
            Id = identificador;
            Name = nombre;
        }
    }
}