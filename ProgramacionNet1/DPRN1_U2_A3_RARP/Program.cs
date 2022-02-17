using System;
namespace UnidadDosA3
{
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            double Base = 20;
            double Altura = 15;
            double LongitudUno = - 99.1068475;
            double LatitudUno = 19.3041477;
            double LongitudDos = -99.068316;
            double LatitudDos = 19.462441;
            double PastoNatural = 1000.0 ;
            double PastoArtificial = 3500.0;
            CostoTotal(PastoNatural,Base,Altura,LatitudUno,LatitudDos,LongitudUno,LongitudDos,"Natural");
        }

        //Método que realiza el cálculo de la diferencia de dos valores, se necesita de dos valores y retorna la resta
        public static double CalculoDelta(double ValorUno, double ValorDos)
        {
            //Retorno de la diferencia entre dos valores
            return ValorDos - ValorUno;
        }

        //Método que realiza el cálculo el área de un cuadrado o rectangulo, se necesita de dos valores y retorna el área 
        public static double CalculoArea(double Base, double Longitud)
        {
            //Retorno del área con la multiplición de base y longitud
            return Base * Longitud;
        }
        
        //Método que transforma la latitud y longitud a radianes para hacer uso de la ecuación de distancia.
        public static double CalcularRadianes(double valor)
        {
            //Retorno del valor cambiado a radianes
            return (Math.PI / 180) * valor;
        }

        //Método que cálcula la distancia entre dos puntos con datos de latitud y longitud
        public static double CalculoDistancia( double LatitudDos, double LongitudDos)
        {
            // Declaración de variables necesarias para el calculo de la distancia
            double Raiz, DeltaSenoLatCuadrado, DeltaSenoLonCuadrado, C, D,Distancia,RadLatUno,RadLatDos,RadLonUno,RadLonDos;
            //Declaración del radio de la tierra como constante
            double RADIOTIERRA = 6372.795477598*1000;
            double LONGITUDUNO = -99.1068475;
            double LATITUDUNO = 19.3041477;
            //Tranformación de las latitudes y longitudes a radianes.
            RadLatUno = CalcularRadianes(LATITUDUNO);
            RadLatDos = CalcularRadianes(LatitudDos);
            RadLonUno = CalcularRadianes(LONGITUDUNO);
            RadLonDos = CalcularRadianes(LongitudDos);
            //Cálculo del seno cuadrado para las longitudes y latitudes en radianes con la función Sin()
            DeltaSenoLatCuadrado = Math.Sin(CalculoDelta(RadLatUno,RadLatDos)/2) * Math.Sin(CalculoDelta(RadLatUno, RadLatDos) / 2);
            DeltaSenoLonCuadrado = Math.Sin(CalculoDelta(RadLonUno,RadLonDos) / 2) * Math.Sin(CalculoDelta(RadLonUno, RadLonDos) / 2);
            //Declaración de variables donde se descompuso para poder realizar los calculos.
            C = Math.Cos(RadLatUno) * Math.Cos(RadLatDos) * DeltaSenoLonCuadrado;
            D = DeltaSenoLatCuadrado + C;
            //Cálculo de la raíz con el uso de la función Sqrt()
            Raiz = Math.Sqrt(D);
            //Cálculo de la distancia
            Distancia = 2 * RADIOTIERRA*Math.Asin(Raiz);
            //Retorno de la distancia.
            return Distancia;
        }

        //Método que calcula el costo total con el ingreso de las longitudes y latitudes de los puntos, la base, la longitud y el costo del pasto y el tipo.
        public static void CostoTotal(double TipoPastoCosto, double Base, double Longitud, double LatitudUno, double LatitudDos, double LongitudUno, double LongitudDos, string TipoPasto)
        {
            Console.WriteLine("*******************************************************************************");
            //Declaración de la constante de la distancia
            double COSTODISTANCIA = 40.0;
            //Declaración de variables para utilizar
            double Area, Distancia, Costo, CostoPasto, CostoDistanciaTotal, CostoQuince, CostoCinco, CostoSumado;
            //Cálculo del área por medio de un método
            Area = CalculoArea(Base, Longitud);
            //Cálculo del costo del pasto por el precio, usando la función Round() para redondear
            CostoPasto = Math.Round(TipoPastoCosto * Area);
            //Cálculo de la distancia, redondeado el método.
            Distancia = Math.Round(CalculoDistancia(LatitudDos, LongitudDos));
            //Cálculo del costo de la distancia total usando la función Round() para redondear
            CostoDistanciaTotal = Math.Round(COSTODISTANCIA * Distancia);
            //Desglose del cálculo usando la función Round() para redondear
            Costo = Math.Round(CostoPasto + CostoDistanciaTotal);
            CostoQuince = Math.Round(Costo * 0.15);
            CostoCinco = Math.Round(Costo * 0.05);
            CostoSumado = Costo + CostoQuince + CostoCinco;
            //Impresión del desglose de los gastos generales y desglose.
            Console.WriteLine($"El costo del pasto fue: ${TipoPastoCosto} por metro cuadrado de tipo {TipoPasto}");
            Console.WriteLine($"La área fue {Area}[m^2] con un costo: ${CostoPasto}");
            Console.WriteLine($"El costo del trasporte es ${COSTODISTANCIA} y {Distancia}[m]: ${CostoDistanciaTotal}");
            Console.WriteLine($"El costo de instalación del 15% es: ${CostoQuince}");
            Console.WriteLine($"El costo del material de 5% es: ${CostoCinco}");
            Console.WriteLine($" ");
            Console.WriteLine($"El costo total de instalación: ${CostoSumado}");
            Console.WriteLine("*******************************************************************************");
        }
    }
}
//