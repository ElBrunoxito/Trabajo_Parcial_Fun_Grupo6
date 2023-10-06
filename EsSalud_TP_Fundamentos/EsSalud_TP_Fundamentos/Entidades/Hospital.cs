using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSalud_TP_Fundamentos.Entidades
{
    internal class Hospital
    {
        public Hospital() { }
        public int ID {  get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string PaginaWeb { get; set; }
        public DateTime FechaFundacion { get; set; }
        
    }
}
