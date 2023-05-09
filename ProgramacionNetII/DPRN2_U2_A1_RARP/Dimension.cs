namespace UnidadDosA1
{
    public class Dimension
    {
        public double Altura { get; set; }
        public double Ancho { get; set; }
        public double BaseDron { get; set; }
        public Dimension(double altura, double ancho, double baseDron)
        {
            Altura = altura;
            Ancho = ancho;
            BaseDron = baseDron;
        }
    }
}