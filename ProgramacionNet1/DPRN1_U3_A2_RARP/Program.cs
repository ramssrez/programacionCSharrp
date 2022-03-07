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
            //Varaible para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Área y perímetro de un Trapecio");
                Console.WriteLine("2. Área y perímetro de una Estrella de 6 puntas");
                Console.WriteLine("3. Área y perímetro de un Círculo");
                Console.WriteLine("4. Área y perímetro de una Estrella de 5 puntas");
                Console.WriteLine("5. Salir");
                Console.Write("Ingresa una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos del trapecio e impresión de cálculos
                    case 1:
                        Console.WriteLine("Has elegido la opción 1");
                        DatosTrapecio();
                        break;
                    //Llamado del método para ingresar los datos de la estrella de 6 picos e impresión de cálculos
                    case 2:
                        Console.WriteLine("Has elegido la opción 2");
                        DatosEstrella("Seis");
                        break;
                    //Llamado del método para ingresar los datos del circulo e impresión de cálculos
                    case 3:
                        Console.WriteLine("Has elegido la opción 3");
                        DatosCirculo();
                        break;
                    //Llamado del método para ingresar los datos de la estrella de 5 picos e impresión de cálculos
                    case 4:
                        Console.WriteLine("Has elegido la opción 4");
                        DatosEstrella("Cinco");
                        break;
                    //Finalización del programa
                    case 5:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 5");
                        break;
                }
            }
        }
        //Método que recibe los datos del trapecio
        public static void DatosTrapecio()
        {
            //Impresión y recepción de la información del trapecio
            Console.WriteLine("**************************************************************************************");
            //Declaración de variables para asignar con lo que se ingrese en la consola
            double BaseMayor, BaseMenor, Altura;
            Console.Write("Ingresa la base mayor del Trapecio: ");
            BaseMayor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la base menor del Trapecio: ");
            BaseMenor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la altura del Trapecio: ");
            Altura = Convert.ToDouble(Console.ReadLine());
            //Llamado al método que determina al área y perímetro del Trapecio
            (double Area, double Perimetro) = AreaPerimetroTrapecio(BaseMayor,BaseMenor,Altura);
            //Impresión de los calculos realizados.
            Console.WriteLine($"El área del Trapecio es: {Area} [Unidades Cuadradas]");
            Console.WriteLine($"El perímetro del Trapecio es: {Perimetro} [Unidades]");
            Console.WriteLine("**************************************************************************************");
        }
        //Método que recibe los datos de un circulo.
        public static void DatosCirculo()
        {
            //Impresión y recepción de la información del circulo
            Console.WriteLine("**************************************************************************************");
            //Declaración de variables para asignar con lo que se ingrese en la consola
            double Radio;
            Console.Write("Ingresa el Radio del Círculo: ");
            Radio = Convert.ToDouble(Console.ReadLine());
            //Llamado al método que determina al área y perímetro del círculo
            (double Area, double Perimetro) = AreaPerimetroCirculo(Radio);
            //Impresión de los calculos realizados.
            Console.WriteLine($"El área del Círculo es: {Area} [Unidades Cuadradas]");
            Console.WriteLine($"El perímetro del Círculo es: {Perimetro} [Unidades]");
            Console.WriteLine("**************************************************************************************");
        }
        //Metodo que recibe los datos de la estrella 
        public static void DatosEstrella(string tipo)
        {
            //Impresión y recepción de la información de al estrella
            Console.WriteLine("**************************************************************************************");
            //Declaración de variables para asignar con lo que se ingrese en la consola
            double Lado, Altura;
            Console.Write("Ingresa la longitud de un triangulo de la estrella: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la el apotema o altura del triangulo de la estrella: ");
            Altura = Convert.ToDouble(Console.ReadLine());
            //Llamado al método que determina al área y perímetro del círculo
            (double Area, double Perimetro) = AreaPerimetroEstrella(Lado,Altura,tipo);
            //Impresión de los calculos realizados.
            Console.WriteLine($"El área de la estrella de 6 picos es: {Area} [Unidades Cuadradas]");
            Console.WriteLine($"El perímetro de la estrella de 6 picos es: {Perimetro} [Unidades]");
            Console.WriteLine("**************************************************************************************");
        }
        //Método que realizar el calculo del perímetro y área del trapecio
        public static (double, double) AreaPerimetroTrapecio(double BaseM, double Basem,double Altura)
        {
            //Declaración de variables necesarias para realizar los calculos
            double Area = ((BaseM + Basem) / 2) * Altura;
            double aCuadrado, bCuadrado;
            //Uso del teorema de pítagoras para calcular las longitudes del lado izquierdo y del lado derecho del trapecio
            aCuadrado = ((BaseM - Basem) / 2)* ((BaseM - Basem) / 2);
            bCuadrado = Altura * Altura;
            double Pitagoras = Math.Sqrt(aCuadrado + bCuadrado);
            double Perimetro = Basem + BaseM + 2 * Pitagoras;
            //Retorno del área y perímetro del Trapecio
            return (Area, Perimetro); 
        }
        //Método que realiza el calculo del area y perimetro de un circulo.
        public static (double, double) AreaPerimetroCirculo(double Radio)
        { 
            //Declaración de variables necesarias para realizar los calculos
            double Area = Math.PI * (Radio * Radio);
            double Perimetro = 2 * Math.PI * Radio;
            //Retorno de área y perímetro del circulo
            return (Area, Perimetro);
        }
        //Método que realiza el calculo del área y perímetro de una estrella
        public static (double, double) AreaPerimetroEstrella(double Lado, double Apotema, string tipo)
        {
            //Declaración de varaibles necesarias para realizar los cálculos necesarios.
            double AreaEstrella, AreaTriangulo, AreaPoligono;
            double aCuadrado, bCuadrado;
            int lados = 0;
            //Sentencia if/else donde se le asigna el valor de lados de poligono o la estrella
            if (tipo.Equals("Seis"))
            {
                lados = 6;
            }
            else if(tipo.Equals("Cinco"))
            {
                lados = 5;
            }
            //Cálculo de las areas del poligono (pentagono, hexagono, etc) y de los tringulos o puntas de la estrella
            AreaPoligono = (lados * Lado / 2) * Apotema;
            AreaTriangulo = (Lado * Apotema) / 2;
            AreaEstrella = AreaPoligono + (lados * AreaTriangulo);
            //Uso del teorema de Pítagoras para calcular la longitud de los triangulos o puntas
            aCuadrado = (Lado / 2) * (Lado / 2);
            bCuadrado = Apotema * Apotema;
            double Pitagoras = Math.Sqrt(aCuadrado + bCuadrado);
            Console.WriteLine(Pitagoras);
            double Perimetro = lados * 2 * Pitagoras;
            //Retorno del área y perímetro de los cálculos realizados.
            return (AreaEstrella, Perimetro);
        }
    }
}