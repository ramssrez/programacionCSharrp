namespace UnidadUnoEA
{
    public class Personajes
    {
        public List<Personaje> PersonajesList { get; set; }

        public Personajes()
        {
            PersonajesList = new List<Personaje> { WoderWoman(),Lobo(),ReverseFlash(),CatWoman()};
        }
        public List<Personaje> PersonajesDC()
        {
            return PersonajesList;
        }
        public Personaje  WoderWoman()
        {
            Personaje wonderWoman = new Personaje();
            wonderWoman.NombreComercial = "Wonder Woman";
            wonderWoman.NombreReal = "Princesa Diana de Temiscira";
            wonderWoman.PrimeraAparicionHistorica = "All Start Comic V1 #8, Dic 1941 / Ene. 1942";
            wonderWoman.PrimeraAparicion = "Wonder Woman V4 #1, Sep. 2011";
            wonderWoman.Descripcion = "Nacida como hija de Hipólita y de Zeus, Diana se convierte en la princesa de las amazonas en Isla Paraíso. \n" +
                "Siguiendo la tradición de las amazonas, Diana es entrenada duramente para el combate, entre los 11 y 12 años es entrenadas personalmente es por Ares, el dios de la guerra. \n" +
                "Abandona isla Paraíso como embajadora de las amazonas en el mundo y entra a formar parte de la Liga de la Justicia. \n" +
                "Tras combatir al primogénito de Zeus y Hera, se convierte en la nueva diosa de la guerra.";
            Creador creador1 = new Creador("William Moulton", 1, "Marton");
            Creador creador2 = new Creador("Harry G.", 2, "Peter");
            Poder poder = new Poder(1, "Vuelo");
            Poder poder1 = new Poder(2, "Super fuerza");
            Poder poder2 = new Poder(3, "Inmortalidad");
            Poder poder3 = new Poder(4, "Super velocidad");
            Poder poder4 = new Poder(5, "Brazaletes indestructibles");
            Poder poder5 = new Poder(6, "Lazo mágico de la verdad");

            List<Poder> poderes = new List<Poder> { poder, poder1, poder2, poder3, poder4, poder5 };
            wonderWoman.Poderes = poderes;
            List<Creador> creadores = new List<Creador> { creador1, creador2 };
            wonderWoman.Creadores = creadores;
            wonderWoman.EsHumano = false;
            return wonderWoman;
        }
        public Personaje Lobo()
        {
            Personaje lobo = new Personaje();
            lobo.NombreComercial = "Lobo";
            lobo.NombreReal = "Desconocido";
            lobo.PrimeraAparicionHistorica = "Omega men V1 #3, junio 1983";
            lobo.PrimeraAparicion = "Justice League V2 #23.2; Lobo Sep. 2013";
            lobo.Descripcion = "Mano derecha del rey de Czarnia, amante de la princesa y general del ejército, de él depende la pasa en su planeta. \n" +
                "Cuando el rey enloquece y los rebeldes se alzan, mata a su rey y, con el, al planeta entero. \n" +
                "Trabaja como reconocido cazarrecompensas hasta que aparece un impostor que le roba el nombre y el honor, lo persigue hasta que da con él y, matándolo, queda solo Lobo en el universo. \n" +
                "Realizando un trabajo que tiene como fin proteger la tierra, se enterade la verdad sobre el envenenamiento de su planeta, lo que le lleva a buscar al culpable por toda la galaxia, aunque tenga que luchas con el siniestro corps.";
            Creador creador1 = new Creador("Bob", 1, "Kane");
            Creador creador2 = new Creador("Bill", 2, "Finger");
            Poder poder = new Poder(1, "Agilidad");
            Poder poder1 = new Poder(2, "Sigilio");
            Poder poder2 = new Poder(3, "Siete vidas");

            List<Poder> poderes = new() { poder, poder1, poder2 };
            lobo.Poderes = poderes;
            List<Creador> creadores = new() { creador1, creador2 };
            lobo.Creadores = creadores;
            lobo.EsHumano = false;
            return lobo;
        }
        public Personaje ReverseFlash()
        {
            Personaje reverseFlash = new Personaje();
            reverseFlash.NombreComercial = "Reverse Flash";
            reverseFlash.NombreReal = "Daniel West";
            reverseFlash.PrimeraAparicionHistorica = "Sin datos";
            reverseFlash.PrimeraAparicion = "FlashV4 #0, Sept. 2012";
            reverseFlash.Descripcion = "Daniel West cometió un error justo cuando Flash apareció por primera vez en Central City después de pagar su deuda, se vio envuelto en la revuelta liderada por Grood, tras ser “Salvado” por los rogues y el mundo espejo de mirror master, decidió que no iba a aceptar que los villanos le dirigieran así que estrelló un coche contra un tanque que contenía Speed Force. \n" +
                "En la explosión adquirió contacto directo con la Speed force, permitiéndole moverse a gran velocidad y crear un traje con los restos de la explosión, además puede “robar” los vestigios de Speed force de otro matándolos, método que utiliza para poder moverse en el tiempo e intentar cambiar el pasado.";
            Creador creador1 = new Creador("Brian", 1, "Buccellato");
            Creador creador2 = new Creador("Francis", 2, "Manapul");
            Poder poder = new Poder(1, "Conexión con la Speed Force");
            Poder poder1 = new Poder(2, "Super velocidad");
            Poder poder2 = new Poder(3, "Capacidad de viaje temporal");
            Poder poder3 = new Poder(4, "Capacidad de absorber energía residual de la Speed Force");
            List<Poder> poderes = new() { poder, poder1, poder2, poder3 };
            reverseFlash.Poderes = poderes;
            List<Creador> creadores = new() { creador1, creador2 };
            reverseFlash.Creadores = creadores;
            reverseFlash.EsHumano = true;
            return reverseFlash;
        }
        public Personaje CatWoman()
        {
            Personaje catWoman = new Personaje();
            catWoman.NombreComercial = "Catwoman";
            catWoman.NombreReal = "Selina Kyle";
            catWoman.PrimeraAparicionHistorica = "Batman V1 #1, verano 1940";
            catWoman.PrimeraAparicion = "Catwoman V4 #1, Sept. 2011";
            catWoman.Descripcion = "Huérfana y separada de su hermano, en el grupo hogar la obligan a robar para “pagar” su estancia.\n" +
                "En medio de un robo, le es ofrecida una “segunda oportunidad”. Tras investigar en su pasado, se “asesinada” y su carrera como ladrona profesional empieza con una menos de sus “siete vidas”.\n" +
                "Topa con Batman, pero recibe de las oportunidades de hacer lo correcto, mientras, sigue consiguiendo cosas para quien las pague.\n" +
                "Se une a la liga de la justicia de américa, pero, tras la irrupci´0n del sindicato, descubre a su padre y reorganiza su vida decidiendo de “la gata” debe desaparecer ¿Realmente lo hará";
            Creador creador1 = new Creador("Brian", 1, "Buccellato");
            Creador creador2 = new Creador("Francis", 2, "Manapul");
            Poder poder = new Poder(1, "Conexión con la Speed Force");
            Poder poder1 = new Poder(2, "Super velocidad");
            Poder poder2 = new Poder(3, "Capacidad de viaje temporal");
            Poder poder3 = new Poder(4, "Capacidad de absorber energía residual de la Speed Force");
            List<Poder> poderes = new() { poder, poder1, poder2, poder3 };
            catWoman.Poderes = poderes;
            List<Creador> creadores = new() { creador1, creador2 };
            catWoman.Creadores = creadores;
            catWoman.EsHumano = true;
            return catWoman;
        }
    }
}