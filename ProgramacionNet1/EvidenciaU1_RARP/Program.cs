using System;
namespace UnidadUnoEA
{
    /*
     * El gobierno de México necesita un programa para registrar a las personas vacunadas de COVID-19, para ello 
     * solicita un programa que le permita ingresar información y cálcular a través de ella, una serie de parámetros 
     * que se desciben a continuación.
     * El usuario ingresará la siguiente información: Nombre, apellido materno, apellido paterno, edad, sexo (M ó F), 
     * fecha de nacimiento, fecha de aplicación de la vacuna, hora de aplicación de la vacuna, estado civil, discapacidad?, 
     * ingreso mensual y correo electrónico.
     * Posteriormente el programa realizará algunos cálculos para determinar la siguiente información:
     * o Tiempo de efectividad de la vacuna (Se considera que la vacuna será efectiva 180 días posteriores a la aplicación), 
     * el programa debe indicar la fecha en que la vacuna ya no es efectiva.
     * o Edad del paciente, el programa deberá calcular la edad del paciente a vacunar.
     * o El gobierno aplicará un impuesto del 1.5% del ingreso mensual del paciente por el costo de la vacuna y el programa debe indicarle dicho impuesto.
     * o Folio de vacunación que estará compuesto de la primer letra del nombre, segunda letra del apellido paterno, tercer letra del apellido materno, un número aleatorio entre 0 y 1000, una letra aleatoria.
     * o Dependiendo la hora de aplicación de la vacuna, el programa debe indicar al paciente que no puede hacer ejercicio hasta 5 horas posteriores a la aplicación de la vacuna, para ello le dirá la hora en que ya puede hacer ejercicio.
     * Finalmente mostrará en pantalla toda la información recabada del paciente y los parámetros calculados.
     */
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("hola desde aqui");
            string nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento;
            Console.Write("Ingresa el nombre del paciente: ");
            nombre = Console.ReadLine();

            Console.Write("Ingresa el apellido paterno del paciente: ");
            apellidoPaterno = Console.ReadLine();

            Console.Write("Ingresa el apellido materno del paciente: ");
            apellidoMaterno = Console.ReadLine();

            Console.Write("Ingresa la fecha de nacimiento del paciente en este formato AAAA/mm/dd: ");
            fechaNacimiento = Console.ReadLine();

            Console.WriteLine($"{nombre}, {apellidoPaterno} {apellidoMaterno} {fechaNacimiento}");
            PersonaRegistro personaRegistro = new PersonaRegistro(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento);
            personaRegistro.ToString();
            */

            string fechaNacimiento = "30/11/1994";
            string fechaVacunacion = "2021/10/11";
            Random random = new Random();


            //var Charsarr = new char[8];
            //var random = new Random();
            //Use of DateTime.Parse()   
            DateTime dateNow = DateTime.Now;
            DateTime dateNacimiento = DateTime.Parse(fechaNacimiento);
            DateTime dateVacunacion = DateTime.Parse(fechaVacunacion);
            DateTime efectividad =  dateVacunacion.AddDays(180);
            TimeSpan edad = dateNow - dateNacimiento;
            DateTime totalEdad = new DateTime(edad.Ticks);


            Console.WriteLine($"La efectividad de la vacuna es en la fecha: {CalcularEfectividad(fechaVacunacion)}");
            Console.WriteLine($"La edad del paciente es: {edad.TotalDays/365.2425}");
            Console.WriteLine($"La edad del paciente es: {CalcularEdad(fechaNacimiento)}");
            Console.WriteLine($"{RandomNumero()} {RandomLetra()}");


            //Console.WriteLine("The Date is: " + dateObject.Day + " " + dateObject.Month + " " + dateObject.Year);

        }
        static string CalcularEfectividad(string fechaVacunacion)
        {
            DateTime dateVacunacion = DateTime.Parse(fechaVacunacion);
            DateTime efectividad = dateVacunacion.AddDays(180);
            return efectividad.ToString("yyyy/MM/dd");
        }
        static int CalcularEdad(string fechaNacimiento)
        {
            DateTime dateNow = DateTime.Now;
            DateTime dateNacimiento = DateTime.Parse(fechaNacimiento);

            //obtengo la fecha en años, meses y dias
            int year = dateNow.Year - dateNacimiento.Year;
            int month = dateNow.Month - dateNacimiento.Month;
            int day = dateNow.Day - dateNacimiento.Day;
            Console.WriteLine($"meses {month} dias {day} year {year}");


            //hago la comparación
            if (month < 0)
            {
                //devuelvo la edad en años teniendo en cuenta la diferencia de meses
                return year - 1;
            }

            else if (month == 0)
            {
                //devuelvo la edad en años teniendo en cuenta la diferencia de días
                
                if (day>=0)
                {
                    return year;
                }
                else
                {
                    return year - 1;
                }                
            }

            else
            {
                return year;
            }
        }

        static int RandomNumero()
        {
            Random random = new Random();
            int valor = random.Next(0, 1001);
            return valor;
        }
        static char RandomLetra()
        {
            Random random = new Random();
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char letra = letras[random.Next(0, 26)];
            return letra;
        }
    }

    class PersonaRegistro
    {
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string fechaNacimiento;
        PersonaRegistro()
        {

        }
        public PersonaRegistro(string nombre, string apellidoPaterno, string apellidoMaterno, string fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.fechaNacimiento = fechaNacimiento;

        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void ToString()
        {
            Console.WriteLine($"El nombre es {nombre}, el apellido P. es: {apellidoPaterno} el apellido materno es {apellidoMaterno} nacimiento {fechaNacimiento}");
        }
    }
         

}
