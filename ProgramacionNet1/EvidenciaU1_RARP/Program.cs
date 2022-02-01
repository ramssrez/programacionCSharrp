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
            //Declaración de variables
            string nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correo, fechaVacunacion, horaVacunacion, estadoCivil, discapacidad;
            char sexo;
            double salario;
            //Impresión y solicitud de datos 
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de vacunación, ingresa los siguientes datos del paciente");
            Console.Write("Ingresa el nombre del paciente: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresa el apellido paterno del paciente: ");
            apellidoPaterno = Console.ReadLine();
            Console.Write("Ingresa el apellido materno del paciente: ");
            apellidoMaterno = Console.ReadLine();
            Console.Write("Ingresa la fecha de nacimiento del paciente en el siguiente formato (dd/MM/AAAA): ");
            fechaNacimiento = Console.ReadLine();
            Console.Write("Ingresa el sexo del paciente en el siguiente formato(M/F): ");
            sexo = Char.Parse(Console.ReadLine());
            Console.Write("Ingresa el salario del paciente: ");
            salario = Double.Parse(Console.ReadLine());
            Console.Write("Ingresa el correo del paciente ");
            correo = Console.ReadLine();
            Console.Write("Ingresa la fecha de vacunación del paciente en el siguiente formato (dd/MM/AAAA): ");
            fechaVacunacion = Console.ReadLine();
            Console.Write("Ingresa la hora de vacunación del paciente(07:00-19:00 hr) ");
            horaVacunacion = Console.ReadLine();
            Console.Write("Ingresa el estado civil del paciente: ");
            estadoCivil = Console.ReadLine();
            Console.Write("El paciente tiene discapacidad? (SI/NO): ");
            discapacidad = Console.ReadLine();
            /*
             * Datos para pruebas
            fechaNacimiento = "30/11/1994";
            fechaVacunacion = "11/10/2021";
            nombre = "Raúl";
            apellidoPaterno = "Ramírez";
            apellidoMaterno = "Pérez";
            sexo = 'M';
            correo = "ejemplo@gmail.com";
            discapacidad = "NO";
            estadoCivil = "Casado";
            salario = 15000.00;
            horaVacuanción = "13:30";
            */
            //Generación de objeto PersonaRegistro creandolo con los datos que agrego el usuario por medio de la consola
            PersonaRegistro personaRegistro = new PersonaRegistro(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, sexo, salario, correo, fechaVacunacion, horaVacunacion, estadoCivil, discapacidad);
            Console.WriteLine("**********************************************************************************************");
            //Impresión de pantalla de los datos del paciente
            personaRegistro.ToString();
            Console.WriteLine("**********************************************************************************************");
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
            HoraEjercicio = CalculoHora(horaAplicacion);
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
        //Método que realiza la suma de la hora entrada
        private string CalculoHora(string horavacunacion)
        {
            string horaEntrada = horavacunacion + ":00";
            string horasSuma = "05:00:00";
            //Creación de objetos de tipo TimeSpan agregando las partes del string de horas, donde se diferencia con ":" y se convierte a un entero 
            TimeSpan tsEntrada = new TimeSpan(Convert.ToInt32(horaEntrada.Split(':')[0]), Convert.ToInt32(horaEntrada.Split(':')[1]), Convert.ToInt32(horaEntrada.Split(':')[2]));
            TimeSpan tsSuma = new TimeSpan(Convert.ToInt32(horasSuma.Split(':')[0]), Convert.ToInt32(horasSuma.Split(':')[1]), Convert.ToInt32(horasSuma.Split(':')[2]));;
            //Asignación de la suma de las horas con el formato de horas y minutosm además de truncar la suma de horarios y con un formato específico
            string horaTotal = String.Format("{0}:{1}", Math.Truncate((tsEntrada + tsSuma).TotalHours).ToString("00"), (tsEntrada + tsSuma).Minutes.ToString("00"));
            //Retorno de la hora para realizar ejercicio
            return horaTotal;
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
                $"Hora de aplicación de vacuna: {HoraAplicacion} hr\n" +
                $"Fecha efectiva de vacuna: {FechaEfectivaVacuna} \n" +
                $"Impuesto(1.5%): ${Impuesto} \n" +
                $"Folio: {Folio} \n" +
                $"Hora para poder ejercitarse: {HoraEjercicio} hr\n");
        }
    }
}
