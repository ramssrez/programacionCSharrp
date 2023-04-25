namespace UnidadUnoEA
{
    public class Reconocimiento
    {
        public Iris IrisUno { get; set; }
        public Iris IrisDos { get; set; }
        public int PorcentajeConincidencia { get; set; }
        public string ElementosIdenticos { get; set; }
        public string Identificacion { get; set; }
        public Reconocimiento()
        {
        }
        public Reconocimiento(Iris i1, Iris i2)
        {
            IrisUno = i1;
            IrisDos = i2;
        }
    }
}