namespace UnidadTresAC
{
    public abstract class Beca
    {
        public int ID { get; }
        public string Pais { get; set; }
        public decimal Monto { get; set; }
        public abstract string MostrarDetalles();
        public Beca()
        {

        }
    }
}