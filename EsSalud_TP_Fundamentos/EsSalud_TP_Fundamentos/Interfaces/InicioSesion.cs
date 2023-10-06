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

namespace EsSalud_TP_Fundamentos.Interfaces
{
    public partial class InicioSesion : Form
    {
        private PacienteService PS = new();
        private string Cl = string.Empty;
        public InicioSesion()
        {
            InitializeComponent();
            Cl = "Miclavesecreta85";
        }



        private void button1_Click(object sender, EventArgs e)
        {


            if (TB_DNI.Text == "" || TB_Contra.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            if (TB_DNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos");
                return;
            }
            if (!PacienteService.ExistePaciente(TB_DNI.Text))
            {
                //Registro
                DialogResult dr = MessageBox.Show("DNI no existente en la base de datos", "¿Deseas registrarte?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Registro fr = new();
                    fr.Show();
                }
                return;
            }
            Paciente PTemp = PacienteService.getPaciente(TB_DNI.Text);
            if (PTemp.DNI != TB_DNI.Text || Salvar.Desen(PTemp.CoE, Cl) != TB_Contra.Text)
            {
                MessageBox.Show("DNI o contraseña incorrecta");
                return;
            }
            Principal Fp = new(PTemp.DNI);
            Fp.Show();


        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
