namespace UnidadUnoA1
{
    public class Tipo
    {
        public int Id { get; set; }
        public string TipoName { get; set; }
        public bool IsEfect { get; set; }
        public Tipo()
        {

        }
        public Tipo(int id, string tipo, bool isEfect)
        {
            Id = id;
            TipoName = tipo;
            IsEfect = isEfect;
        }
        //Método que imprime las variables que componen al objeto
        public void AtributosConsole()
        {
            string efecto = IsEfect ? "Si" : "No";
            Console.WriteLine($"Id: {Id} \n" +
                $"Tipo: {TipoName} \n" +
                $"¿Es un efecto? {efecto}" );
        }
    }
}