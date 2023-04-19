namespace UnidadUnoA1
{
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
        public int Id { get; }
        public string Name { get; set; }

        public Atributo()
        {

        }
        public Atributo(int identificador, string nombre)
        {
            Id = identificador;
            Name = nombre;
        }
        //Método que imprime las variables que componen al objeto
        public void AtributosConsole ()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Nombre: {Name} \n");
        }
    }
}