using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSalud_TP_Fundamentos.Entidades
{
    internal class ConsultaQueja
    {
        public ConsultaQueja() { }  
        public int ?id { get; set; }
        public string nombre { get; set; }
        public string descricao { get; set;}
        public string DNIPaciente { get; set; }
        public int id_Hospital { get; set;}
    }
}
