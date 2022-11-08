namespace UnidadTresA2
{
    class MonedaVirtual
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string ID { get; set; }
        public double Precio { get; set; }
        public MonedaVirtual()
        {

        }
        public void GuardarInformacion(int numero, string nombre, string id, double precio)
        {
            Numero = numero;
            Nombre = nombre;
            ID = id;
            Precio = precio;
        }
        public string MostrarInformacion()
        {
            string info = $"Numero: {Numero} \n" +
                $"Nombre: {Nombre} \n" +
                $"Id: {ID} \n" +
                $"Precio: ${Precio}";
            return info;
        }
    }
}