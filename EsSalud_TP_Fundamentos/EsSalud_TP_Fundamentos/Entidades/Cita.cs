using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSalud_TP_Fundamentos.Entidades
{
    internal class Cita
    {
        public int ID { get; set; }
        public DateTime fecha { get; set;}
        public DateTime hora { get; set;}
        public string Estado { get; set;}
        public DateTime Duracion { get; set;}
        public string? idPaciente { get; set;}
        public int idMedico { get; set;}
        public int idHospital { get;set;}


    }
}
