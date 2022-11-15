namespace UnidadTresA4
{
    class Inmuebles
    {
        public List<Inmueble> Mesas{ get; set; }
        public List<Inmueble> MesasDesayuno { get; set; }
        public List<Inmueble> MesasComida { get; set; }
        public List<Inmueble> MesasCena { get; set; }

        public List<Inmueble> Salas { get; set; }
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
            int contador = 0;
            foreach (Inmueble i in Mesas)
            {
                if (!i.IsOcupada)
                {
                    contador++;
                }
            }
            if(contador == 0)
            {
                bandera = false;
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