namespace UnidadTresA4
{
    class Inmuebles
    {
        public List<Inmueble> Mesas{ get; set; }
        public List<Inmueble> MesasDesayuno { get; set; }
        public List<Inmueble> MesasCena { get; set; }

        public List<Inmueble> Salas { get; set; }
        public Inmuebles()
        {
            MesasMañana();
            MesasNoche();
            Mesas = new List<Inmueble>();
            Salas = new List<Inmueble>();
            Inmueble mesa1 = new(1, "Mesa");
            Inmueble mesa2 = new(2, "Mesa");
            Inmueble mesa3 = new(3, "Mesa");
            Mesas.Add(mesa1);
            Mesas.Add(mesa2);
            Mesas.Add(mesa3);


            Inmueble sala1 = new Inmueble(1, "Sala");
            Inmueble sala2 = new Inmueble(2, "Sala");
            Inmueble sala3 = new Inmueble(3, "Sala");
            Salas.Add(sala1);
            Salas.Add(sala2);
            Salas.Add(sala3);
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
        public void MostrarMesasDisponibles()
        {
            foreach (Inmueble i in Mesas)
            {
                if (!i.IsOcupada)
                {
                    Console.WriteLine($"{i.Tipo} {i.ID}, {i.Espacios} espacios disponibles");
                }
                //Console.WriteLine($"Mesa {i.ID}, {i.Espacios} espacios disponibles");
            }
        }
        public bool MesasDisponibles()
        {
            bool bandera = true;
            foreach (Inmueble i in Mesas)
            {
                if (!i.IsOcupada)
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
            }
            return bandera;
        }
        public void MostrarInfoMesas()
        {
            foreach (Inmueble i in Mesas)
            {
                Console.WriteLine($"{i.MostrarInformacion()}");
            }
        }
        public void MostrarSalasDisponibles()
        {
            foreach (Inmueble i in Salas)
            {
                if (!i.IsOcupada)
                {
                    Console.WriteLine($"{i.Tipo} {i.ID}, {i.Espacios} espacios disponibles");
                }
            }
        }
        public bool SalasDisponibles()
        {
            bool bandera = true;
            foreach (Inmueble i in Salas)
            {
                if (!i.IsOcupada)
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
            }
            return bandera;
        }

            public void MostrarInfoSalas()
        {
            foreach (Inmueble i in Salas)
            {
                Console.WriteLine($"{i.MostrarInformacion()}");
            }
        }
    }
}