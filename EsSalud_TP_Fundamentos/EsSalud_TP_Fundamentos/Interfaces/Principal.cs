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
using Microsoft.IdentityModel.Tokens;

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
            Panel_Info_Adms.Location = new Point(0, 24);
            Panel_Info_Adms.Visible = true;
            Panel_Programacion_Citas.Visible = false;
            panel_Consultas.Visible = false;
        }

        private void programacionDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lenar el combo box
            Panel_Programacion_Citas.Location = new Point(0,24);
            Panel_Programacion_Citas.Visible = true;
            Panel_Info_Adms.Visible = false;
            panel_Consultas.Visible = false;
            uno_cb_tipo.Items.Clear();
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
            Panel_Info_Adms.Visible = false;
            if (uno_cb_tipo.Items.Count == 0 || uno_cb_medicos.Items.Count == 0 || uno_cb_hospital.Items.Count == 0)
            {
                MessageBox.Show("No hay reserva D:");
                return;
            }

            if (uno_cb_tipo.Text == "" || uno_cb_hospital.Text == "" || uno_cb_medicos.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            //Validar la hora
            DateTime dtTemp = DateTime.Now;
            if (dtTemp.Month > uno_dt_fecha.Value.Month || dtTemp.Day > uno_dt_fecha.Value.Day || dtTemp.Hour > uno_dt_hora.Value.Hour)
            {
                MessageBox.Show("Elija un horario o dia correcto :)");
                return;
            }
            //Existe horario
            int idM = ReservaService.getIDMedico(uno_cb_medicos.Text);
            int idH = ReservaService.getIDHospital(uno_cb_hospital.Text);
            bool aux_exite = ReservaService.ExisteHorario(uno_dt_fecha.Value, uno_dt_hora.Value, idM, idH);
            if (aux_exite)
            {
                MessageBox.Show("La cita ya esta reservada");
                return;
            }
            DialogResult dr = MessageBox.Show("¿Los datos son correctos?", "Reserva", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
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
            MessageBox.Show("Introducido");
        }

        private void uno_cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cmabiar hospital
            uno_cb_hospital.Text = string.Empty;
            uno_cb_medicos.Text = string.Empty;
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
            uno_cb_medicos.Text = string.Empty;
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

        private void dos_btn_tramites_Click(object sender, EventArgs e)
        {
            //TRAMITES ADMINISTRATIVOS
            Tramites_S t = new();
            t.Show();
        }

        private void dos_btn_beneficios_Click(object sender, EventArgs e)
        {
            //BENEFICIOS DE SEGUROS
            Beneficios_S f = new(DNI);
            f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private Dictionary<string, int> nobmre_ID_Hos;
        private void consultasYQuejasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Consultas.Location = new Point(0, 24);
            panel_Consultas.Visible = true;
            Panel_Info_Adms.Visible = false;
            Panel_Programacion_Citas.Visible = false;
            //Consultas y quejas
            List<Hospital> mtemp = new();
            nobmre_ID_Hos = new();
            mtemp = ConsultaService.getAllHospitales();
            cuatro_hospital.Items.Clear();
            foreach (Hospital m in mtemp)
            {
                cuatro_hospital.Items.Add(m.Nombre);
                nobmre_ID_Hos.Add(m.Nombre, m.ID);
            }

            radioButton1.Checked = true;

        }

        private void panel_Consultas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cuatro_hospital.Text == "")
            {
                MessageBox.Show("Selecione un hospital");
                return;
            }
            string title = "";

            if (radioButton1.Checked == true)
            {
                title = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                title = radioButton2.Text;
            }
            if (cuatro_Queja_tb.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Ingresa tu comentario");
                return;
            }

            //Ingresar
            ConsultaQueja cqtemp = new()
            {
                id = null,
                nombre = title,
                descricao = cuatro_Queja_tb.Text,
                DNIPaciente = this.DNI,
                id_Hospital = nobmre_ID_Hos[cuatro_hospital.Text]
            };

            ConsultaService.addConsultaQueja(cqtemp);
            //MessageBox.Show("Comentario agregado");

        }
    }
}
