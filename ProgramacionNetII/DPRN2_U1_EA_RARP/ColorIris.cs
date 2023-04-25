namespace UnidadUnoEA
{
    public class ColorIris
    {
        public string Color { get; set; }
        public int Intensidad { get; set; }

        public ColorIris()
        {

        }
        public ColorIris(string color, int intesidad)
        {
            Color = color;
            Intensidad = intesidad;
        }
    }
}