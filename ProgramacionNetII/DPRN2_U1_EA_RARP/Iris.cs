namespace UnidadUnoEA
{
    //Declaración de la clase Iris con sus atributos necesarios
    public class Iris
    {
        //Declaración de las variables, métodos  getter y setter del objeto Iris
        public string PatronTextura { get; set; }
        public string Forma { get; set; }
        public ColorIris Color { get; set; }
        public string PatronRayas { get; set; }
        public double Curvatura { get; set; }
        public List<string> Otros { get; set; }
        //Declaración del constructor vacio de la clase
        public Iris()
        {

        }
        //Declaración del constructor con parametros de entrada
        public Iris(string patronTextura, string forma, ColorIris color, string patronRayas, double curvatura, List<string> otros)
        {
            PatronTextura = patronTextura;
            Forma = forma;
            Color = color;
            PatronRayas = patronRayas;
            Curvatura = curvatura;
            Otros = otros;
        }
        //Método que simula el envejecimiento del iris, cambiando la intensidad del iris
        public void SimularEnvejecimiento(int intensidad)
        {
            Color.Intensidad = intensidad;
        }
        //Método que simula el envejecimientos del iris, cambiando la curvatura del iris
        public void SimularEnvejecimiento(double curvaturas)
        {
            Curvatura = curvaturas;
        }
        //Método que simula el envejecimientos del iris, agregando cicatrices o manchas en la iris
        public void SimularEnvejecimiento(string otro)
        {
            Otros.Add(otro);
        }
        //Método que imprime los atributos que componen al objeto
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