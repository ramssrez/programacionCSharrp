namespace UnidadUnoEA
{
    class Pastel
    {
        public int Id { get; set; }
        public List<Ingrediente> Ingredientes { get; set;}
        public float Peso { get; set; }
        public float Rendimiento { get; set; }
        public float Costo { get; set; }    
        public Pastel()
        {
            
        }
        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            Ingredientes.Add(ingrediente);
        }
        public void Informacion()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Descripción: {Peso} \n");
        }
    }
}