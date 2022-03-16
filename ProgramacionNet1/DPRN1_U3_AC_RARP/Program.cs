using System;
namespace UnidadTresEA
{
    //Inicio de de codificación del programa
    class Program
    {
        //Declaración de la variable paciente general para poder manipularlo en toda la ejecución de la aplicación
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
            curp = "RAPR920627HMCMRL02";
            pacienteGeneral = new Paciente(nombre,apellidoPaterno,apellidoMaterno,fechaNacimiento,sexo,correo,tipoSangre,fechaConsulta,motivoConsulta,celuar,curp);

            //Llamado el método que realiza la presentación del programa
            Presentacion();
        }
        //Método que muestra el menú principal para poder realiar el llamado a los diferentes métodos
        public static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema para gestión de pacientes");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Ingresar datos del paciente");
                Console.WriteLine("2. Informe del paciente");
                Console.WriteLine("3. Actualizar datos del paciente");
                Console.WriteLine("4. Registrar consulta");
                Console.WriteLine("5. Informe de la consulta");
                Console.WriteLine("6. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos del paciente
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        IngresarDatosPaciente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Llamado al método para imprimir la información del paciente
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        InformePaciente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                        //Llamado al método para actualizar la información del cliente
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        ActualizarDatosPaciente();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Llamado al método para registrar una consulta para el paciente
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        RegistrarConsulta();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        //Llamado al metodo para mostrar el informe de la consulta
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 5");
                        InformeConsulta();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 6:
                        //Opción para la salida del programa
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
                MenuActualizarPaciente();
            }
            else
            {
                Console.WriteLine("Aún no hay registro de un paciente");
            }
        }

        private static void MenuActualizarPaciente()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine($"Actualización de la información del paciente {pacienteGeneral.Nombre} {pacienteGeneral.ApellidoPaterno} {pacienteGeneral.ApellidoMaterno}.");
            Console.WriteLine("Selecciona una opción del menú para actualizar la información");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Nombre");
                Console.WriteLine("2. Apellido Paterno");
                Console.WriteLine("3. Apellido Materno");
                Console.WriteLine("4. Fecha de nacimiento");
                Console.WriteLine("5. Sexo");
                Console.WriteLine("6. Tipo de sangre");
                Console.WriteLine("7. Fecha consulta");
                Console.WriteLine("8. Motivo consulta");
                Console.WriteLine("9. Correo electronico");
                Console.WriteLine("10. Número de celular");
                Console.WriteLine("11. CURP");
                Console.WriteLine("12. Salir al menú principal");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Llamado del método para ingresar los datos del paciente
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        pacienteGeneral.Nombre = ValidarSoloString("Ingresa el nombre del paciente: ");
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Llamado al método para imprimir la información del paciente
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        pacienteGeneral.ApellidoPaterno = ValidarSoloString("Ingresa el apellido paterno del paciente: ");
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Llamado al método para actualizar la información del cliente
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        pacienteGeneral.ApellidoMaterno = ValidarSoloString("Ingresa el apellido materno del paciente: ");
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 4:
                        //Llamado al método para registrar una consulta para el paciente
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        pacienteGeneral.setFechaNacimiento(ValidarFecha("Ingresa la fecha de nacimiento del paciente en el siguiente formato (dd/MM/AAAA): "));
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        //Llamado al metodo para mostrar el informe de la consulta
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 5");
                        pacienteGeneral.Sexo = ValidarSoloString("Ingresa el sexo del paciente (Masculino/Femenino): ");
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 6:
                        //Llamado al metodo para mostrar el informe de la consulta
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 6");
                        pacienteGeneral.TipoSangre = ValidarString("Ingresa el tipo de sangre del paciente: ");
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 7:
                        //Llamado al metodo para mostrar el informe de la consulta
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 7");
                        pacienteGeneral.FechaConsulta = ValidarFecha("Ingresa la fecha de consulta del paciente en el siguiente formato (dd/MM/AAAA): ");
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 8:
                        //Llamado al metodo para mostrar el informe de la consulta
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 8");
                        pacienteGeneral.MotivoConsulta = ValidarString("Ingresa el motivo de la consulta: ");
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 9:
                        //Llamado al metodo para mostrar el informe de la consulta
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 9");
                        pacienteGeneral.CorreoElectronico = ValidarString("Ingresa el correo electronico del paciente: ");
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 10:
                        //Llamado al metodo para mostrar el informe de la consulta
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 10");
                        pacienteGeneral.setNumeroCelular(ValidarTamanioNumero("Ingresa el número de celular del paciente: "));
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 11:
                        //Llamado al metodo para mostrar el informe de la consulta
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 11");
                        pacienteGeneral.setCURP(ValidarString("Ingresa el CURP del paciente: "));
                        Console.WriteLine("Actualización realizada exitosamente....");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 12:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Retornando al menú principal");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 12");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
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
        //Método que ingresa los datos del paciente
        public static void IngresarDatosPaciente()
        {
            //Declaración del pacinte general como nulo
            pacienteGeneral = null;
            //Declaracion de varibles para llenar los datos del paciente, así como la asignación de los datos al paciente
            string nombre = ValidarSoloString("Ingresa el nombre del paciente: ");
            string apellidoPaterno = ValidarSoloString("Ingresa el apellido paterno del paciente: ");
            string apellidoMaterno = ValidarSoloString("Ingresa el apellido materno del paciente: ");
            string fechaNacimiento = ValidarFecha("Ingresa la fecha de nacimiento del paciente en el siguiente formato (dd/MM/AAAA): ");
            string sexo = ValidarSoloString("Ingresa el sexo del paciente (Masculino/Femenino): ");
            string correo = ValidarString("Ingresa el correo electronico del paciente: ");
            string tipoSangre = ValidarString("Ingresa el tipo de sangre del paciente: ");
            string fechaConsulta = ValidarFecha("Ingresa la fecha de consulta del paciente en el siguiente formato (dd/MM/AAAA): ");
            string motivoConsulta = ValidarString("Ingresa el motivo de la consulta: ");
            string celuar = ValidarTamanioNumero("Ingresa el número de celular del paciente: ");
            string curp = ValidarString("Ingresa el CURP del paciente: ");
            //Creación del paciente general con los datos ingresados desde consola
            pacienteGeneral = new Paciente(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, sexo, correo, tipoSangre, fechaConsulta, motivoConsulta, celuar, curp);
        }
        //Método que permite vaidar si el paciente es nulo
        private static bool validarPacienteNulo()
        {
            //Uso de la varaible bandera para verificar si hay información del cliente
            bool badera = false;
            //Sentencia if/else para verificar si hay información para el cliente,
            if (pacienteGeneral != null)
            {
                badera = true;
            }
            else
            {
                badera = false;
            }
            //Retorno de la bandera en función de lo que se obtuvo de la bandera
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
        //Método que reliza la validación del string sea solo string sin números 
        public static string ValidarSoloString(string mensaje)
        {
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas del string
            while (!salir)
            {
                Console.Write(mensaje);
                s = Console.ReadLine();
                //Sentencia if/else para verificar el string ingresado por el usuario
                if (!SoloLetras(s))
                {
                    //Sentencia donde solo se necesita letra sin número ni espacios
                    Console.WriteLine("Ingresa solo letras, sin espacios");
                }else if (string.IsNullOrEmpty(s))
                {
                    //Snetencia para el caso de que el string se encuentre vacio
                    Console.WriteLine("El string se encuentra vacío, vuelve a intentarlo");
                }
                else
                {
                    //En caso contrario se puede salir del programa
                    salir = true;
                }                
            }

            //Retorno del string que se ha ingresado
            return s;
        }
        //Métod que valida el string ingresado desde la consola
        public static string ValidarString(string mensaje)
        {
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas del string
            while (!salir)
            {
                //Uso de la sentencia try/catch para el caso de que no se haya ingresado de manera adecuada la información 
                try
                {
                    Console.Write(mensaje);
                    s = Console.ReadLine();
                    //Sentencia if/else para verificar si esta escrito sin espacios y vacios el string
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
                //Catch para el caso de que se cuente con un error
                catch (FormatException ex)
                {
                    Console.WriteLine("Error al ingresar el texto, vuelve a intentarlo");
                }
            }
            //Retorno de string obtenido desde la consola
            return s;
        }
        //Método que valida el tamaño del número telefonico hasta una longitud de 10 caracteres
        public static string ValidarTamanioNumero(string mensaje)
        {
            //Declaración de variables locales
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas del string para determinar un tamaño definido
            while (!salir)
            {
                try
                {
                    //Declaración de las varaibles internas
                    Console.Write(mensaje);
                    s = Console.ReadLine();
                    //Sentecia if/else para veirificar si el string ingresado sea igual a 10 digitos
                    if (s.Length == 10)
                    {
                        salir = true;
                    }
                    else
                    {
                        Console.WriteLine("El número tiene que ser de 10 digitos, intenta de nuevo");
                    }
                }
                //Excepción para el caso de que el string no sea ingresado de manera correcta
                catch (FormatException ex)
                {
                    Console.WriteLine("Error al ingresar el número, intenta de nuevo");
                }
            }
            return s;
        }
        //Método que valida la fecha ingresada desde un string
        public static string ValidarFecha(string mensaje)
        {
            //Declaración de las variables necesarias para esta sección de codigo
            DateTime fecha;
            bool salir = false;
            string s = null;
            //Ciclo while para verificar las caracteristicas de la fehca
            while (!salir)
            {
                //Sentencia try para el caso de que el string no sea agregao de manera correcta
                try
                {
                    Console.Write(mensaje);
                    s = Console.ReadLine();
                    //Sentencia if/else para veriicar si el string ingesado se puede parsear a un tipo DateTiem
                    if (!DateTime.TryParse(s,out fecha))
                    {
                        Console.WriteLine("La fecha no cuenta con el formato establecido, vuelve a intentarlo");
                    }
                    else
                    {
                        salir = true;
                    }
                }
                //Sentencia catch para el caso de que no se ingrese información adecuada
                catch (FormatException ex)
                {
                    Console.WriteLine("Error al ingresar la fecha, intenta de nuevo");
                }
            }
            //Retorno del string que se genero
            return s;
        }
        //Metodo que permite identificar si los caracteres son letras o no
        public static bool SoloLetras(string s)
        {
            //Recorrido del string con un foreach
            foreach (char ch in s)
            {
                //Verificación de si solo hay letras en el string
                if (!Char.IsLetter(ch) && ch != 32)
                {
                    return false;
                }
            }
            return true;
        }
        //Metodo que permite identificar si al inicio del string haya un espacio
        public static bool EspacioVacio(string s)
        {
            foreach (char ch in s)
            {
                //Verificación del codigo ASCII para el espacio vacio
                if (ch != 32)
                {
                    return false;
                }
            }
            return true;
        }

    }
    //Declaración de la clase Paciente con los atributos necesarios para su funcionamiento
    class Paciente
    {
        //Declaración de variables y métodos getter y setter del objeto Paciente
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        //public string FechaNacimiento { get; set; }
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
        private string FechaNacimiento;

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
        public void setFechaNacimiento(string fecha)
        {
            FechaNacimiento = fecha;
            //Reasignamiento de la edad del paciente
            Edad = CalcularEdad(fecha);
        }
        public string getFechaNacimietno()
        {
            return FechaNacimiento;
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
