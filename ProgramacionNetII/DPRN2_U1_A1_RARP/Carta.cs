namespace UnidadUnoA1;
public class Carta
{
	public string NombreMonstruo { get; set; }
	public Atributo Atributo { get; set; }
	public Tipo TipoMonstruo { get; set; }
	public string Descripcion { get; set; }
	public int Nivel { get; set; }
	public int Ataque { get; set; }
	public int Defensa { get; set; }

	public Carta()
	{
	}
	public Carta(string nombreMonstruo, Atributo atributo,Tipo tipo, string descripcion, int nivel, int ataque, int defensa)
    {
		NombreMonstruo = nombreMonstruo;
		Atributo = atributo;
		TipoMonstruo = tipo;
		Descripcion = descripcion;
		Nivel = nivel;
		Ataque = ataque;
		Defensa = defensa;
    }
	public void AtributosConsole()
	{
		string efecto = TipoMonstruo.IsEfect ? "Si" : "No";
		Console.WriteLine($"Nombre del monstruo: {NombreMonstruo} \n" +
				$"Atributo: {Atributo.Name} \n" +
				$"Tipo: {TipoMonstruo.TipoName} \n" +
				$"¿Es un efecto?: {efecto} \n" +
				$"Descripción: {Descripcion} \n" +
				$"Nivel: {Nivel} estrellas\n" +
				$"Ataque: {Ataque} \n" +
				$"Defensa: {Defensa}");
	}
}
