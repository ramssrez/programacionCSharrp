using System;
namespace UnidadTresEA
{
    //Inicio de de codificación del programa
    class Program
    {
        private static Paciente pacienteGeneral = null;
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            
            //Datos para pruebas
            string nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correo, tipoSangre, fechaConsulta, motivoConsulta, celuar, curp, sexo;
            nombre = "Raúl";
            apellidoPaterno = "Ramírez";
            apellidoMaterno = "Pérez";
            fechaNacimiento = "30/11/1994";
            sexo = "M";
            correo = "ejemplo@gmail.com";
            tipoSangre = "O+";
            fechaConsulta = "16/03/2022";
            motivoConsulta = "Dolor de estomago";
            celuar = "5514130475";
            curp = "RAPR920627HMACMRL02";
            pacienteGeneral = new Paciente(nombre,apellidoPaterno,apellidoMaterno,fechaNacimiento,sexo,correo,tipoSangre,fechaConsulta,motivoConsulta,celuar,curp);
            
            /*
            paciente.ToString();

            paciente.setCURP("AALA940625GTDKM01");
            paciente.ToString();

            paciente.setNumeroCelular("5514138900");
            paciente.ToString();

            /*
            Paciente paciente1 = new Paciente();
            paciente = null;
            paciente.ToString();
            */

