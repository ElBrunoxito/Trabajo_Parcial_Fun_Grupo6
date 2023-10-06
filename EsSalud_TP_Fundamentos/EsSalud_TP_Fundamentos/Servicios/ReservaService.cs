using EsSalud_TP_Fundamentos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSalud_TP_Fundamentos.Servicios
{
    internal class ReservaService
    {
        public ReservaService() { }
        private static ConsultasBD c = new();
        
        public static void addCitaMedica(Cita ci)
        {
            c.AddCita(ci);
        }
        public static List<Especialidad> getAllEspecialidades()
        {
            return c.getEspecialidadesExistente();
        }
        public static List<Hospital> getAllHospitales()
        {
            return c.getHospitalesExistentes();
        }
            public static List<Hospital> getHospitalesPorEspecialidad(int idEspecialidad)
        {
            return c.getHospitalesPorEspecialidad(idEspecialidad);
        }
        public static List<Medico> getMedicoPorEspecialidadyHospital(int idEspecialidad, int idHospital)
        {
            return c.getMedicoPorEspecialidadyHospital(idEspecialidad,idHospital);
        }
        public static int getIDHospital(string nombre) {
            List<Hospital> hospitales = new();
            hospitales = getAllHospitales();
            Hospital? hos = hospitales.Find(h=>h.Nombre == nombre);
            return hos.ID;
        }

        public static int getIDEspecialidad(string nombre)
        {
            List<Especialidad> especialidad = new();
            especialidad = getAllEspecialidades();
            Especialidad? es = especialidad.Find(e => e.Nombre == nombre);
            return es.id;
        }

        public static int getIDMedico(string nombre)
        {
            List<Medico> medicos = new();
            medicos = c.getMedicosExistentes();
            Medico? es = medicos.Find(e => e.Nombre == nombre);
            return es.idMedico;
        }
        public static bool ExisteHorario(DateTime fecha ,DateTime T, int m, int h)
        {
            List<Cita> citastemp = new();
            //Reueprar
            citastemp = c.getAllCitas();

            //
            //return citastemp.Exists(c=> c.fecha == fecha && c.hora == T);
            return citastemp.Exists(c => c.fecha.Date == fecha.Date && c.hora == T && c.idMedico == m && c.idHospital == h);

        }

    }
}
