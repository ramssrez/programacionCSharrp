using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDPRN3RRP2302B1
{
    internal class Paciente
    {
        public int IdRRP { get; set; }
        public string NombreRRP { get; set; }
        public string ApellidoPaternoRRP { get; set; }
        public string ApellidoMaternoRRP { get; set; }
        public string DireccionRRP { get; set; }
        public string TelefonoFijoRRP { get; set; }
        public string CelularRRP { get; set; }
        public string EmailRRP { get; set; }
        public int EdadRRP { get; set; }
        public char SexoRRP { get; set; }
        public int EstadoCivilRRP { get; set; }
        public string EstadoCivilStringRRP { get; set; }
        public string TipoEstadoCivil()
        {
            string s = "";
            if (EstadoCivilRRP == 1)
            {
                s = "Soltero(a)"; 
            }
            if (EstadoCivilRRP == 2)
            {
                s = "Casado(a)";
            }
            if (EstadoCivilRRP == 3)
            {
                s = "Viudo(a)";
            }
            if (EstadoCivilRRP == 4)
            {
                s = "Divorciado(a)";
            }
            if (EstadoCivilRRP == 5)
            {
                s = "Concubinato(a)";
            }
            return s;
        }
    }
}
