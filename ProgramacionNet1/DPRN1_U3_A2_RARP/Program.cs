using System;
namespace UnidadTresU2
{
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Llamado el método que realiza la presentación del programa
            Presentacion();
        }
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema del cálculo de área y perímetos de distintas fíguras geométricas");
            //Declaración del cliente de tipo cliente
            //Cliente cliente = new Cliente();
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Área y perímetro de un Trapecio");
                Console.WriteLine("2. Área y perímetro de una Estrella de 6 puntas");
                Console.WriteLine("3. Área y perímetro de un Círculo");
                Console.WriteLine("4. Área y perímetro de una Estrella de 5 puntas");
                Console.WriteLine("5. Mostrar monto de la cuenta");
                Console.WriteLine("6. Salir");
                Console.Write("Ingresa una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                //Uso del switch para selecion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos del trapecio e impresión de cálculos
                    case 1:
                        Console.WriteLine("Has elegido la opción 1");
                        DatosTrapecio();
                        break;
                    //Llamado del método para mostrar la información del usuario
                    case 2:
                        Console.WriteLine("Has elegido la opción 2");
                        DatosEstrella("Seis");
                        //MostrarInformacionUsuario(cliente);
                        break;
                    //Llamado del método para ingresar los datos del circulo e impresión de cálculos
                    case 3:
                        Console.WriteLine("Has elegido la opción 3");
                        DatosCirculo();
                        break;
                    //llamado del método para realizar un deposito del cliente
                    case 4:
                        Console.WriteLine("Has elegido la opción 4");
                        DatosEstrella("Cinco");
                        //RealizarRetiros(cliente);
                        break;
                    //Llamado del método para mostrar la información del cliente
                    case 5:
                        Console.WriteLine("Has elegido la opción 5");
                        //MostrarBalance(cliente);
                        break;
                    //Finalización del programa
                    case 6:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 6");
                        break;
                }
            }
        }
        public static void DatosTrapecio()
        {
            //Impresión y recepción de la información del trapecio
            Console.WriteLine("**************************************************************************************");
            double BaseMayor, BaseMenor, Altura;
            Console.Write("Ingresa la base mayor del Trapecio: ");
            BaseMayor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la base menor del Trapecio: ");
            BaseMenor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la altura del Trapecio: ");
            Altura = Convert.ToDouble(Console.ReadLine());
            //Llamado al método que determina al área y perímetro del Trapecio
            (double Area, double Perimetro) = AreaPerimetroTrapecio(BaseMayor,BaseMenor,Altura);
            Console.WriteLine($"El área del Trapecio es: {Area} [Unidades Cuadradas]");
            Console.WriteLine($"El perímetro del Trapecio es: {Perimetro} [Unidades]");
            Console.WriteLine("**************************************************************************************");
        }
        public static void DatosCirculo()
        {
            //Impresión y recepción de la información del trapecio
            Console.WriteLine("**************************************************************************************");
            double Radio;
            Console.Write("Ingresa el Radio del Círculo: ");
            Radio = Convert.ToDouble(Console.ReadLine());
            //Llamado al método que determina al área y perímetro del Trapecio
            (double Area, double Perimetro) = AreaPerimetroCirculo(Radio);
            Console.WriteLine($"El área del Círculo es: {Area} [Unidades Cuadradas]");
            Console.WriteLine($"El perímetro del Círculo es: {Perimetro} [Unidades]");
            Console.WriteLine("**************************************************************************************");
        }
        public static void DatosEstrella(string tipo)
        {
            //Impresión y recepción de la información del trapecio
            Console.WriteLine("**************************************************************************************");
            double Lado, Altura;
            Console.Write("Ingresa la longitud de un triangulo de la estrella: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la el apotema o altura del triangulo de la estrella: ");
            Altura = Convert.ToDouble(Console.ReadLine());
            (double Area, double Perimetro) = AreaPerimetroEstrella(Lado,Altura,tipo);
            Console.WriteLine($"El área de la estrella de 6 picos es: {Area} [Unidades Cuadradas]");
            Console.WriteLine($"El perímetro de la estrella de 6 picos es: {Perimetro} [Unidades]");
            /*
            //Llamado al método que determina al área y perímetro del Trapecio
            (double Area, double Perimetro) = AreaPerimetroTrapecio(BaseMayor, BaseMenor, Altura);
            Console.WriteLine($"El área del Trapecio es: {Area} [Unidades Cuadradas]");
            Console.WriteLine($"El períemetro del Trapecio es: {Perimetro} [Unidades]");
            */
            Console.WriteLine("**************************************************************************************");
        }
        public static (double, double) AreaPerimetroTrapecio(double BaseM, double Basem,double Altura)
        {
            double Area = ((BaseM + Basem) / 2) * Altura;
            double aCuadrado, bCuadrado;
            aCuadrado = ((BaseM - Basem) / 2)* ((BaseM - Basem) / 2);
            bCuadrado = Altura * Altura;
            double Pitagoras = Math.Sqrt(aCuadrado + bCuadrado);
            double Perimetro = Basem + BaseM + 2 * Pitagoras;
            return (Area, Perimetro); 
        }
        public static (double, double) AreaPerimetroCirculo(double Radio)
        {
            double Area = Math.PI * (Radio * Radio);
            double Perimetro = 2 * Math.PI * Radio;
            return (Area, Perimetro);
        }
        public static (double, double) AreaPerimetroEstrella(double Lado, double Apotema, string tipo)
        {
            double AreaEstrella, AreaTriangulo, AreaPoligono;
            double aCuadrado, bCuadrado;
            int lados = 0;
            if (tipo.Equals("Seis"))
            {
                lados = 6;
            }
            else if(tipo.Equals("Cinco"))
            {
                lados = 5;
            }

            AreaPoligono = (lados * Lado / 2) * Apotema;
            AreaTriangulo = (Lado * Apotema) / 2;
            AreaEstrella = AreaPoligono + (lados * AreaTriangulo);
            aCuadrado = (Lado / 2) * (Lado / 2);
            bCuadrado = Apotema * Apotema;
            double Pitagoras = Math.Sqrt(aCuadrado + bCuadrado);
            Console.WriteLine(Pitagoras);
            double Perimetro = lados * 2 * Pitagoras;
            return (AreaEstrella, Perimetro);
        }
    }
}