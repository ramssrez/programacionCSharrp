namespace UnidadTresAC
{
    public class BecaDeportiva : Beca
    {
        public string Deporte { get; set; }
        public BecaDeportiva()
        {

        }
        public override string MostrarDetalles()
        {
            return $"Beca #: {ID}";
        }
    }
}