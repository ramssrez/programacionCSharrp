namespace UnidadUnoEA
{
    public class Personaje
    {
        public string NombreReal { get; set; }
        public string NombreComercial { get; set; }
        public string PrimeraAparicionHistorica { get; set; }
        public string PrimeraAparicion { get; set; }
        public string Poderes { get; set; }
        public string Creador { get; set; }
        public string Descripcion { get; set; }
        public bool EsHumano { get; set; }
        public float PuntosExperiencia { get; set; }
        public string NivelFisico { get; set; }

        public Personaje()
        {

        }
        public Personaje(string nombreComercial, string nombreReal, string primeraAparicionHistorica,
            string primeraAparicion, string poderes, string creador, string descripcion, float puntosExperiencia,
            string nivelFisico, bool esHumano)
        {
            NombreComercial = nombreComercial;
            NombreReal = nombreReal;
            PrimeraAparicionHistorica=primeraAparicionHistorica;
            PrimeraAparicion = primeraAparicion;
            Poderes = poderes;
            Creador = creador;
            Descripcion = descripcion;  
            PuntosExperiencia = puntosExperiencia;  
            NivelFisico = nivelFisico;      


        }
        public void Pelea()
        {

        }
        public void Ataque()
        {

        }

        public void ToString()
        {
            string eshumano = null;
            if (EsHumano)
            {
                eshumano = "Si";
            }
            else
            {
                eshumano = "No";
            }

            Console.WriteLine($"Nombre comerciarl: {NombreComercial} \n" +
                $"Nombre real: {NombreReal} \n" +
                $"Primera aparición historica: {PrimeraAparicionHistorica} \n" +
                $"Primera aparición: {PrimeraAparicion} \n" +
                $"Poderes: {Poderes} \n" +
                $"Creador: {Creador} \n" +
                $"Descripción: {Descripcion} \n" +
                $"¿Es humano?: {eshumano} \n" +
                $"Puntos de experiencia: {PuntosExperiencia} \n" +
                $"Nivel Fisico: {NivelFisico} \n");
        }
    }
}