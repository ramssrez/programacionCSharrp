namespace UnidadUnoEA
{
    public class Iris
    {
        public string PatronTextura { get; set; }
        public string Forma { get; set; }
        public ColorIris Color { get; set; }
        public List<string> PatronRayas { get; set; }
        public List<double> Curvatura { get; set; }
        public List<string> Otros { get; set; }
        public Iris(string patronTextura, string forma, ColorIris color, List<string> patronRayas, List<Double> curvatura, List<string> otros)
        {
            PatronTextura = patronTextura;
            Forma = forma;
            Color = color;
            PatronRayas = patronRayas;
            Curvatura = curvatura;
            Otros = otros;
        }
        public void AtributosConsole()
        {
            //string efecto = TipoMonstruo.IsEfect ? "Si" : "No";
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
                int index = Curvatura.IndexOf(d);
                Console.WriteLine($" Radio: {d} {index}");
            }
            Console.WriteLine("Otras caracteristicas:");
            foreach (string d in Otros)
            {
                Console.WriteLine($" {d}");
            }
        }
    }
}