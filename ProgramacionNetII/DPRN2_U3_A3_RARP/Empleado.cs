namespace UnidadTresA3
{
    public class Empleado
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Salario { get; set; }
        public Empleado()
        {

        }
        public Empleado(int codigo, string nombre, decimal salario)
        {
            Codigo = codigo;
            Nombre = nombre;
            Salario = salario;
        }
        public string DatosEntidad()
        {
            return $"Codigo: {Codigo}\n" +
                    $"Nombre: {Nombre}\n" +
                    $"Salario: {Salario}";
        }
    }
}