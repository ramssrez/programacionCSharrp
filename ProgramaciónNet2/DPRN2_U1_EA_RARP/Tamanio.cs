namespace UnidadUnoEA
{
    //Declaración de la clase Tamanio
    public class Tamanio
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rebanadas { get; set; }
        //Declaración del constructor vacio de la clase
        public Tamanio()
        {

        }
        //Declaración de constructor con atributos
        public Tamanio(int id, string nombre, string rebanada)
        {
            Id = id;
            Name = nombre;  
            Rebanadas = rebanada;   
        }
    }
}