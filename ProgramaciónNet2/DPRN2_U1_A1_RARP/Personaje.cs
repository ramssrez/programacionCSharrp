namespace UnidadUnoA1
{
    //Declaración de la clase Poder con sus atributos necesarios
    public class Personaje
    {
        //Declaración de las variables y métodos  getter y setter del objeto Personaje
        public string NombreReal { get; set; }
        public string NombreComercial { get; set; }
        public string PrimeraAparicionHistorica { get; set; }
        public string PrimeraAparicion { get; set; }
        public List<Poder> Poderes { get; set; }
        public List<Creador> Creadores { get; set; }
        public string Descripcion { get; set; }
        public bool EsHumano { get; set; }
        public float PuntosExperiencia { get; set; }
        public float NivelFisico { get; set; }
        public float Cansancio { get; set; }
        public int PeleasTotales { get; set; }
        //Declaración del constructor vacio de la clase
        public Personaje()
        {
            PuntosExperiencia = 1.0f;
            NivelFisico = 10.0f;
            PeleasTotales = 0;
            Cansancio = 0.0f;
        }
        //Declaración del constructor con parametros de entrada
        public Personaje(string nombreComercial, string nombreReal, string primeraAparicionHistorica,
            string primeraAparicion,string descripcion,bool esHumano, List<Poder> poderes, List<Creador> creadores)
        {
            NombreComercial = nombreComercial;
            NombreReal = nombreReal;
            PrimeraAparicionHistorica = primeraAparicionHistorica;
            PrimeraAparicion = primeraAparicion;
            Descripcion = descripcion;
            EsHumano = esHumano;
            Poderes = poderes;
            Creadores = creadores;
            PuntosExperiencia = 1.0f;
            NivelFisico = 10.0f;
            PeleasTotales = 0;
            Cansancio = 0.0f;
        }
        //Método que pemite sumar puntos de experiencia, cansansio y restan nivel físico de una pelea
        public void Pelea()
        {
            //Condición para el caso de que el nivel fisico sea igual a cero y se haya sobrepasado las peleas
            if (PeleasTotales < 10 || NivelFisico <= 0.0f)
            {
                PuntosExperiencia = PuntosExperiencia + 0.02f;
                Cansancio = Cansancio + 0.3f;
                NivelFisico = NivelFisico - 0.3f;
                PeleasTotales++;
                Console.WriteLine($"{NombreComercial}, ha aumentado su experiencia a {PuntosExperiencia}");
                Console.WriteLine($"{NombreComercial}, ahora tiene un cansancio de {Cansancio}");
                Console.WriteLine($"{NombreComercial}, puede pelear {10-PeleasTotales} veces");
            }
            //Condición para que el personaje ya no pueda pelear
            else
            {
                Console.WriteLine($"{NombreComercial}, ya no puede pelear");
            }
        }
        //Método que permite realizar el ataque del personaje
        public void Ataque()
        {
            if (PeleasTotales < 10 || NivelFisico <= 0.0f)
            {
                Random r = new Random();
                int numero = r.Next(0, Poderes.Count);
                float danioReal = (PuntosExperiencia * (NivelFisico * 0.8f)) - Cansancio;
                Console.WriteLine($"{NombreComercial}, ha hecho un daño de: {danioReal}, con el ataque: {Poderes[numero].Descripcion}");
            }
            else
            {
                Console.WriteLine($"{NombreComercial}, ya no puede pelear");
            }
        }
        //Método que imprime las variables que componen al objeto
        public void ToString()
        {
            string eshumano = " ";
            if (EsHumano)
            {
                eshumano = "Si";
            }
            else
            {
                eshumano = "No";
            }

            Console.WriteLine($"Nombre comercial: {NombreComercial} \n" +
                $"Nombre real: {NombreReal} \n" +
                $"Primera aparición historica: {PrimeraAparicionHistorica} \n" +
                $"Primera aparición: {PrimeraAparicion} \n" +
                $"Descripción: {Descripcion} \n" +
                $"¿Es humano?: {eshumano} \n" +
                $"Puntos de experiencia: {PuntosExperiencia} \n" +
                $"Nivel Fisico: {NivelFisico} \n"+
                $"Cansancio: {Cansancio} \n"+
                $"Peleas Totales: {PeleasTotales}");
            Console.WriteLine("Poderes: ");
            foreach (Poder p in Poderes)
            {
                Console.WriteLine($"{p.Id}-{p.Descripcion}");
            }
            Console.WriteLine("Creadores: ");
            foreach (Creador c in Creadores)
            {
                Console.WriteLine($"{c.Nombre} {c.Apellido}");
            }
        }
    }
}