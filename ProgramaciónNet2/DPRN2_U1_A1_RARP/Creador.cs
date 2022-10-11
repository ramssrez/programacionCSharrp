namespace UnidadUnoA1
{
    //Declaración de la clase Creador con sus atributos necesarios
    public class Creador
    {
        //Declaración de las variables y métodos  getter y setter del objeto Personaje
        public String Nombre { get; set; }
        public int Id { get; set; }
        public String Apellido { get; set; }
        //Declaración del constructor vacio de la clase
        public Creador()
        {
        }
        //Declaración del constructor con parametros de entrada
        public Creador(string nombre, int identificador, string apellido)
        {
            Nombre = nombre;
            Id = identificador;
            Apellido = apellido;
        }
        //Método que imprime las variables que componen al objeto
        public void ToString()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Nombre: {Nombre} \n" +
                $"Apellido: {Apellido} \n");
        }
    }
}