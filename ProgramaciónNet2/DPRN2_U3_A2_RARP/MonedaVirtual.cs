namespace UnidadTresA2
{
    //Declaración de la clase MonedaVirtual
    class MonedaVirtual
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string ID { get; set; }
        public double Precio { get; set; }
        //Declaración del constructor vacio de la clase
        public MonedaVirtual()
        {

        }
        //Declaración del método que guarda la informaicón de la moneda virtual
        public void GuardarInformacion(int numero, string nombre, string id, double precio)
        {
            Numero = numero;
            Nombre = nombre;
            ID = id;
            Precio = precio;
        }
        //Método que muestra la información de la moneda virtual
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