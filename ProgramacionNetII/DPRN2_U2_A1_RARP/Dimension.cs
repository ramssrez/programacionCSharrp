namespace UnidadDosA1
{
    //Declaración de la clase Dimension con sus atributos necesarios
    public class Dimension
    {
        //Declaración de las variables, métodos  getter y setter del objeto Dimensión
        public double Altura { get; set; }
        public double Ancho { get; set; }
        public double BaseDron { get; set; }
        //Declaración del constructor con parametros de entrada
        public Dimension(double altura, double ancho, double baseDron)
        {
            Altura = altura;
            Ancho = ancho;
            BaseDron = baseDron;
        }
    }
}