namespace UnidadUnoEA
{
    public class Iris
    {
        public string PatronTextura { get; set; }
        public string Forma { get; set; }
        public ColorIris Color { get; set; }
        public string PatronRayas { get; set; }
        public double Curvatura { get; set; }
        public List<string> Otros { get; set; }
        public Iris()
        {

        }
        public Iris(string patronTextura, string forma, ColorIris color, string patronRayas, double curvatura, List<string> otros)
        {
            PatronTextura = patronTextura;
            Forma = forma;
            Color = color;
            PatronRayas = patronRayas;
            Curvatura = curvatura;
            Otros = otros;
        }
        public void SimularEnvejecimiento(int intensidad)
        {
            Color.Intensidad = intensidad;
        }
        public void SimularEnvejecimiento(double curvaturas)
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
                    $"Patron de rayas: {PatronRayas}\n" +
                    $"Curvatura: {Curvatura}\n" +
                    $"Intensidad: {Color.Intensidad}%");
            Console.WriteLine("Otras caracteristicas:");
            foreach (string d in Otros)
            {
                Console.WriteLine($" {d}");
            }
            Console.WriteLine("\n");
        }
    }
}