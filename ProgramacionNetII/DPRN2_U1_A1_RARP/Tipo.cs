namespace UnidadUnoA1
{
    public class Tipo
    {
         /*
         * Identificadores por tipo y descripción
         * 1.-Lanzador de Conjuros
         * 2.-Demonio
         * 3.-Dragón
         * 4.-Insecto
         */
        public int Id { get; set; }
        public string TipoName { get; set; }
        public bool IsEfect { get; set; }
        public Tipo()
        {

        }
        public Tipo(int id, string tipo, bool isEfect)
        {
            Id = id;
            TipoName = tipo;
            IsEfect = isEfect;
        }
    }
}