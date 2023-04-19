namespace UnidadUnoA1;
public class Carta
{
	public string NombreMonstruo { get; set; }
	public Atributo Atributo { get; set; }
	public Tipo TipoMonstruo { get; set; }

	public Carta()
	{
	}
	public Carta(string nombreMonstruo, Atributo atributo,Tipo tipo)
    {
		NombreMonstruo = nombreMonstruo;
		Atributo = atributo;
		TipoMonstruo = tipo;
    }
}
