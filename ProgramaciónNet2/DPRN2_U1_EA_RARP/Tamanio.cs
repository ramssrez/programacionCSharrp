namespace UnidadUnoEA
{
    public class Tamanio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rebanadas { get; set; }
        public Tamanio()
        {

        }
        public Tamanio(int id, string nombre, string rebanada)
        {
            Id = id;
            Name = nombre;  
            Rebanadas = rebanada;   
        }
    }
}