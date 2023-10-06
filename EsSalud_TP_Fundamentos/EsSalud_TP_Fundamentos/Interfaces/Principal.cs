using EsSalud_TP_Fundamentos.Entidades;
using EsSalud_TP_Fundamentos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace EsSalud_TP_Fundamentos.Interfaces
{
    public partial class Principal : Form
    {
        private string DNI = "";
        public Principal(string dni)
        {
            InitializeComponent();
            DNI = dni;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Paciente p = PacienteService.getPaciente(DNI);
            menuStrip1.Items[0].Image = p.Avatar;
            menuStrip1.Items[0].Text = p.Nombre;

        }
        private void btn_click(object sender, EventArgs e)
        {

        }
        //private void




        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mi cuenta
        }

        private void informacionAdministrativaYSegurosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programacionDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lenar el combo box
            Panel_Programacion_Citas.Visible = true;

            List<Especialidad> letemp = new();
            letemp = ReservaService.getAllEspecialidades();
            letemp.ForEach(e =>
            {
                uno_cb_tipo.Items.Add(e.Nombre);
            });








        }
        private void Reservar_Click(object sender, EventArgs e)
        {

        }

        private void Programacion_Citas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(uno_dt_fecha.Value.Date.ToString());
            MessageBox.Show(uno_dt_hora.Value.TimeOfDay.ToString());
            if (uno_cb_tipo.Items.Count == 0 || uno_cb_medicos.Items.Count == 0 || uno_cb_hospital.Items.Count == 0)
            {
                MessageBox.Show("No hay reserva para esto D:");
                return;
            }

            if (uno_cb_tipo.Text == "" || uno_cb_hospital.Text == "" || uno_cb_medicos.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            //Validar la hora

            //Existe horario
            int idM = ReservaService.getIDMedico(uno_cb_medicos.Text);
            int idH = ReservaService.getIDHospital(uno_cb_hospital.Text);
            bool aux_exite = ReservaService.ExisteHorario(uno_dt_fecha.Value,uno_dt_hora.Value,idM,idH);
            if (aux_exite)
            {
                MessageBox.Show("La cita ya esta reservada");
                return;
            }
            TimeSpan tste = TimeSpan.FromHours(1);
            Cita ctemp = new()
            {
                ID = 0,
                fecha = uno_dt_fecha.Value,
                hora = uno_dt_hora.Value,
                Estado = "Pendiente",
                Duracion = DateTime.MinValue.Add(tste),
                idPaciente = this.DNI,
                idMedico = idM,
                idHospital = idH
            };

            ReservaService.addCitaMedica(ctemp);
        }

        private void uno_cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cmabiar hospital

            List<Hospital> lhtemp = new();
            lhtemp = ReservaService.getHospitalesPorEspecialidad(ReservaService.getIDEspecialidad(uno_cb_tipo.Text));
            uno_cb_hospital.Items.Clear();
            lhtemp.ForEach(h =>
            {
                uno_cb_hospital.Items.Add(h.Nombre);
            });


        }

        private void uno_cb_hospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleccionar medicos de ese hospital
            List<Medico> lmtemp = new();
            int ih = ReservaService.getIDHospital(uno_cb_hospital.Text);
            int ie = ReservaService.getIDEspecialidad(uno_cb_tipo.Text);
            lmtemp = ReservaService.getMedicoPorEspecialidadyHospital(ie, ih);
            uno_cb_medicos.Items.Clear();
            lmtemp.ForEach(m =>
            {
                uno_cb_medicos.Items.Add(m.Nombre);
            });


        }

        private void uno_dt_fecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
