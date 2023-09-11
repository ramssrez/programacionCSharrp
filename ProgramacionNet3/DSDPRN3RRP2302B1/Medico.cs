using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDPRN3RRP2302B1
{
    //Clase para poder crear objetos de tipo Médico
    internal class Medico
    {
        //Atributos de la clase con sus repectivos getters y setters
        public int IdRRP { get; set; }
        public string NombreRRP { get; set; }
        public string ApellidoPaternoRRP { get; set; }
        public string ApellidoMaternoRRP { get; set; }
        public string CedulaRRP { get; set; }
        public string EspcialidadRRP { get; set; }
        public int EspcialidadIntRRP { get; set; }
    }
}
