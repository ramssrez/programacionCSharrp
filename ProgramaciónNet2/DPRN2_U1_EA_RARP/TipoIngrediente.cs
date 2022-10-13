namespace UnidadUnoEA
{
    //Declaración de la clase TipoIngrediente
    public class TipoIngrediente
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public int Id { get; set; }
        public string TipoInsumo { get; set; }
        //Declaración del constructor vacio de la clase
        public TipoIngrediente()
        {

        }
        //Declaración de constructor con atributos
        public TipoIngrediente(int id, string tipoInsumo)
        {
            Id = id;
            TipoInsumo = tipoInsumo;
        }
    }
}