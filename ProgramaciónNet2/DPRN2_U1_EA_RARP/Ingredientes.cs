namespace UnidadUnoEA
{
    //Declaración de la clase Ingredientes, la cual contiene la información de todos los ingredientes
    class Ingredientes
    {
        //Declaración de los atributos de la clase
        public List<Ingrediente> IngredientesTotales { private set; get; }
        //Declaración del constructor de la clase
        public Ingredientes()
        {
            IngredientesTotales = new List<Ingrediente>();
            IngredientesTotales.AddRange(IngredientesPan());
            IngredientesTotales.AddRange(IngredientesRelleno());
            IngredientesTotales.AddRange(IngredienteGlaseado());
            IngredientesTotales.AddRange(IngredienteDedicatoria());
            IngredientesTotales.AddRange(IngredienteFlan());
        }
        //Generación de la lista de ingredientes que tiene pan
        public List<Ingrediente> IngredientesPan()
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
        //Generación de la lista de ingredientes que tiene relleno
        public List<Ingrediente> IngredientesRelleno()
        {
            List<Ingrediente> ingredienteRelleno = new List<Ingrediente>();
            TipoIngrediente tipo2 = new TipoIngrediente(2, "Relleno");
            Ingrediente ingrediente1 = new("Dulce de leche", tipo2, 2, 200, 75);
            Ingrediente ingrediente2 = new("Mermelda", tipo2, 1, 150, 50);
            Ingrediente ingrediente3 = new("Chantilly", tipo2, 0.5f, 100, 25);
            ingredienteRelleno.Add(ingrediente1);
            ingredienteRelleno.Add(ingrediente2);
            ingredienteRelleno.Add(ingrediente3);
            return ingredienteRelleno;
        }
        //Generación de la lista de ingredientes que tiene glaseado
        public List<Ingrediente> IngredienteGlaseado()
        {
            List<Ingrediente> ingredienteGlaseado = new List<Ingrediente>();
            TipoIngrediente tipo3 = new TipoIngrediente(3, "Cubierta superior");
            Ingrediente ingrediente1 = new("Ganache de Chocolate", tipo3, 2, 175, 110);
            Ingrediente ingrediente2 = new("Glaseado de Azúcar Glass", tipo3, 1, 150, 95);
            Ingrediente ingrediente3 = new("Crema de Mantequilla", tipo3, 0.5f, 120, 75);
            ingredienteGlaseado.Add(ingrediente1);
            ingredienteGlaseado.Add(ingrediente2);
            ingredienteGlaseado.Add(ingrediente3);
            return ingredienteGlaseado;
        }
        //Generación de la lista de ingredientes que tiene dedicatoria
        public List<Ingrediente> IngredienteDedicatoria()
        {
            List<Ingrediente> ingredienteDedicatoria = new List<Ingrediente>();
            TipoIngrediente tipo4 = new TipoIngrediente(4, "Dedicatoria");
            Ingrediente ingrediente1 = new("Chocolate", tipo4, 2, 120, 50);
            Ingrediente ingrediente2 = new("Chantilly de Colores", tipo4, 1, 110, 40);
            Ingrediente ingrediente3 = new("Azúcar Glass", tipo4, 0.5f, 105, 30);
            ingredienteDedicatoria.Add(ingrediente1);
            ingredienteDedicatoria.Add(ingrediente2);
            ingredienteDedicatoria.Add(ingrediente3);
            return ingredienteDedicatoria;
        }
        //Generación de la lista de ingredientes que tiene flan
        public List<Ingrediente> IngredienteFlan()
        {
            List<Ingrediente> ingredienteFlan = new List<Ingrediente>();
            TipoIngrediente tipo5 = new TipoIngrediente(5, "Flan");
            Ingrediente ingrediente1 = new("Flan Napolitano", tipo5, 2, 200,100);
            Ingrediente ingrediente2 = new("Flan de Dulce de Leche", tipo5, 1, 210, 110);
            Ingrediente ingrediente3 = new("Flan de Leche condensada", tipo5, 0.5f, 220, 120);
            ingredienteFlan.Add(ingrediente1);
            ingredienteFlan.Add(ingrediente2);
            ingredienteFlan.Add(ingrediente3);
            return ingredienteFlan;
        }
    }
}