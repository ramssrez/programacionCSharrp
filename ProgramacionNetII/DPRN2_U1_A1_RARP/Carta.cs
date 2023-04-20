namespace UnidadUnoA1;
//Declaración de la clase Carta con sus atributos necesarios
public class Carta
{
	//Declaración de las variables y métodos  getter y setter del objeto Carta
	public string NombreMonstruo { get; set; }
	public Atributo Atributo { get; set; }
	public Tipo TipoMonstruo { get; set; }
	public string Descripcion { get; set; }
	public int Nivel { get; set; }
	public int Ataque { get; set; }
	public int Defensa { get; set; }
	//Declaración del constructor vacio de la clase
	public Carta()
	{
	}
	//Declaración del constructor con parametros de entrada
	public Carta(string nombreMonstruo, Atributo atributo, Tipo tipo, string descripcion, int nivel, int ataque, int defensa)
	{
		NombreMonstruo = nombreMonstruo;
		Atributo = atributo;
		TipoMonstruo = tipo;
		Descripcion = descripcion;
		Nivel = nivel;
		Ataque = ataque;
		Defensa = defensa;
	}
	//Método que imprime el ataque del monstruo
	public string AtaqueMonstruo()
	{
		return $"El monstruo {NombreMonstruo} atacará con {Ataque} puntos";
	}
	//Método que imprime la defensa del monstruo
	public string DefensaMonstruo()
	{
		return $"El monstruo {NombreMonstruo} defenderá con {Defensa} puntos";
	}
	public string PosicionCarta(int valor)
    {
		//string s = valor == 1 ? "Ataque (ATK)" : "Defensa (DEF)";
		return $"El monstruo {NombreMonstruo} esta en posicion de {(valor == 1 ? "Ataque (ATK)" : "Defensa(DEF)")}";
    }
	//Método que imprime los atributos que componen al objeto
	public void AtributosConsole()
	{
		string efecto = TipoMonstruo.IsEfect ? "Si" : "No";
		Console.WriteLine($"Nombre del monstruo: {NombreMonstruo} \n" +
				$"Atributo: {Atributo.Name} \n" +
				$"Tipo: {TipoMonstruo.TipoName} \n" +
				$"¿Es un efecto?: {efecto} \n" +
				$"Nivel: {Nivel} estrella(s)\n" +
				$"Ataque: {Ataque} \n" +
				$"Defensa: {Defensa}\n" +
				$"Descripción: { Descripcion}");
	}
}
