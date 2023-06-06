namespace UnidadTresEA
{
    class Program
    {
        //Declaración de la variable global de la aplicación
        public static EntidadesMetaverso entidadesMeta = new ();
        public static UsuarioMetaverso usuario = new("Gratuita");
        //Comienzo de la función principal en C#
        static void Main(string[] args)
        {
            //Inicio del método que contiene el menú de principal.
            Presentacion();
        }
        //Método que muesta el menú de opciones para el caso de estudio
        public static void Presentacion()
        {
            // Mensaje de presentación del programa
            Console.WriteLine(Strings.STRING_FORMATO);

            //Variable para salir del ciclo.
            bool salir = false;
            //Inicio del comienzo de ciclo para mostrar las diferentes opciones del menú
            while (!salir)
            {
                //Impresión de los diferentes opciones
                Console.WriteLine(Strings.BIENVENIDO);
                Console.WriteLine(Strings.OPCIONES_MENU);
                int opcion = ValidarNumero(Strings.OPCION_MENU);
                //Uso del switch para seleccion de las opciones ingresadas desde la consola
                switch (opcion)
                {
                    //Caso para mostrar las entidades que sean un personaje
                    case 1:
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.OpcionMenu(opcion));
                        ImprimirOpciones(entidadesMeta.Entidades, Strings.PERSONAJE);
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                    //Caso para mostrar las entidades que sean un objeto
                    case 2:
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.OpcionMenu(opcion));
                        ImprimirOpciones(entidadesMeta.Entidades, Strings.OBJETO);
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                    //Caso para mostrar las entidades que sean un lugar
                    case 3:
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.OpcionMenu(opcion));
                        ImprimirOpciones(entidadesMeta.Entidades, Strings.LUGAR);

                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                    case 4:
                        //Caso para mostrar las entidades que sean un evento
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.OpcionMenu(opcion));
                        ImprimirOpciones(entidadesMeta.Entidades, Strings.EVENTO);
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                    case 5:
                        //Caso para mostrar toda la información de las entidades
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.OpcionMenu(opcion));
                        MostrarInformacion(entidadesMeta.Entidades);
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                    case 6:
                        //Opción para la salida del programa
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.SALIR);
                        Console.WriteLine(Strings.STRING_FORMATO);
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción del menú
                    default:
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.RangoOpciones(1, 6));
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                }
            }
        }
        //Método que imprime la información de las entidades del metaverso
        private static void MostrarInformacion(List<EntidadMetaverso>? entidades)
        {
            foreach (EntidadMetaverso em in entidades)
            {
                Console.WriteLine(em.DatosEntidad());
                Console.WriteLine(Strings.STRING_FORMATO);
            }
        }
        //Método que imprime las opciones y realiza el conteo de las entidades con las que interactua el usuario
        private static void ImprimirOpciones(List<EntidadMetaverso>? entidades, string s)
        {
            for (int i = 0; i < entidades?.Count; i++)
            {
                if (entidades[i].TipoObjeto.Equals(s))
                {
                    Console.WriteLine($"{entidades[i].ID}. {entidades[i].Nombre}");
                }
            }
            int opcion = ValidarNumero(Strings.OPCION_ENTIDAD);
            //Opción de la lista para poder visualizar si existe un elemento de la lista con las necesidades requeridas
            EntidadMetaverso? ent = entidades?.Find(
                delegate (EntidadMetaverso enti)
                {
                    return enti.ID == opcion && enti.TipoObjeto.Equals(s);
                });
            //Sentencia para el caso de que se ha encontraso una entidad en la lista
            if (ent != null)
            {
                usuario.RealizarInteraccion();
                if (usuario.PuedeInteractuar)
                {
                    Console.WriteLine(ent.Interactuar()); 
                }
            }
            else
            {
                Console.WriteLine(Strings.NoInteraccion(s));
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
                    salir = true;
                }
                catch (FormatException)
                {
                    //Mensaje de error en caso de que no se haya ingresado un entero
                    Console.WriteLine(Strings.ERROR_INGRESAR_NUMERO);
                }
                catch (OverflowException)
                {
                    //Mensaje de error en caso de que se haya ingresado un número muy grande
                    Console.WriteLine(Strings.ERROR_NUMERO_GRANDE);
                }
            }
            //Retorno del valor ingresado
            return valor;
        }
    }
}