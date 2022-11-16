namespace UnidadTresEA
{
    class Tipo
    {
        public int Id { get;}
        public string Name { get; set; }
        public double Precio { get; set; }
        public static int contador = 1;
        public Tipo(string name, double precio)
        {
            Name = name;
            Precio = precio;
            Id = contador++;
        }
    }
}