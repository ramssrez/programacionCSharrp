namespace UnidadDosA1
{
    class Program
    {
        public static CuentasBancarias cuentas = new CuentasBancarias();
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            Presentacion();
        }

        public static void Presentacion()
        {
            //Mensaje de presentación del programa
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Bienvenidos al sistema de cuentas del banco");
            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine("1. Mostrar información de las cuentas bancarias.");
                Console.WriteLine("2. Mostrar las el saldo de las cuentas corrientes depues de comisión");
                Console.WriteLine("3. Mostrar las el saldo de las cuentas de ahorro despues de ganacias");
                Console.WriteLine("4. Mostrar las cuentas bancarias cerradas y motivo");
                Console.WriteLine("5. Salir");
                int opcion = ValidarNumero("Ingresa una opción del menú: ");
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para poder visualizar la informaicón de las cuentas
                    case 1:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 1");
                        InfoCuentas();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar el saldo despues de comisión de las cuentas corrientes
                    case 2:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 2");
                        CuentasCorrientes();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para poder visualizar el saldo con las ganancias de las cuentas de ahorros
                    case 3:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 3");
                        CuentasAhorros();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    //Caso para mostrar las cuentas que han sido cerradas
                    case 4:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Has elegido la opción 4");
                        CuentasCerradas();
                        Console.WriteLine("**********************************************************************************************");
                        break;
                    case 5:
                        //Opción para la salida del programa
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("**********************************************************************************************");
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción
                    default:
                        Console.WriteLine("**********************************************************************************************");
                        Console.WriteLine("Elige una opcion entre 1 y 5");
                        Console.WriteLine("**********************************************************************************************");
                        break;
                }
            }
        }
        //Método que selecciona tres cuentas y asigna en motivo por el cual ha sido cerrada
        private static void CuentasCerradas()
        {
            CuentaBancaria cuenta = cuentas.CuentaCorrientes[1];
            CuentaBancaria cuentaUno = cuentas.CuentaCorrientes[0];
            CuentaBancaria cuentaDos = cuentas.CuentaAhorros[2];

            Console.WriteLine($"Cuenta número: {cuenta.Numero}, motivo de cerrar: {cuenta.CerrarCuenta(1)}");
            Console.WriteLine($"Cuenta número: {cuentaUno.Numero}, motivo de cerrar: {cuentaUno.CerrarCuenta(2)}");
            Console.WriteLine($"Cuenta número: {cuentaDos.Numero}, motivo de cerrar: {cuentaDos.CerrarCuenta(3)}");

        }
        //Método que muesta la información del saldo ya con los beneficios obtenidos
        private static void CuentasAhorros()
        {
            foreach (CuentaAhorro cuenta in cuentas.CuentaAhorros)
            {
                Console.WriteLine($"Cuenta número: {cuenta.Numero}, saldo: ${cuenta.Beneficios()}");
                Console.WriteLine("**********************************************************************************************");
            }
        }
        //Método que muesta la información del saldo de las cuentas ya con la comisión
        private static void CuentasCorrientes()
        {
            foreach (CuentaCorriente cuenta in cuentas.CuentaCorrientes)
            {
                Console.WriteLine($"Cuenta número: {cuenta.Numero}, saldo: ${cuenta.Comision()}");
                Console.WriteLine("**********************************************************************************************");
            }
        }
        //Método que muesta la informaición de todas las cuentas
        private static void InfoCuentas()
        {
            Console.WriteLine("**********************************************************************************************");
            foreach(CuentaCorriente cuenta in cuentas.CuentaCorrientes)
            {
                Console.WriteLine(cuenta.MostrarInformacion());
                Console.WriteLine("**********************************************************************************************");
            }
            foreach (CuentaAhorro cuenta in cuentas.CuentaAhorros)
            {
                Console.WriteLine(cuenta.MostrarInformacion());
                Console.WriteLine("**********************************************************************************************");
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
    }
}