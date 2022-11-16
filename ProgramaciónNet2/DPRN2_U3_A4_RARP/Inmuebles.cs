namespace UnidadTresA4
{
    class Inmuebles
    {
        public List<Inmueble> MesasDesayuno { get; set; }
        public List<Inmueble> MesasComida { get; set; }
        public List<Inmueble> MesasCena { get; set; }
        public List<Inmueble> SalasDesayuno { get; set; }
        public List<Inmueble> SalasComida { get; set; }
        public List<Inmueble> SalasCena { get; set; }
        public Inmuebles()
        {
            MesasMañana();
            MesasNoche();
            MesasTarde();
        }
        public void MesasMañana()
        {
            MesasDesayuno = new List<Inmueble>();
            Inmueble mesa1 = new(1, "Mesa");
            Inmueble mesa2 = new(2, "Mesa");
            Inmueble mesa3 = new(3, "Mesa");
            MesasDesayuno.Add(mesa1);
            MesasDesayuno.Add(mesa2);
            MesasDesayuno.Add(mesa3);
        }
        public void SalasMañana()
        {
            SalasDesayuno = new List<Inmueble>();
            Inmueble sala1 = new(1, "Sala");
            Inmueble sala2 = new(2, "Sala");
            Inmueble sala3 = new(3, "Sala");
            SalasDesayuno.Add(sala1);
            SalasDesayuno.Add(sala2);
            SalasDesayuno.Add(sala3);
        }
        public void MesasTarde()
        {
            MesasComida = new List<Inmueble>();
            Inmueble mesa1 = new(1, "Mesa");
            Inmueble mesa2 = new(2, "Mesa");
            Inmueble mesa3 = new(3, "Mesa");
            MesasComida.Add(mesa1);
            MesasComida.Add(mesa2);
            MesasComida.Add(mesa3);
        }
        public void SalasTarde()
        {
            SalasComida = new List<Inmueble>();
            Inmueble sala1 = new(1, "Sala");
            Inmueble sala2 = new(2, "Sala");
            Inmueble sala3 = new(3, "Sala");
            SalasComida.Add(sala1);
            SalasComida.Add(sala2);
            SalasComida.Add(sala3);
        }
        public void MesasNoche()
        {
            MesasCena = new List<Inmueble>();
            Inmueble mesa1 = new(1, "Mesa");
            Inmueble mesa2 = new(2, "Mesa");
            Inmueble mesa3 = new(3, "Mesa");
            MesasCena.Add(mesa1);
            MesasCena.Add(mesa2);
            MesasCena.Add(mesa3);
        }
        public void SalasNoche()
        {
            SalasCena = new List<Inmueble>();
            Inmueble sala1 = new(1, "Sala");
            Inmueble sala2 = new(2, "Sala");
            Inmueble sala3 = new(3, "Sala");
            SalasCena.Add(sala1);
            SalasCena.Add(sala2);
            SalasCena.Add(sala3);
        }
    }
}