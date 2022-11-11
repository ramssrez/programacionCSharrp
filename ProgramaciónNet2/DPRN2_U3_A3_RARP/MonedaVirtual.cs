namespace UnidadTresA3
{
    //Declaración de la clase MonedaVirtual
    class MonedaVirtual
    {
        //Declaración de los atributos de la clase, así como los getters y setters
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string ID { get; set; }
        public double Precio { get; set; }
        public string FechaPrecio { get; set; }
        //Declaración del constructor vacio de la clase
        public MonedaVirtual()
        {

        }
        //Declaración del contructor con argumentos
        public MonedaVirtual(int numero, string nombre, string id, double precio, string fecha)
        {
            Numero = numero;
            Nombre = nombre;
            ID = id;
            Precio = precio;
            FechaPrecio = fecha;
        }
        //Método que muestra la información de la moneda virtual
        public string MostrarInformacion()
        {
            string info = $"Numero: {Numero} \n" +
                $"Nombre: {Nombre} \n" +
                $"Id: {ID} \n" +
                $"Precio: ${Precio} \n" +
                $"Fecha precio: {FechaPrecio}";
            return info;
        }
    }
}