namespace UnidadTresEA
{
    //Declaración de la clase Tipo
    class Tipo
    {
        //Declaración de los atributos de la clase, así como los getters y setters
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