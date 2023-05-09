namespace UnidadUnoEA
{
    //Declaración de la clase ColorIris con sus atributos necesarios
    public class ColorIris
    {
        //Declaración de las variables, métodos  getter y setter del objeto ColorIris
        public string Color { get; set; }
        public int Intensidad { get; set; }
        //Declaración del constructor vacio de la clase
        public ColorIris()
        {

        }
        //Declaración del constructor con parametros de entrada
        public ColorIris(string color, int intesidad)
        {
            Color = color;
            Intensidad = intesidad;
        }
    }
}