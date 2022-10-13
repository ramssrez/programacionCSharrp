namespace UnidadUnoEA
{
    //Declaración de la clase Ingrediente
    class Ingrediente
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public string Nombre { get; set; }
        public TipoIngrediente Tipo { get; set; }
        public float MedidaRendimiento { get; set; }
        public float Calorias { get; set; }
        public float Precio { get; set; }
        //Declaración del constructor vacio de la clase
        public Ingrediente()
        {
        }
        //Declaración de constructor con atributos
        public Ingrediente(string nombre, TipoIngrediente tipo, float medidaRendimiento, float calorias, float precio)
        {
            Nombre = nombre;
            Tipo = tipo;
            MedidaRendimiento = medidaRendimiento;
            Calorias = calorias;
            Precio = precio;
        }
        //Método que calcula las calorias del ingredientes en función del peso
        public string RevisarIngrediente(float peso)
        {
            string texto = $"El ingrediente {Nombre} tiene {Calorias} [kcal] y con un peso {peso} [kg] tiene un total de {Calorias*peso} [kcal]";
            return texto;
        }
        //Método que muestra la información del ingrediente
        public string RevisarIngrediente()
        {
            string info = $"Nombre: {Nombre} \n" +
                $"Tipo: {Tipo.TipoInsumo} \n" +
                $"Medida rendimiento: {MedidaRendimiento}\n" +
                $"Calorias: {Calorias} \n" +
                $"Precio: ${Precio}";
            return info;
        }
    }
}