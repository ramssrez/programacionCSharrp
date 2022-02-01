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
            string nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correo, fechaAplicacion, horaAplicacion, estadoCivil, discapacidad,;
            char sexo;
            double ingreso;
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de vacunación, ingresa los siguientes datos del paciente");
           */
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
            string estadoCivil = "Casado";
            double salario = 15000.25;
            string horaVacuanción = "13:30";
            PersonaRegistro personaRegistro = new PersonaRegistro(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento,sexo,salario,correo,fechaVacunacion,horaVacuanción,estadoCivil,discapacidad);
            personaRegistro.HoraEjercicio = "13:30" + "12:00";

            var Time1 = "19:30:00";
            var Time2 = "05:00:00";
            var TimeSpan1 = new TimeSpan(Convert.ToInt32(Time1.Split(':')[0]), Convert.ToInt32(Time1.Split(':')[1]), Convert.ToInt32(Time1.Split(':')[2]));
            var TimeSpan2 = new TimeSpan(Convert.ToInt32(Time2.Split(':')[0]), Convert.ToInt32(Time2.Split(':')[1]), Convert.ToInt32(Time2.Split(':')[2]));
            string Time3 = String.Format("{0}:{1}:{2}", Math.Truncate((TimeSpan1 + TimeSpan2).TotalHours).ToString("00"), (TimeSpan1 + TimeSpan2).Minutes.ToString("00"), (TimeSpan1 + TimeSpan2).Seconds.ToString("00"));
            //Console.WriteLine((TimeSpan1 + TimeSpan2).TotalHours).ToString("00"));
            Console.WriteLine(Time3);
            //personaRegistro.HoraEjercicio = Time3;
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
        //Declaración de variables y métodos getter y setter del objeto PersonaRegistro
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
        //Declaración de constructor vacío de la clase
        PersonaRegistro()
        {

        }
        //Declaración del constructor de la clase con los elementos que se registraron a partir de la consola
        public PersonaRegistro(string nombre, string apellidoPaterno, string apellidoMaterno, string fechaNacimiento, char sexo, double ingresoMensual, string correo, string fechaAplicacion, string horaAplicacion, string estadoCivil, string discapacidad)
        {
            //Asignación de los atributos de la clase con los datos que se ingresaron en la consola
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
            //Asignación de atributos de la clase con métodos que se encuentran dentro de la clase
            FechaEfectivaVacuna = CalcularEfectividad(fechaAplicacion);
            Edad = CalcularEdad(fechaNacimiento);
            Folio = FolioVacunacion(nombre, apellidoPaterno, apellidoMaterno);
            Impuesto = ImpuestoVacuna(ingresoMensual);
        }
        //Método que permite calcular la efectividad de la vacuna
        private string CalcularEfectividad(string fechaVacunacion)
        {
            //Tranformación del string de la fecha de vacunación a un tipo DateTime
            DateTime dateVacunacion = DateTime.Parse(fechaVacunacion);
            //Agregación de los dias efectivos que son 180 días despues de la vacunación con el uso del método AddDays()
            DateTime efectividad = dateVacunacion.AddDays(180);
            //Retorno de la fecha de efectividad en formato dd/MM/yyyy
            return efectividad.ToString("dd/MM/yyyy");
        }
        //Método que calcula la edad del paciente con la diferencia de fechas, la fecha actual y la fecha de nacimientos
        private int CalcularEdad(string fechaNacimiento)
        {
            //Determinación de la fecha actual
            DateTime dateNow = DateTime.Now;
            //Parseo de la fecha de nacimiento a un tipo DateTime
            DateTime dateNacimiento = DateTime.Parse(fechaNacimiento);

            //Obtención del año, meses y dias de la resta entre las fechas
            int year = dateNow.Year - dateNacimiento.Year;
            int month = dateNow.Month - dateNacimiento.Month;
            int day = dateNow.Day - dateNacimiento.Day;
            //Comparación de los meses para determinar el número de años con if/else
            if (month < 0)
            {
                //Retorno de la edad en años, cuando la diferencia de meses es menor a cero
                return year - 1;
            }
            //else if para el caso de que los meses sean igual a cero, se verifica la diferencia entre los días
            else if (month == 0)
            {
                //En caso de que los dias son mayores o igual a cero se retorna el año
                if (day >= 0)
                {
                    return year;
                }
                else
                {
                    //En caso contrario se le resta un -1 al año
                    return year - 1;
                }
            }
            //En caso de las ultimas dos opciones no fueran correctas se retorna el año
            else
            {
                return year;
            }
        }
        //Método que permite generar un número aleatorio entre 0 al 1000
        private int RandomNumero()
        {
            //Declaración de la clase Random
            Random random = new Random();
            //Declaración del valor a retornar y el rango para generarlos 
            int valor = random.Next(0, 1001);
            //Retorno del valor generado
            return valor;
        }
        //Método que permite seleccionar una letra random de un arreglo
        private char RandomLetra()
        {
            //Declaración de la clase Random
            Random random = new Random();
            //Declaración del arreglo que contiene las letras del abcedario que vamos a utilizar
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //Selección de las letras random
            char letra = letras[random.Next(0, 26)];
            //Retorno de la letra seleccioanda
            return letra;
        }
        //Método que permite generar el folio de vacunación del paciente, en función de su nombre y apellidos
        private string FolioVacunacion(string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            string folio;
            //Selección de la primera letra del nombre
            char letraNombre = nombre[0];
            //Seleccion de la segunda letra del apellido paterno
            char letraPaterno = apellidoPaterno[1];
            //Selección de la tercera letra del apellido materno
            char letraMat = apellidoMaterno[2];
            //Generación del folio, usando métodos para pasar a mayusculas las letras seleccionadas y los métodos random
            folio = $"{Char.ToUpper(letraNombre)}{Char.ToUpper(letraPaterno)}{Char.ToUpper(letraMat)}-{RandomNumero()}-{RandomLetra()}";
            //Retorno del folio generado
            return folio;
        }
        //Método que realiza el calculo del impuesto de la vacuna en función del salario del paciente
        private double ImpuestoVacuna(double salario)
        {
            return ((salario*1.6)/100);
        }
        //Método que permite imprimir los datos de la clase con formato para este caso en especifico
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
