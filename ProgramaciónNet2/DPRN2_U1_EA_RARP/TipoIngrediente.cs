namespace UnidadUnoEA
{
    public class TipoIngrediente
    {
        public int Id { get; set; }
        public string TipoInsumo { get; set; }
        public TipoIngrediente()
        {

        }
        public TipoIngrediente(int id, string tipoInsumo)
        {
            Id = id;
            TipoInsumo = tipoInsumo;
        }
        public void Informacion()
        {
            Console.WriteLine($"Id: {Id} \n" +
                $"Tipo : {TipoInsumo} \n");
        }
    }
}