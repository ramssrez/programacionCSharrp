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
            double Area, Distancia, Costo, CostoPasto, CostoDistanciaTotal, CostoQuince, CostoCinco, CostoSumado;
            Area = CalculoArea(Base, Longitud);
            CostoPasto = Math.Round(TipoPasto * Area);
            Distancia = Math.Round(CalculoDistancia(LatitudUno, LatitudDos, LongitudUno, LongitudDos));

            CostoDistanciaTotal = Math.Round(CostoDistancia * Distancia);

            Costo = Math.Round(CostoPasto + CostoDistanciaTotal);
            CostoQuince = Math.Round(Costo * 0.15);
            CostoCinco = Math.Round(Costo * 0.05);
            CostoSumado = Costo + CostoQuince + CostoCinco;

            Console.WriteLine($"El costo del pasto fue: ${TipoPasto} por metro cuadrado");
            Console.WriteLine($"La área fue {Area}[m^2] con un costo: ${CostoPasto}");
            Console.WriteLine($"El costo del trasporte es ${CostoDistancia} y {Distancia}[m]: ${CostoDistanciaTotal}");
            Console.WriteLine($"El costo de instalación del 15% es: ${CostoQuince}");
            Console.WriteLine($"El costo del material de 5% es: ${CostoCinco}");
            Console.WriteLine($"El costo total de instalación: ${CostoSumado}");
        }
    }
}
//