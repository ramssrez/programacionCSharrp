namespace UnidadUnoA1
{
    //Declaración de la clase Cartas con sus atributos necesarios
    public class Cartas
    {
        //Declaración de las variables y métodos  getter y setter del objeto Cartas
        public List<Carta> CartasList { get; set; }
        //Declaración del constructor vacio de la clase, donde se inicializa cada uno de las cartas
        public Cartas()
        {
            CartasList = new List<Carta> { MagoObscuro(),FloresRojasBajorraiz(),DragonBlanco(),Maxx(),Mahad()};
        }
        //Método que devuelve un tipo Carta con los datos del monstruo Mago Obscuro
        private static Carta MagoObscuro()
        {
            return new Carta("Mago obscuro", new Atributo(1, "Oscuridad"), new Tipo(1, "Lanzador de Conjuros", false),
                "Es más grande de los magos en relación con el ataque y la defensa", 7, 2500, 2100);
        }
        //Método que devuelve un tipo Carta con los datos del monstruo Flores Rojas del Bajorraíz
        private static Carta FloresRojasBajorraiz()
        {
            return new Carta("Flores Rojas del Bajorraíz", new Atributo(1, "Oscuridad"),new Tipo(2,"Demonio",true),
                "Si esta carta está en tu mano: puedes seleccionar 1 Magia/Trampa en cada Cementerio; destiérralas  y," +
                " si lo haces, invoca esta carta de Modo Especial, Puedes Sacrificar esta carta y después seleccionar " +
                "1 monstruo de Fusión, Sincronía Xyz o Enlace en cualquier Cementerio; destierra este objeto y, si lo haces, " +
                "invoca de modo Especial 1 monstruo desde tu Cementerio con un tipo de carta de monstruo diferente al de ese objeto " +
                "(fusión, sincronía, Xyz o Enlace). Solo puedes usar cada efecto de “Flores Rojas de Bajorraíz una vez por turno."
                , 1,0,0);
        }
        //Método que devuelve un tipo Carta con los datos del monstruo Dragón Blanco de Ojos Azules
        private static Carta DragonBlanco()
        {
            return new Carta("Dragón Blanco de Ojos Azules", new Atributo(2, "Luz"), new Tipo(3, "Dragón", false),
                "Este legendario dragón es una poderosa máquina de destrucción. Virtualmente invencible, muy pocos se han " +
                "enfrentado a esta impresionante criatura y han vivido para contarlo.",8,3000,2500);
        }
        //Método que devuelve un tipo Carta con los datos del monstruo C Maxx
        private static Carta Maxx()
        {
            return new Carta("C Maxx",new Atributo(3,"Tierra"),new Tipo(4,"Insecto",true), "Durante el turno de cualquier jugador: " +
                "puedes mandar al cementerio esta carta en tu mano; este turno, cada vez que tu adversario Invoca de Modo Especial" +
                " uno o más monstruos, roba inmediatamente 1 carta. Sólo puedes usar 1 C Maxx por turno.", 2,500,200);
        }
        //Método que devuelve un tipo Carta con los datos del monstruo Mahar el Oráculo Paladio
        private static Carta Mahad()
        {
            return new Carta("Mahar el Oráculo Paladio",new Atributo(2,"Luz"),new Tipo(), "Cuando robas esta carta: puedes mostrar esta carta: " +
                "Invócala de Mo Especial desde tu mano. Si esta carta batalla con un monstruo OSCURIDAD, su ATK se duplica sólo durante el Damage Step. " +
                "Si esta carta es destruida en batalla o por el efecto de una carta: puedes Invocar de Modo Especial, desde tu mano, Deck o Cementerio, " +
                "1 Mago Obscuro.", 7,2500,2100);
        }
    }
}