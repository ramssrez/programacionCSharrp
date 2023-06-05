namespace UnidadTresEA
{
    class Program
    {
        //Declaración de la variable global de la aplicación
        Strings strings = new Strings();
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
                    //Caso para mostrar y modificar información de la lista de drones tipo Tricópteros
                    case 1:
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.OpcionMenu(opcion));
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                    //Caso para mostrar y modificar información de la lista de drones tipo Cuadricóptero
                    case 2:
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.OpcionMenu(opcion));
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                    //Caso para mostrar y modificar información de la lista de drones tipo Hexacóptero
                    case 3:
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.OpcionMenu(opcion));
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                    case 4:
                        //Caso para mostrar y modificar información de la lista de drones tipo Coaxial
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.OpcionMenu(opcion));
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                    case 5:
                        //Opción para la salida del programa
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.SALIR);
                        Console.WriteLine(Strings.STRING_FORMATO);
                        salir = true;
                        break;
                    //Opción en el caso de que el usuario no seleccione una opción del menú
                    default:
                        Console.WriteLine(Strings.STRING_FORMATO);
                        Console.WriteLine(Strings.RangoOpciones(1, 5));
                        Console.WriteLine(Strings.STRING_FORMATO);
                        break;
                }
            }
            /*
            UsuarioMetaverso usuario = new UsuarioMetaverso("Platino");
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();
            usuario.RealizarInteraccion();

            //EntidadMetaverso entidad = new EntidadMetaverso();
            Personaje personaje = new Personaje("Programador 1","Desarrollador de videojuegos dentro del metaverso nivel I",Strings.PERSONAJE,"Desarrollador videojuegos consola");
            Personaje personaje2 = new Personaje("Programador 2", "Desarrollador de videojuegos dentro del metaverso nivel II", Strings.PERSONAJE,"Desarrollador videojuegos móvil");
            Personaje personaje3 = new Personaje("Programador 3", "Desarrollador de videojuegos dentro del metaverso nivel III", Strings.PERSONAJE,"Desarrollador videojuegos de escritorio");
            
            Objeto objeto = new Objeto("Computadora","Computadora de ultima generación que contiene los programas necesarios para poder desarrollar videojuegos para consolas", Strings.OBJETO, "Electrónico");
            Objeto objeto1 = new Objeto("Escritorio", "Escritorio que sostiene todo el equipo necesario para poder desarrollar videojuegos", Strings.OBJETO,"Mueble");
            Objeto objeto2 = new Objeto("Mouse", "Mouse necesario para tener el control de la interfaz gráfica con el usuaro", Strings.OBJETO, "Electrónico");
            Objeto objeto3 = new Objeto("Silla", "Silla en donde el usuario puede sentarse y desarrollar los videojuegos con su respectiva computadora", Strings.OBJETO, "Mueble");
            Objeto objeto4 = new Objeto("Teclado", "Teclado para que el usuario pueda escribir en la computadora", Strings.OBJETO, "Electrónico");

            Lugar lugar = new Lugar("Oficina","Oficina de desarrollo de videojuegos", Strings.LUGAR,"CDMX");
            Lugar lugar2 = new Lugar("World Trade Center","Primer piso de la torre", Strings.LUGAR, "CDMX");
            Lugar lugar3 = new Lugar("Friki Plaza", "Tercer piso de la Friki Plaza", Strings.LUGAR, "CDMX");

            Evento evento = new Evento("Hackaton","Hackaton desarrollo de videojuegos",Strings.EVENTO,"20/06/2023",lugar2,"Hackaton para todo publico en general, que guste experimentar" +
                "la adredalina para poder desarrollar videojuegos en consola, ven con tu equipo para mostrar tus habilidades de desarrollo ya sea en equipo o dentro de " +
                "las instalaciones puedes crear tu propio equipo");

            Evento evento2 = new Evento("La Mole", "Comics, anime y videojuegos en un solo lugar", Strings.EVENTO,"24/06/2023", lugar3, "Visita el evento anual de comics, anime y videjuegos" +
                "en donde podras una gran cantidad de stands de diferentes temas que te pueden interesar, además de stads de actores de doblaje");

            List<EntidadMetaverso> entidadMeta = new List<EntidadMetaverso>() { personaje, personaje2, personaje3, objeto, objeto1, objeto2, objeto3, objeto4, lugar,lugar2,lugar3,evento, evento2 };

            for (int i = 0; i < entidadMeta.Count; i++)
            {
                Console.WriteLine($"{i}. {entidadMeta[i].Descripcion}");
            }
            */
        }
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
                    Console.WriteLine(Strings.ERROR_INGRESAR_NUMERO);
                }
                catch (OverflowException ex)
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