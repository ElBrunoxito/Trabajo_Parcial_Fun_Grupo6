using EsSalud_TP_Fundamentos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSalud_TP_Fundamentos.Servicios
{
    internal class BeneficiosService
    {
        public BeneficiosService() { }
        private static ConsultasBD c = new();
        public static Stack<Beneficio> getBeneficiosPorDNI(string dni)
        {
            return c.getBeneficiosPorDNI(dni);
        }

    }
}
