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
            double LongitudDos = -98.1068475;
            double LatitudDos = 18.3041477;
            double RadioTierra = 6372.795477598;
            double DeltaLongitud = LongitudDos - LongitudUno;
            double DeltaLatitud = LatitudDos - LatitudUno;
            double PastoNatural =1000.0 ;
            double PastoArtificial = 3500.0;
            Console.WriteLine($"Base: {Base}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Long 1: {LongitudUno}");
            Console.WriteLine($"Long 2: {LongitudDos}");
            Console.WriteLine($"Lat 1: {LatitudUno}");
            Console.WriteLine($"Lat 2: {LatitudDos}");
            Console.WriteLine($"Radio: {RadioTierra}");
            Console.WriteLine($"Delta long: {CalculoDelta(LongitudUno,LongitudDos)}");
            Console.WriteLine($"Delta lati: {CalculoDelta(LatitudUno,LatitudDos)}");
            Console.WriteLine($"Area: {CalculoArea(Base, Altura)} [m*m]");
            Console.WriteLine($"Distancia: {CalculoDistancia(LatitudUno,LatitudDos,LongitudUno,LongitudDos)}[m]");
            CostoTotal(PastoNatural,Base,Altura,LatitudUno,LatitudDos,LongitudUno,LongitudDos);
        }
        public static double CalculoDelta(double ValorUno, double ValorDos)
        {
            return ValorDos - ValorUno;
        }
        public static double CalculoArea(double Base, double Longitud)
        {
            return Base * Longitud;
        }
        public static double CalcularRadianes(double valor)
        {
            return (Math.PI / 180) * valor;
        }
        public static double CalculoDistancia(double LatitudUno, double LatitudDos, double LongitudUno, double LongitudDos)
        {
            double Raiz, A, B, C, D,Distancia,RadLatUno,RadLatDos,RadLonUno,RadLonDos;
            double RadioTierra = 6372.795477598*1000;
            RadLatUno = CalcularRadianes(LatitudUno);
            RadLatDos = CalcularRadianes(LatitudDos);
            RadLonUno = CalcularRadianes(LongitudUno);
            RadLonDos = CalcularRadianes(LongitudDos);
            A = Math.Sin(CalculoDelta(RadLatUno,RadLatDos)/2) * Math.Sin(CalculoDelta(RadLatUno, RadLatDos) / 2);
            B = Math.Sin(CalculoDelta(RadLonUno,RadLonDos) / 2) * Math.Sin(CalculoDelta(RadLonUno, RadLonDos) / 2);
            C = Math.Cos(RadLatUno)*Math.Cos(RadLatDos)*B;
            D = A + C;
            Raiz = Math.Sqrt(D);
            Distancia = 2 * RadioTierra*Math.Asin(Raiz);
            return Distancia;
        }
        public static void CostoTotal(double TipoPasto, double Base, double Longitud, double LatitudUno, double LatitudDos, double LongitudUno, double LongitudDos)
        {
            double CostoDistancia = 40.0;
            double Area, Distancia, Costo;
            Area = CalculoArea(Base, Longitud);
            Distancia = CalculoDistancia(LatitudUno, LatitudDos , LongitudUno, LongitudDos);
            Costo = ((TipoPasto * Area)+(CostoDistancia*Distancia)) * (0.20);
            Console.WriteLine($"El costo es: {Costo}");
        }
    }
}
