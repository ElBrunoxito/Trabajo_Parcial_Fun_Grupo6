using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSalud_TP_Fundamentos.Entidades
{
    internal class Medico
    {
        public Medico()
        {
            Especialidades = new();
        }
        public int idMedico { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Genero { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Bitmap Avatar { get; set; }
        public List<Especialidad> Especialidades { get; set; }

    }
}
