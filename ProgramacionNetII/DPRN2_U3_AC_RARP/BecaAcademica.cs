namespace UnidadTresAC
{
    //Declaración de la clase BecaAcademica con sus atributos necesarios
    public class BecaAcademica : Beca
    {
        //Declaración de las variables y métodos  getter y setter del objeto BecaAcademica
        public string? Universidad { get; set; }
        //Declaración de constructores con diferentes parametros
        public BecaAcademica()
        {

        }
        public BecaAcademica(int id, string pais, decimal monto, string tipo)
        {
            ID = id;
            Pais = pais;
            Monto = monto;
            TipoBeca = tipo;
        }
        public BecaAcademica(int id, string pais, decimal monto, string tipo,string universidad)
        {
            ID = id;
            Pais = pais;
            Monto = monto;
            TipoBeca = tipo;
            Universidad = universidad;
        }
        //Método que muestra los detalles del objeto
        public override string MostrarDetalles()
        {
            if (Universidad == null)
            {
                Universidad = "Sin dato";
            }
            return $"Beca #: {ID}\n" +
                    $"País: {Pais}\n" +
                    $"Monto: ${Monto}\n" +
                    $"Tipo: {TipoBeca}\n" +
                    $"Universidad: {Universidad}";
        }
    }
}