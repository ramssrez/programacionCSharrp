namespace UnidadDosA1
{
    public class Drones
    {
        public List<Tricoptero> TricopteroList { get; set; }
        public List<Cuadricoptero> CuadricopteroList { get; set; }
        public List<Hexacoptero> HexacopteroList { get; set; }
        public List<Coaxial> CoaxialList { get; set; }
        public Drones()
        {
            TricopteroList = Tricopteros();
            CuadricopteroList = Cuadricopteros();
            HexacopteroList = Hexacopteros();
            CoaxialList = Coaxiales();
        }

        private List<Coaxial> Coaxiales()
        {
            return new List<Coaxial>
            {
                new Coaxial(StringProyect.COAXIAL, 14.5, 4, 1.2, "12", 15, new Dimension(30, 30, 15)),
                new Coaxial(StringProyect.COAXIAL, 14.5, 4, 1.2, "12", 15, new Dimension(30, 30, 15)),
                new Coaxial(StringProyect.COAXIAL, 14.5, 4, 1.2, "12", 15, new Dimension(30, 30, 15)),
                new Coaxial(StringProyect.COAXIAL, 14.5, 4, 1.2, "12", 15, new Dimension(30, 30, 15))
            };
        }

        private List<Hexacoptero> Hexacopteros()
        {
            return new List<Hexacoptero>
            {
                new Hexacoptero(StringProyect.HEXACOPTERO, 14,  6, 1.2, "12", 15, new Dimension(22, 20, 3)),
                new Hexacoptero(StringProyect.HEXACOPTERO, 14,  6, 1.2, "12", 15, new Dimension(22, 20, 3)),
                new Hexacoptero(StringProyect.HEXACOPTERO, 14,  6, 1.2, "12", 15, new Dimension(22, 20, 3)),
                new Hexacoptero(StringProyect.HEXACOPTERO, 14,  6, 1.2, "12", 15, new Dimension(22, 20, 3))
            };
        }
        private List<Tricoptero> Tricopteros()
        {
            return new List<Tricoptero> { 
                new Tricoptero(StringProyect.TRICOPTERO, 20, 3, 1.2, "12", 15, new Dimension(15, 12, 5)),
                new Tricoptero(StringProyect.TRICOPTERO,20, 3, 1.2, "12", 15, new Dimension(15, 12, 5)), 
                new Tricoptero(StringProyect.TRICOPTERO,20, 3, 1.2, "12", 15, new Dimension(15, 12, 5)), 
                new Tricoptero(StringProyect.TRICOPTERO,20, 3, 1.2, "12", 15, new Dimension(15, 12, 5)) 
            };
        }
        private List<Cuadricoptero> Cuadricopteros()
        {
            return new List<Cuadricoptero>
            {
                new Cuadricoptero(StringProyect.CUADRICOPTERO, 1.3, 4, 1.2, "12", 15, new Dimension(20, 18, 8)),
                new Cuadricoptero(StringProyect.CUADRICOPTERO, 1.3, 4, 1.2, "12", 15, new Dimension(20, 18, 8)),
                new Cuadricoptero(StringProyect.CUADRICOPTERO, 1.3, 4, 1.2, "12", 15, new Dimension(20, 18, 8)),
                new Cuadricoptero(StringProyect.CUADRICOPTERO, 1.3, 4, 1.2, "12", 15, new Dimension(20, 18, 8))
            };
        }
       
    }
}