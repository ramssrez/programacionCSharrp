namespace UnidadTresEA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio del método que contiene el menú de principal.
            Presentacion();
        }

        private static void Presentacion()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            Ingrediente ing1 = new("Queso");
            Ingrediente ing2 = new("Jamón");
            Ingrediente ing3 = new("Tocino");
            Ingrediente ing4 = new("Piña");
            Ingrediente ing5 = new("Pierna");
            Ingrediente ing6 = new("Pollo");
            Ingrediente ing7 = new("Jalapeño");
            Ingrediente ing8 = new("Mayonesa");
            Ingrediente ing9 = new("Atún");
            Ingrediente ing10 = new("Champiñón");
            Ingrediente ing11 = new("Anchoas");
            Ingrediente ing12 = new("Mariscos");
            Ingrediente ing13 = new("Peperoni");
            ingredientes.Add(ing1);
            ingredientes.Add(ing2);
            ingredientes.Add(ing3);
            ingredientes.Add(ing4);
            ingredientes.Add(ing5);
            ingredientes.Add(ing6);
            ingredientes.Add(ing7);
            ingredientes.Add(ing8);
            ingredientes.Add(ing9);
            ingredientes.Add(ing10);
            ingredientes.Add(ing11);
            ingredientes.Add(ing12);
            ingredientes.Add(ing13);
            foreach (Ingrediente i in ingredientes)
            {
                i.MostrarInfo();
            }
            //throw new NotImplementedException();
        }
    }
}