namespace UnidadUnoEA
{
    public class Personaje
    {
        public string NombreReal { get; set; }
        public string NombreConocido { get; set; }
        public string PrimeraAparicionHistorica { get; set; }
        public string PrimeraAparicion { get; set; }
        public string Poderes { get; set; }
        public string Creador { get; set; }
        public string Descripcion { get; set; }
        public bool Humano { get; set; }
        public string PuntosExperiencia { get; set; }
        public string NivelFisico { get; set; }


        public Personaje()
        {

        }
        Personaje(string nombreConocido, string nombreReal, string primeraAparicionHistorica,
            string primeraAparicion, string poderes, string creador, string descripcion)
        {

        }
    }
}