            //Llamado el método que realiza la presentación del programa
            Presentacion();
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
                Console.WriteLine("1. Ingresar datos del paciente");
                Console.WriteLine("2. Informe del paciente");
                Console.WriteLine("3. Ingresar datos del paciente");
                Console.WriteLine("4. Ingresar datos del paciente");
                Console.WriteLine("5. Ingresar datos del paciente");
                Console.WriteLine("6. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos necesarios para la impresión del número
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        IngresarDatosPaciente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Opción para la finalización del programa
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        InformePaciente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        ActualizarDatosPaciente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        RegistrarConsulta();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 5");
                        InformeConsulta();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 6:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido salir de la aplicación");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 6");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
            }

        }
        private static void InformeConsulta()
        {
            if (validarPacienteNulo())
            {
                //pacienteGeneral.ToString();
            }
            else
            {
                Console.WriteLine("Aún no hay registro de un paciente");
            }
        }

        private static void RegistrarConsulta()
        {
            if (validarPacienteNulo())
            {
                //pacienteGeneral.ToString();
            }
            else
            {
                Console.WriteLine("Aún no hay registro de un paciente");
            }
        }

        private static void ActualizarDatosPaciente()
        {
            if (validarPacienteNulo())
            {
                //pacienteGeneral.ToString();
            }
            else
            {
                Console.WriteLine("Aún no hay registro de un paciente");
            }
        }
        private static void InformePaciente()
        {
            if (validarPacienteNulo())
            {
                Console.WriteLine($"*** Los datos del paciente {pacienteGeneral.Nombre} {pacienteGeneral.ApellidoPaterno} {pacienteGeneral.ApellidoMaterno} son los siguientes ***");
                pacienteGeneral.ToString();
            }
            else
            {
                Console.WriteLine("Aún no hay registro de un paciente");
            }
        }
        public static void IngresarDatosPaciente()
        {
            pacienteGeneral = null;
            string nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, correo, tipoSangre, fechaConsulta, motivoConsulta, celuar, curp, sexo;
            nombre = ValidarSoloString("Ingresa el nombre del paciente: ");
            apellidoPaterno = ValidarSoloString("Ingresa el apellido paterno del paciente: ");
            apellidoMaterno = ValidarSoloString("Ingresa el apellido materno del paciente: ");
            fechaNacimiento = ValidarFecha("Ingresa la fecha de nacimiento del paciente en el siguiente formato (dd/MM/AAAA): ");
            sexo = ValidarSoloString("Ingresa el sexo del paciente (Masculino/Femenino): ");
            correo = ValidarString("Ingresa el correo del paciente: ");
            tipoSangre = ValidarString("Ingresa el tipo de sangre del paciente: ");
            fechaConsulta = ValidarFecha("Ingresa la fecha de consulta del paciente en el siguiente formato (dd/MM/AAAA): ");
            motivoConsulta = ValidarString("Ingresa el motivo de la consulta: ");
            celuar = ValidarTamanioNumero("Ingresa el número de celular del paciente: ");
            curp = ValidarString("Ingresa el CURP del paciente: ");
            pacienteGeneral = new Paciente(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, sexo, correo, tipoSangre, fechaConsulta, motivoConsulta, celuar, curp);
        }
        private static bool validarPacienteNulo()
        {
            bool badera = false;
            if (pacienteGeneral != null)
            {
                badera = true;
            }
            else
            {
                badera = false;
            }
            return badera;
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
                    Console.WriteLine("Error al ingresar el texto, vuelve a intentarlo");
                }
            }
            return s;
        }
        public static string ValidarTamanioNumero(string mensaje)
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
                    if (s.Length < 10 || s.Length > 10)
                    {
                        Console.WriteLine("El número tiene que ser de 10 digitos, intenta de nuevo");
                    }
                    else
                    {
                        salir = true;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error el número, intenta de nuevo");
                }
            }
            return s;
        }
        public static string ValidarFecha(string mensaje)
        {
            DateTime fecha;
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas de un caracter
            while (!salir)
            {
                try
                {
                    Console.Write(mensaje);
                    s = Console.ReadLine();
                    if (!DateTime.TryParse(s,out fecha))
                    {
                        Console.WriteLine("La fecha no cuenta con el formato establecido, vuelve a intentarlo");
                    }
                    else
                    {
                        salir = true;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error al ingresar la fecha, intenta de nuevo");
                }
            }
            return s;
        }
        //Metodo que permite identificar si los caracteres son letras o no
        public static bool SoloLetras(string sCaracteres)
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
        public static bool EspacioVacio(string sCaracteres)
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
        //Declaración de variables y métodos getter y setter del objeto Paciente
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string TipoSangre { get; set; }
        public string FechaConsulta { get; set; }
        public string MotivoConsulta { get; set; }
        public string CorreoElectronico { get; set; }
        public string Folio { get; set; }
        //Declaración de atributos para poder manipular los getters y setter
        private string NumeroCelular;
        private string CURP;

        //Declaración de constructor vacío de la clase
        public Paciente()
        {

        }
        //Declaración del constructor de la clase con los elementos que se registraron a partir de la consola
        public Paciente(string nombre, string apellidoPaterno, string apellidoMaterno, string fechaNacimiento, 
            string sexo, string correo, string tipoSangre, string fechaConsulta, string motivoConsulta, string numeroCelular, string curp)
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
        //Declaración de los getters y setter para el núemero celular y el curp
        public void setNumeroCelular(string numeroCelular)
        {
            NumeroCelular = numeroCelular;
            //Reasignamiento del folio  del paciente
            Folio = FolioPaciente(CURP, numeroCelular);
        }
        public string getNumeroCelular()
        {
            return NumeroCelular;
        }
        public void setCURP(string curp)
        {
            CURP = curp;
            //Reasignamiento del folio  del paciente
            Folio = FolioPaciente(curp, NumeroCelular);
        }
        public string getCURP()
        {
            return CURP;
        }
        //Método que calcula la edad del paciente con la diferencia de fechas, la fecha actual y la fecha de nacimiento
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
        //Método que permite generar el folio del paciente, en función del curp y numero celular
        private string FolioPaciente(string curp, string numeroCelular)
        {
            //Obtención de los cuatro caracters del curp
            string cuatroCaracter = curp.Substring(0, 4);
            //Obtención de los ultimos cuatro caracteres del celular
            string ultimosDigitos = numeroCelular.Substring((numeroCelular.Length - 4), 4);
            //Retorno del folio generado
            return cuatroCaracter + ultimosDigitos;
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
