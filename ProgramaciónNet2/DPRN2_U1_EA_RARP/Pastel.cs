namespace UnidadUnoEA
{
    //Declaración de la clase Pastel
    class Pastel
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public List<Ingrediente> Ingredientes { get; set; }
        public float Peso { get; set; }
        public Tamanio Rendimiento { get; set; }
        public float Costo { get; set; }
        //Declaración del constructor vacio de la clase
        public Pastel()
        {
            Ingredientes = new List<Ingrediente>();
        }
        //Método que calcula el costo del pastel
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
        //Método que calcula las calorias del pastel
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
        //Método que calcula el peso del pastel
        public float PesoPastel()
        {
            return RendimientoPastel()*2;
        }
        //Método que caldula el rendimiento del pastel
        public float RendimientoPastel()
        {
            float suma = 0.0f;
            foreach (Ingrediente p in Ingredientes)
            {
                suma = suma + p.MedidaRendimiento;
            }
            return suma;
        }
        //Método que asigna a los atributos desde los metodos que se calcularon
        public void AsignarValores()
        {
            Peso = PesoPastel();
            Costo = CostoPastel();
        }
        //Método que imprime la información del pastel con sus atributos
        public void Informacion()
        {
            AsignarValores();
            Console.WriteLine("Los datos del pastel generado son los siguientes");
            Console.WriteLine($"Calorias: {CaloriasPastel()} \n" +
                $"Costo del pastel: ${Costo} \n" +
                $"Rendimiento pastel: {RendimientoPastel()} \n" +
                $"Peso del pastel: {Peso}[kg] \n" +
                $"Tamaño: {Rendimiento.Name} \n" +
                $"Total de rebanadas: {Rendimiento.Rebanadas} \n");
            Console.WriteLine("Ingredientes del pastel: ");
            for (int i = 0; i < Ingredientes.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Ingredientes[i].Nombre}");
            }
        }
    }
}