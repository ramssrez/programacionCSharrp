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
            string fechaVacunacion = "11/10/2021";
            string nombre = "Raúl";
            string apellidoPaterno = "Ramírez";
            string apellidoMaterno = "Pérez";
            char sexo = 'M';
            string correo = "ramssrez@gmail.com";
            string discapacidad = "NO";
            PersonaRegistro personaRegistro = new PersonaRegistro(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento,sexo,15000.0,correo,fechaVacunacion,"13:30","Casado",discapacidad);
            personaRegistro.HoraEjercicio = "12:00";
            personaRegistro.ToString();

            /*
            char letraNombre = nombre[0];
            char letraPaterno = apellidoPaterno[1];
            char letraMat = apellidoMaterno[2];
            Console.WriteLine($"Folio Vacunación:{Char.ToUpper(letraNombre)}{Char.ToUpper(letraPaterno)}{Char.ToUpper(letraMat)}-{RandomNumero()}-{RandomLetra()}");



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
            Console.WriteLine($"Folio{Folio(nombre, apellidoPaterno, apellidoMaterno)}");

            //Console.WriteLine("The Date is: " + dateObject.Day + " " + dateObject.Month + " " + dateObject.Year);
            PersonaRegistro personaRegistro = new PersonaRegistro(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento);
            personaRegistro.Age = 25;
            Console.WriteLine(personaRegistro.Age);
            */

        }

    }

    class PersonaRegistro
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public double IngresoMensual { get; set; }
        public string Correo { get; set; }
        public string FechaAplicacion { get; set; }
        public string HoraAplicacion { get; set; }
        public string EstadoCivil { get; set; }
        public string Discapacidad { get; set; }
        public int Edad { get; set; }
        public string FechaEfectivaVacuna { get; set; }
        public double Impuesto { get; set; }
        public string Folio { get; set; }
        public string HoraEjercicio { get; set; }
        PersonaRegistro()
        {

        }
        public PersonaRegistro(string nombre, string apellidoPaterno, string apellidoMaterno, string fechaNacimiento)
        {
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.FechaNacimiento = fechaNacimiento;

        }

        public PersonaRegistro(string nombre, string apellidoPaterno, string apellidoMaterno, string fechaNacimiento, char sexo, double ingresoMensual, string correo, string fechaAplicacion, string horaAplicacion, string estadoCivil, string discapacidad)
        {
            Nombre = nombre;
            ApellidoMaterno = apellidoMaterno;
            ApellidoPaterno = apellidoPaterno;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            IngresoMensual = ingresoMensual;
            Correo = correo;
            FechaAplicacion = fechaAplicacion;
            HoraAplicacion = horaAplicacion;
            EstadoCivil = estadoCivil;
            Discapacidad = discapacidad;
            FechaEfectivaVacuna = CalcularEfectividad(fechaAplicacion);
            Edad = CalcularEdad(fechaNacimiento);
            Folio = FolioVacunacion(nombre, apellidoPaterno, apellidoMaterno);
            Impuesto = ImpuestoVacuna(ingresoMensual);
        }
        private string CalcularEfectividad(string fechaVacunacion)
        {
            DateTime dateVacunacion = DateTime.Parse(fechaVacunacion);
            DateTime efectividad = dateVacunacion.AddDays(180);
            return efectividad.ToString("dd/MM/yyyy");
        }
        private int CalcularEdad(string fechaNacimiento)
        {
            DateTime dateNow = DateTime.Now;
            DateTime dateNacimiento = DateTime.Parse(fechaNacimiento);

            //obtengo la fecha en años, meses y dias
            int year = dateNow.Year - dateNacimiento.Year;
            int month = dateNow.Month - dateNacimiento.Month;
            int day = dateNow.Day - dateNacimiento.Day;
            //hago la comparación
            if (month < 0)
            {
                //devuelvo la edad en años teniendo en cuenta la diferencia de meses
                return year - 1;
            }

            else if (month == 0)
            {
                //devuelvo la edad en años teniendo en cuenta la diferencia de días

                if (day >= 0)
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
        private int RandomNumero()
        {
            Random random = new Random();
            int valor = random.Next(0, 1001);
            return valor;
        }
        private char RandomLetra()
        {
            Random random = new Random();
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char letra = letras[random.Next(0, 26)];
            return letra;
        }
        private string FolioVacunacion(string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            string folio;
            char letraNombre = nombre[0];
            char letraPaterno = apellidoPaterno[1];
            char letraMat = apellidoMaterno[2];
            folio = $"{Char.ToUpper(letraNombre)}{Char.ToUpper(letraPaterno)}{Char.ToUpper(letraMat)}-{RandomNumero()}-{RandomLetra()}";
            return folio;
        }
        private double ImpuestoVacuna(double salario)
        {
            return ((salario*1.6)/100);
        }

        public void ToString()
        {
            Console.WriteLine("Los datos del paciente e historial de vacunación");
            Console.WriteLine($"Nombre del paciente: {Nombre} \n" +
                $"Apellido Paterno: {ApellidoPaterno} \n" +
                $"Apellido Materno {ApellidoMaterno} \n" +
                $"Fecha de Nacimiento: {FechaNacimiento} \n" +
                $"Sexo: {Sexo} \n" +
                $"Edad: {Edad}\n" +
                $"Estado Civil: {EstadoCivil} \n" +
                $"Ingreso Mensual: ${IngresoMensual} \n" +
                $"Correo: {Correo} \n" +
                $"Discapacidad: {Discapacidad} \n" +
                $"Fecha de aplicación de vacuna: {FechaAplicacion} \n" +
                $"Hora de aplicación de vacuna: {HoraAplicacion} \n" +
                $"Fecha efectiva de vacuna: {FechaEfectivaVacuna} \n" +
                $"Impuesto(1.5%): ${Impuesto} \n" +
                $"Folio: {Folio} \n" +
                $"Hora para poder ejercitarse: {HoraEjercicio} \n");
        }
    }
}
