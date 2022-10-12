namespace UnidadUnoEA
{
    class Ingredientes
    {
        public List<Ingrediente> IngredientesTotales { private set; get; }
        public Ingredientes()
        {
            IngredientesTotales = new List<Ingrediente>();
            IngredientesTotales.AddRange(IngredientesPan());
        }
        public void IniciarTipos()
        {
            TipoIngrediente tipo2 = new TipoIngrediente(2, "Relleno");
            TipoIngrediente tipo3 = new TipoIngrediente(3, "Cubierta superior");
            TipoIngrediente tipo4 = new TipoIngrediente(4, "Dedicatoria");
            TipoIngrediente tipo5 = new TipoIngrediente(5, "Flan");
        }
        private List<Ingrediente> IngredientesPan()
        {
            TipoIngrediente tipo1 = new TipoIngrediente(1, "Pan");
            List<Ingrediente> ingredientePan = new List<Ingrediente>();
            Ingrediente ingrediente1 = new("Biscocho de Chocolate", tipo1, 2.0f, 300, 150);
            Ingrediente ingrediente2 = new("Biscocho de Vainilla",tipo1,1.0f,250,125);
            Ingrediente ingrediente3 = new("Hojaldra", tipo1, 0.5f, 200, 100);
            ingredientePan.Add(ingrediente1);
            ingredientePan.Add(ingrediente2);
            ingredientePan.Add(ingrediente3);
            return ingredientePan;
        }
        private List<Ingrediente> IngredientesRelleno()
        {
            List<Ingrediente> ingredienteRelleno = new List<Ingrediente>();
            TipoIngrediente tipo2 = new TipoIngrediente(2, "Relleno");
            Ingrediente ingrediente1 = new("Biscocho de Chocolate", tipo2, 2, 300, 150);
            Ingrediente ingrediente2 = new("Biscocho de Vainilla", tipo2, 1, 250, 125);
            Ingrediente ingrediente3 = new("Hojaldra", tipo2, 0.5f, 200, 100);
            return ingredienteRelleno;
        }
    }
}