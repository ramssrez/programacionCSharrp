using System;
namespace UnidadTresEA
{
    //Inicio de de codificación del programa
    class Program
    {
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            string nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correo, tipoSangre, fechaConsulta, motivoConsulta, celuar, curp;
            char sexo;
            nombre = "Raúl";
            apellidoPaterno = "Ramírez";
            apellidoMaterno = "Pérez";
            fechaNacimiento = "30/11/1994";
            sexo = 'M';
            correo = "ejemplo@gmail.com";
            tipoSangre = "O+";
            fechaConsulta = "16/03/2022";
            motivoConsulta = "Dolor de estomago";
            celuar = "5514130475";
            curp = "RAPR920627HMACMRL02";
            Paciente paciente = new Paciente(nombre,apellidoPaterno,apellidoMaterno,fechaNacimiento,sexo,correo,tipoSangre,fechaConsulta,motivoConsulta,celuar,curp);
            paciente.ToString();

            paciente.setCURP("AALA940625GTDKM01");
            paciente.ToString();

            paciente.setNumeroCelular("5514138900");
            paciente.ToString();
            


            //Llamado el método que realiza la presentación del programa
            //Presentacion();
        }
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema para transformar tu número en binario");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Ingresar datos");
                Console.WriteLine("2. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos necesarios para la impresión del número
                    case 1:
                        Console.WriteLine("Has elegido la opción 1");
                        //IngresoDatosMatriz();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Opción para la finalización del programa
                    case 2:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 2");
                        break;
                }
            }

        }
        //Método que varifica si es un entero el valor ingresado desde la consola, se repite hasta que sea correcto
        public static int ValidarNumero(string mensaje)
        {
            //Declaración de variables necesarias para realizar el programa
            bool salir = false;
            int valor = 0;
            //Ciclo while que se repite en caso de que no se haya  ingresado un entero o sea menor a cuatro
            while (!salir)
            {
                //Uso de la sentencia try/catch para el caso de que no se ingrese un entero
                try
                {
                    Console.Write(mensaje);
                    valor = Convert.ToInt32(Console.ReadLine());
                    //Llamado al metodo para verificar que el valor ingresado sea mayor a cuatro
                    salir = true;
                }
                catch (FormatException ex)
                {
                    //Mensaje de error en caso de que no se haya ingresado un entero
                    Console.WriteLine("Error al ingresa valor, vuelve a intentarlo");
                }
                catch (OverflowException ex)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine("Número demasiado grande, intenta con otro número");
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
        //Método que reliza la validación de un caracter hasta que se cumpla que sea correcto
        public static string ValidarSoloString(string mensaje)
        {
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas de un caracter
            while (!salir)
            {
                Console.Write(mensaje);
                s = Console.ReadLine();
                if (!SoloLetras(s))
                {
                    Console.WriteLine("Ingresa solo letras, sin espacios");
                }else if (string.IsNullOrEmpty(s))
                {
                    Console.WriteLine("El string se encuentra vacío, vuelve a intentarlo");
                }
                else
                {
                    salir = true;
                }                
            }

            //Retorno del string que se ha ingresado
            return s;
        }
        public static string ValidarString(string mensaje)
        {
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas de un caracter
            while (!salir)
            {
                try
                {
                    Console.Write(mensaje);
                    s = Console.ReadLine();
                    if (string.IsNullOrEmpty(s))
                    {
                        Console.WriteLine("El string se encuentra vacío, vuelve a intentarlo");
                    }
                    else if(EspacioVacio(s))
                    {
                        Console.WriteLine("Ingresa un string sin espacios");
                    }
                    else
                    {
                        salir = true;
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error al ingresar el string");
                }
            }
            return s;
        }
        //Metodo que permite identificar si los caracteres son letras o no
        static bool SoloLetras(string sCaracteres)
        {
            foreach (char ch in sCaracteres)
            {
                if (!Char.IsLetter(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool EspacioVacio(string sCaracteres)
        {
            foreach (char ch in sCaracteres)
            {
                if (ch != 32)
                {
                    return false;
                }
            }
            return true;
        }

    }

    class Paciente
    {
        //Declaración de variables y métodos getter y setter del objeto PersonaRegistro
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public string TipoSangre { get; set; }
        public string FechaConsulta { get; set; }
        public string MotivoConsulta { get; set; }
        public string CorreoElectronico { get; set; }
        public string Folio { get; set; }
        public string NumeroCelular;
        public string CURP;

        //Declaración de constructor vacío de la clase
        Paciente()
        {

        }
        //Declaración del constructor de la clase con los elementos que se registraron a partir de la consola
        public Paciente(string nombre, string apellidoPaterno, string apellidoMaterno, string fechaNacimiento, 
            char sexo, string correo, string tipoSangre, string fechaConsulta, string motivoConsulta, string numeroCelular, string curp)
        {
            //Asignación de los atributos de la clase con los datos que se ingresaron en la consola
            Nombre = nombre;
            ApellidoMaterno = apellidoMaterno;
            ApellidoPaterno = apellidoPaterno;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            TipoSangre = tipoSangre;
            FechaConsulta = fechaConsulta;
            MotivoConsulta = motivoConsulta;
            NumeroCelular = numeroCelular;
            CURP = curp;
            CorreoElectronico = correo;
            //Asignación de atributos de la clase con métodos que se encuentran dentro de la clase
            Edad = CalcularEdad(fechaNacimiento);
            Folio = FolioPaciente(curp,numeroCelular);
        }
        public void setNumeroCelular(string numeroCelular)
        {
            NumeroCelular = numeroCelular;
            Folio = FolioPaciente(CURP, numeroCelular);
        }
        public string getNumeroCelular()
        {
            return NumeroCelular;
        }
        public void setCURP(string curp)
        {
            CURP = curp;
            Folio = FolioPaciente(curp, NumeroCelular);
        }
        public string getCURP()
        {
            return CURP;
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
        //Método que permite generar el folio de vacunación del paciente, en función de su nombre y apellidos
        
        private string FolioPaciente(string curp, string numeroCelular)
        {
            string folio;
            string cuatroCaracter = curp.Substring(0, 4);
            string ultimosDigitos = numeroCelular.Substring((numeroCelular.Length - 4), 4);
            folio = cuatroCaracter + ultimosDigitos;
            //Retorno del folio generado
            return folio;
        }
        
        //Método que permite imprimir los datos de la clase con formato para este caso en especifico
        public void ToString()
        {
            //Console.WriteLine("Los datos del paciente e historial de vacunación");
            Console.WriteLine($"Nombre del paciente: {Nombre} \n" +
                $"Apellido Paterno: {ApellidoPaterno} \n" +
                $"Apellido Materno: {ApellidoMaterno} \n" +
                $"Fecha de Nacimiento: {FechaNacimiento} \n" +
                $"Sexo: {Sexo} \n" +
                $"Edad: {Edad} años \n" +
                $"Correo: {CorreoElectronico} \n" +
                $"Tipo de Sangre: {TipoSangre} \n" +
                $"Fecha Consulta: {FechaConsulta} \n" +
                $"Motivo Consulta: {MotivoConsulta} \n" +
                $"Número Celular: {NumeroCelular} \n" +
                $"CURP: {CURP} \n" +
                $"Folio: {Folio} \n");
        }
    }
}
