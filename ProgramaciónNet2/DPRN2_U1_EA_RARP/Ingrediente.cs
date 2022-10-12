namespace UnidadUnoEA
{
    class Ingrediente
    {
        public string Nombre { get; set; }
        public TipoIngrediente Tipo { get; set; }
        public float MedidaRendimiento { get; set; }
        public float Calorias { get; set; }
        public float Precio { get; set; }

        public Ingrediente()
        {
        }
        public Ingrediente(string nombre, TipoIngrediente tipo, float medidaRendimiento, float calorias, float precio)
        {
            Nombre = nombre;
            Tipo = tipo;
            MedidaRendimiento = medidaRendimiento;
            Calorias = calorias;
            Precio = precio;
        }
        public string RevisarIngrediente(float peso)
        {
            string texto = $"El ingrediente {Nombre} tiene {Calorias} [kcal] y con un peso {peso} [kg] tiene un total de {Calorias*peso} [kcal]";
            return texto;
        }
        public string RevisarIngrediente()
        {
            string info = $"Nombre: {Nombre} \n" +
                $"Tipo: {Tipo.TipoInsumo} \n" +
                $"Medida rendimiento: {MedidaRendimiento}\n" +
                $"Calorias: {Calorias} \n" +
                $"Precio: {Precio}";
            return info;
        }
    }
}