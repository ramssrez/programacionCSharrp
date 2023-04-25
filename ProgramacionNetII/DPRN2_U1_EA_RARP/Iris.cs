namespace UnidadUnoEA
{
    public class Iris
    {
        public int Id { get; }
        public string PatronTextura { get; set; }
        public string Forma { get; set; }
        public ColorIris Color { get; set; }
        public List<string> PatronRayas { get; set; }
        public List<double> Curvatura { get; set; }
        public List<string> Otros { get; set; }
        public Iris(int id, string patronTextura, string forma, ColorIris color, List<string> patronRayas, List<Double> curvatura, List<string> otros)
        {
            PatronTextura = patronTextura;
            Forma = forma;
            Color = color;
            PatronRayas = patronRayas;
            Curvatura = curvatura;
            Otros = otros;
            Id = id;
        }
        public void SimularEnvejecimiento(int intensidad)
        {
            Color.Intensidad = intensidad;
        }
        public void SimularEnvejecimiento(List<double> curvaturas)
        {
            Curvatura = curvaturas;
        }
        public void SimularEnvejecimiento(string otro)
        {
            Otros.Add(otro);
        }
        public void AtributosConsole()
        {
            Console.WriteLine($"Patron textura: {PatronTextura} \n" +
                    $"Forma: {Forma} \n" +
                    $"Color: {Color.Color} \n" +
                    $"Intensidad: {Color.Intensidad}%");
            Console.WriteLine("Patron Rayas:");
            foreach (string s in PatronRayas)
            {
                Console.WriteLine($" {s}");
            }
            Console.WriteLine("Curvatura:");
            foreach (double d in Curvatura)
            {
                Console.WriteLine($" Radio: {d}");
            }
            Console.WriteLine("Otras caracteristicas:");
            foreach (string d in Otros)
            {
                Console.WriteLine($" {d}");
            }
        }
    }
}