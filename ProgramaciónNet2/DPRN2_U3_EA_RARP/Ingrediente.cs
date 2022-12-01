namespace UnidadTresEA
{
    //Declaración de la clase Reserva
    class Ingrediente
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public int Id { get;}
        public string Name { get; set; }
        public static int contador = 1;
        //Declaración del constructor vacio
        public Ingrediente()
        {

        }
        //Declaración del constructor con parametros
        public Ingrediente(string name)
        {
            Id = contador++;
            Name = name;
        }
        //Método que muestra la información del ingrediente
        public void MostrarInfo()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Nombre: {Name}");
        }
    }
}