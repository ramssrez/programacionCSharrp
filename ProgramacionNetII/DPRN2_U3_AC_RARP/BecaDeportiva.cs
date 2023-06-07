namespace UnidadTresAC
{
    //Declaración de la clase BecaAcademica con sus atributos necesarios
    public class BecaDeportiva : Beca
    {
        //Declaración de las variables y métodos  getter y setter del objeto BecaDeportiva
        public string? Deporte { get; set; }
        //Declaración de constructores con diferentes parametros
        public BecaDeportiva()
        {

        }
        public BecaDeportiva(int id, string pais, decimal monto, string tipo)
        {
            ID = id;
            Pais = pais;
            Monto = monto;
            TipoBeca = tipo;
        }
        public BecaDeportiva(int id, string pais, decimal monto, string tipo,string deporte)
        {
            ID = id;
            Pais = pais;
            Monto = monto;
            TipoBeca = tipo;
            Deporte = deporte;
        }
        //Método que muestra los detalles del objeto
        public override string MostrarDetalles()
        {
            if (Deporte == null)
            {
                Deporte = "Sin dato";
            }
            return $"Beca #: {ID}\n" +
                    $"País: {Pais}\n" +
                    $"Monto: ${Monto}\n" +
                    $"Tipo: {TipoBeca}\n" +
                    $"Deporte: {Deporte}";
        }
    }
}