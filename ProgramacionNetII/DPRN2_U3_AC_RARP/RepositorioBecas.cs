namespace UnidadTresAC
{
    //Declaración de la beca repositorio
    public class RepositorioBecas
    {
        //Declaración de variables locales y variables con sus getters y setters
        public List<Beca> Becas { get; set; }
        private const string archivoCSV = "becas.csv";
        //Constructor vacío de la clase
        public RepositorioBecas()
        {
            Becas = new List<Beca>();
            LeerBecasDesdeArchivo();
        }
        //Método que permite una alta de la beca y almacena en el archivo csv y retorna un string de la alta
        public string AltaNuevaBeca(int id, string pais, decimal monto, string tipo, string valor)
        {
            try
            {
                if (NoPermitirAltaBeca(pais))
                {
                    throw new BecaNoPermitidaException(StringProyect.ErrorPais(pais));
                }
                Beca? nuevaBeca = null;
                if (tipo.Equals(StringProyect.ACADEMICA, StringComparison.OrdinalIgnoreCase))
                {
                    nuevaBeca = new BecaAcademica { ID = id, Pais = pais, Monto = monto, TipoBeca = tipo, Universidad = valor };
                }
                if (tipo.Equals(StringProyect.DEPORTIVA, StringComparison.OrdinalIgnoreCase))
                {
                    nuevaBeca = new BecaDeportiva { ID = id, Pais = pais, Monto = monto, TipoBeca = tipo, Deporte = valor };
                }
                Becas.Add(nuevaBeca);
                GuardarBecasEnArchivo();
                return StringProyect.EXITO_BECA;
            }
            catch (BecaNoPermitidaException ex)
            {
                return ex.Message;
            }
        }
        //Método que elimina las becas seleccionadas por el id
        public void EliminarBeca(string input)
        {
            try
            {
                string[] ids = input.Split(',');
                foreach (string id in ids)
                {
                    int idBeca = int.Parse(id);
                    Beca? becaEncontrada = Becas.Find(b => b.ID == idBeca);
                    if (becaEncontrada != null)
                    {
                        Becas.Remove(becaEncontrada);
                        Console.WriteLine(StringProyect.BecaEliminada(id));
                    }
                    else
                    {
                        Console.WriteLine(StringProyect.BecaNoEncontrada(id));
                    }
                }
                GuardarBecasEnArchivo();
            }
            catch (FormatException)
            {
                Console.WriteLine(StringProyect.ERROR_FORMATO_STRING);
            }
        }
        //Método que muestra las becas encontradas por país
        public void ConsultarBecasPorPais(string pais)
        {
            bool becasEncontradas = false;
            foreach (Beca beca in Becas)
            {
                if (beca.Pais.Equals(pais, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Beca encontrada: ");
                    Console.WriteLine(beca.MostrarDetalles());
                    Console.WriteLine(StringProyect.STRING_FORMATO);
                    becasEncontradas = true;
                }
            }
            if (!becasEncontradas)
            {
                Console.WriteLine(StringProyect.BecaNoEncontradaPais(pais));
            }
        }
        //Método que devuelve el monto total de las becas y la cantidad de becas
        public (decimal, int) ResumenBecas()
        {
            decimal montoTotal = 0;
            foreach (Beca beca in Becas)
            {
                montoTotal += beca.Monto;
            }
            return (montoTotal,Becas.Count);
        }
        //Método que lee el archivo para crear diferentes objetos para las becas del archivo csv
        private void LeerBecasDesdeArchivo()
        {
            if (File.Exists(archivoCSV))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(archivoCSV))
                    {
                        while (!reader.EndOfStream)
                        {
                            string linea = reader.ReadLine();
                            string[] campos = linea.Split(',');
                            if (campos.Length == 4)
                            {
                                int id = int.Parse(campos[0]);
                                string pais = campos[1];
                                decimal monto = decimal.Parse(campos[2]);
                                string tipo = campos[3];
                                if (tipo.Equals(StringProyect.DEPORTIVA, StringComparison.OrdinalIgnoreCase))
                                {
                                    BecaDeportiva becaD = new(id, pais, monto, tipo);
                                    Becas.Add(becaD);
                                }
                                if (tipo.Equals(StringProyect.ACADEMICA, StringComparison.OrdinalIgnoreCase))
                                {
                                    BecaAcademica becaA = new(id, pais, monto, tipo);
                                    Becas.Add(becaA);
                                }
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine(StringProyect.ERROR_READ_CSV);
                }
            }
        }
        //Método que guarda los cambios realizados en el proyecto en el archivo csv
        private void GuardarBecasEnArchivo()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivoCSV))
                {
                    foreach (Beca beca in Becas)
                    {
                        string linea = $"{beca.ID},{beca.Pais},{beca.Monto},{beca.TipoBeca}";
                        writer.WriteLine(linea);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine(StringProyect.ERROR_UPDATE_CSV);
            }
        }
        //Método que verifica los paises no permitidos para las becas
        private static bool NoPermitirAltaBeca(string pais)
        {
            string[] paisesNoPermitidos = { "Cuba", "Corea del norte", "Rusia", "Venezuela" };

            foreach (string p in paisesNoPermitidos)
            {
                if (p.Equals(pais, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}