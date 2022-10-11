namespace UnidadUnoA1
{
    //Declaración de la clase Poder con sus atributos necesarios
    public class Poder
    {
        //Declaración de las variables y métodos  getter y setter del objeto Poder
        public int Id { get; set; }
        public String Descripcion { get; set; }
        //Declaración del constructor vacio de la clase
        public Poder()
        {

        }
        //Declaración del constructor con parametros de entrada
        public Poder(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        //Método que imprime las variables que componen al objeto
        public void ToString()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Descripción: {Descripcion} \n");
        }
    }
}