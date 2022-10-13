namespace UnidadUnoEA
{
    class Pastel
    {
        public int Id { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public float Peso { get; set; }
        public Tamanio Rendimiento { get; set; }
        public float Costo { get; set; }
        public Pastel()
        {
            Ingredientes = new List<Ingrediente>();
        }
        public float CostoPastel()
        {
            float suma = 0.0f;
            foreach (Ingrediente p in Ingredientes)
            {
                suma = suma + p.Precio;
            }
            return suma;
            //Console.WriteLine($"costo: {suma}");
        }
        public float CaloriasPastel()
        {
            float suma = 0.0f;
            foreach (Ingrediente p in Ingredientes)
            {
                suma = suma + p.Calorias;
            }
            return suma;
            //Console.WriteLine($"calorias: {suma}");
        }

        public float PesoPastel()
        {
            return RendimientoPastel()*2;
        }
        public float RendimientoPastel()
        {
            float suma = 0.0f;
            foreach (Ingrediente p in Ingredientes)
            {
                suma = suma + p.MedidaRendimiento;
            }
            return suma;
        }
        public void AsignarValores()
        {
            Peso = PesoPastel();
            Costo = CostoPastel();
        }
        public void Informacion()
        {
            AsignarValores();
            Console.WriteLine("Los datos del pastel generado son los siguientes");
            Console.WriteLine($"Calorias: {CaloriasPastel()} \n" +
                $"Costo del pastel: ${Costo} \n" +
                $"Rendimiento pastel: {RendimientoPastel()} \n" +
                $"Peso del pastel {Peso}[kg] \n" +
                $"Tamaño: {Rendimiento.Name} \n" +
                $"Total de rebanadas {Rendimiento.Rebanadas} \n");
            Console.WriteLine("Ingredientes: ");
            for (int i = 0; i < Ingredientes.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Ingredientes[i].Nombre}");
            }
        }
    }
}