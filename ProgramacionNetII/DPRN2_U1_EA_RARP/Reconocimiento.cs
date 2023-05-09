namespace UnidadUnoEA
{
    //Declaración de la clase Reconocimiento con sus atributos necesarios
    public class Reconocimiento
    {
        //Declaración de las variables, métodos  getter y setter del objeto ColorIris
        public Iris IrisUno { get; set; }
        public Iris IrisDos { get; set; }
        public int PorcentajeCoincidencia { get; set; }
        public List<string> ElementosIdenticos { get; set; }
        public string Identificacion { get; set; }
        //Declaración del constructor vacio de la clase
        public Reconocimiento()
        {
        }
        //Declaración del constructor con parametros de entrada
        public Reconocimiento(Iris irisUno, Iris irisDos)
        {
            IrisUno = irisUno;
            IrisDos = irisDos;
            ElementosIguales();
            ResultadoAutentificacion();
        }
        //Método que compara si los sttrings ingresados son iguales y retorna un booleano
        private bool CompararStrings(string s1, string s2)
        {
            return s1.Equals(s2) ? true : false;
        }
        //Método que compara si los doubles ingresados son iguales y retorna un booleano
        private bool CompararDoubles(double d1, double d2)
        {
            return d1 == d2 ? true : false;
        }
        //Método que compara si los enteros ingresados son iguales y retorna un booleano
        private bool CompararEnteros(int i1, int i2)
        {
            return i1 == i2 ? true : false;
        }
        //Método que compara si las listas ingresadas son iguales y retorna un booleano
        private bool CompararListas(List<string> l1, List<string> l2)
        {
            return l1.SequenceEqual(l2) ? true : false;
        }
        //Método que crea una lista con los elementos que son iguales.
        private void ElementosIguales()
        {
            string textura = CompararStrings(IrisUno.PatronTextura, IrisDos.PatronTextura) ? "Textura" : "";
            string forma = CompararStrings(IrisUno.Forma, IrisDos.Forma) ? "Forma" : "";
            string color = CompararStrings(IrisUno.Color.Color, IrisDos.Color.Color) ? "Color":"";
            string intensidad = CompararEnteros(IrisUno.Color.Intensidad, IrisDos.Color.Intensidad) ? "Intensidad" : "";
            string patron = CompararStrings(IrisUno.PatronRayas, IrisDos.PatronRayas) ? "Patron de Rayas" : "";
            string curvatura = CompararDoubles(IrisUno.Curvatura, IrisDos.Curvatura) ? "Curvatura" : "";
            string otros = CompararListas(IrisUno.Otros, IrisDos.Otros) ? "Otros" : "";
            ElementosIdenticos = new List<string> { textura, forma, color, intensidad, patron, curvatura, otros };
        }
        //Método que imprime el arreglo con los datos ingresados
        private void ImprimirArrreglo()
        {
            foreach(string s in ElementosIdenticos)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    Console.WriteLine($" {s}");
                }
            }
        }
        //Método que realiza el conteo de parametros que son similares entre las iris ingresadas.
        private int ContadorVerdaderos()
        {
            List<bool> list = new List<bool>
            {
                CompararStrings(IrisUno.PatronTextura,IrisDos.PatronTextura),
                CompararStrings(IrisUno.Forma,IrisDos.Forma),
                CompararStrings(IrisUno.Color.Color,IrisDos.Color.Color),
                CompararEnteros(IrisUno.Color.Intensidad,IrisDos.Color.Intensidad),
                CompararStrings(IrisUno.PatronRayas , IrisDos.PatronRayas),
                CompararDoubles(IrisUno.Curvatura , IrisDos.Curvatura),
                CompararListas(IrisUno.Otros,IrisDos.Otros)
            };
            int suma = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i])
                {
                    suma++;
                }
            }
            return suma;
        }
        //Metodo que calcula el porcentaje de conicidencia de los parametros de cada una de las iris
        private void Porcentaje(int totalCorrectos)
        {
            int totalParametros = 7;
            double division =(totalCorrectos*100)/totalParametros;
            PorcentajeCoincidencia = Convert.ToInt32(division);
        }
        //Método que verifica en función de la considecia de los parametros si esta autentificado o no.
        private void ResultadoAutentificacion()
        {
            int total = ContadorVerdaderos();
            Porcentaje(total);
            Identificacion = total >= 6 ? "'Si esta autentificado'" : "'No esta autentificado'";
        }
        //Método que imprime los atributos que componen al objeto
        public void AtributosConsole()
        {
            Console.WriteLine("Los datos del primer iris son: ");
            IrisUno.AtributosConsole();
            Console.WriteLine("Los datos del segundo iris son: ");
            IrisDos.AtributosConsole();
            Console.WriteLine("Los elementos similares son: ");
            ImprimirArrreglo();
            Console.WriteLine($"El usuario {Identificacion} tiene un porcentaje de {PorcentajeCoincidencia}%");
        }
    }
}