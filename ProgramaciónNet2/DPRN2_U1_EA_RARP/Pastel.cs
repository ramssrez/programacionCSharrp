namespace UnidadUnoEA
{
    class Pastel
    {
        public int Id { get; set; }
        public List<Ingrediente> Ingredientes { get; set;}
        public float Peso { get; set; }
        public Tamanio Rendimiento { get; set; }
        public float Costo { get; set; }    
        public Pastel()
        {
            
        }
        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            Ingredientes.Add(ingrediente);
        }
        public int CantidadIngredientes()
        {
            return Ingredientes.Count;
        }
        public void Informacion()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Descripción: {Peso} \n" +
                $"Tamaño: {Rendimiento.Name}");
            Console.WriteLine("Ingredientes: ");
            foreach (Ingrediente p in Ingredientes)
            {
                Console.WriteLine($"{p.Nombre}");
            }
        }
    }
}