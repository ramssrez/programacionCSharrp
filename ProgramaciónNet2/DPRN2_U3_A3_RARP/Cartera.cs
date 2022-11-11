﻿namespace UnidadTresA3
{
    class Cartera
    {
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public double Presupuesto { get; set; }
        public List<Compra> Compras { get; set; }
        public Cartera(string nombre, string apellido, double presupuesto)
        {
            Compras = new List<Compra>();
            Presupuesto = presupuesto;
            Nombre = nombre;
            Apellido = apellido;
        }
        //Declaración del método que guarda la información de la moneda virtual
        public void GuardarInformacion(MonedaVirtual moneda, double monedasCompradas,double inversion)
        {
            Compra compra = new ();
            compra.RealizarCompra(moneda, monedasCompradas, inversion);
            Presupuesto -= inversion;
            Compras.Add(compra);
        }
        private double InversionTotal()
        {
            double suma = 0.0;
            for (int i = 0; i < Compras.Count; i++)
            {
                suma += Compras[i].Inversion;
            }
            return suma;
        }
        public void MostrarCarteraVitual()
        {
            Console.WriteLine("Monedas en la cartera: ");
            foreach (Compra i in Compras)
            {
                Console.WriteLine($"Id: {i.Moneda.ID}, Total: {i.MonedasComprada} monedas, Inversión: ${i.Inversion}");
            }
            Console.WriteLine($"Inversión total: ${InversionTotal()}");
            Console.WriteLine($"Presupuesto: {Presupuesto}");
        }
    }
}