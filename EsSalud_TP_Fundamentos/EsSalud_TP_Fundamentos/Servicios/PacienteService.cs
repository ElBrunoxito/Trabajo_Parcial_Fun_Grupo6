using EsSalud_TP_Fundamentos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSalud_TP_Fundamentos.Servicios
{
    internal class PacienteService
    {
        public PacienteService() { }
        private static ConsultasBD c = new();
        public static void addPaciente(Paciente p)
        {
            c.AddPaciente(p);
        }
        public static  List<Paciente> getAllPacientes()
        {
            return c.SelectAllPacientes();
        }
        public static bool ExistePaciente(string dni)
        {
            List<Paciente> p = new();
            p = c.SelectAllPacientes();
            return p.Exists(pa=>pa.DNI == dni);
        }
        public static Paciente getPaciente(string dni)
        {
            Paciente paciente = c.SelectAllPacientes().Find(p => p.DNI == dni);
            if(paciente != null)
            {
                return paciente;
            }
            else
            {
                return new Paciente();
            }
        }
    }
}
