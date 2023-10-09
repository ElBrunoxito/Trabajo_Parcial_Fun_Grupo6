using EsSalud_TP_Fundamentos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSalud_TP_Fundamentos.Servicios
{
    internal class ConsultaService
    {
        private static ConsultasBD c = new();
        public ConsultaService() { }

        public static List<Hospital> getAllHospitales()
        {
            return c.getHospitalesExistentes();
        }

        public static void addConsultaQueja(ConsultaQueja cq)
        {
            c.addConsultaQueja(cq);
        }
    }
}
