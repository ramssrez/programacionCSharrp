namespace UnidadTresAC
{
    //Declaración de la clase abstracta Beca con sus atributos necesarios
    public abstract class Beca
    {
        //Declaración de las variables y métodos  getter y setter del objeto Tipo
        public int ID { get; set; }
        public string? Pais { get; set; }
        public decimal Monto { get; set; }
        public string? TipoBeca { get; set; }
        public abstract string MostrarDetalles();
    }
}