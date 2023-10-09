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


        public static string getBeneficio(int edad, char genero)
        {
            string Q = "";
            if (edad >= 18 && edad <= 65)
            {
               Q = $"INSERT INTO Beneficios (nombre,descripcion,cantidad,Paciente_DNI)" +
                   $"VALUES ('Para adultos', 'Descripcion para adultos entre 18 y 65 años', 15, @dni);";
            }
            else
            {
               Q = $"INSERT INTO Beneficios (nombre,descripcion,cantidad,Paciente_DNI)" +
                     $"VALUES ('Para personas mayores', 'Descripcion para mayores de 65años', 20, @dni);";
            }


            if(genero == 'M')
            {
                Q+= $"INSERT INTO Beneficios (nombre,descripcion,cantidad,Paciente_DNI)" +
                     $"VALUES ('Para varones', 'Descripcion para varones', 5, @dni);";
            }
            else if (genero == 'F')
            {
                Q += $"INSERT INTO Beneficios (nombre,descripcion,cantidad,Paciente_DNI)" +
                     $"VALUES ('Para mujeres', 'Descripcion para mujeres', 5, @dni);";
            }
            return Q;
        }
        public static int getEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Verifica si aún no ha sido su cumpleaños en este año
            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }
    }
}
