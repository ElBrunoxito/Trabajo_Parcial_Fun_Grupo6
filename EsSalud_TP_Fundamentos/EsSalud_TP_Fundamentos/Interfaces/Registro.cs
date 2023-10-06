using EsSalud_TP_Fundamentos.Entidades;
using EsSalud_TP_Fundamentos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsSalud_TP_Fundamentos.Interfaces
{
    public partial class Registro : Form
    {


        private string Cl = string.Empty;

        public Registro()
        {
            InitializeComponent();
            Cl = "Miclavesecreta85";
        }
        private bool EsCorreo(string correo)
        {
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Se utiliza la clase Regex para realizar la validación
            Regex regex = new Regex(patronCorreo);

            return regex.IsMatch(correo);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TB_DNI.Text == "" || TB_Nombre.Text == "" || TB_Apellidos.Text == "" || TB_Genero.Text == "" || TB_Direccion.Text == "" ||
                TB_Telefono.Text == "" || TB_Correo.Text == "" || TB_Contra.Text == "" || TB_CContra.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            if (!EsCorreo(TB_Correo.Text))
            {
                MessageBox.Show("Ingrese un correo existente");
                return;
            }
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Seleccione una foto");
                return;
            }
            if (PacienteService.ExistePaciente(TB_DNI.Text))
            {
                MessageBox.Show("Este DNI ya se registro xd");
                return;
            }
            if (TB_CContra.Text != TB_Contra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }



            Paciente? p = new()
            {
                DNI = TB_DNI.Text,
                Nombre = TB_Nombre.Text,
                Apellidos = TB_Apellidos.Text,
                FechaNacimiento = DT_Fecha.Value,//dateTimePicker1.Value,
                Genero = TB_Genero.Text[0],
                Direccion = TB_Direccion.Text,
                Telefono = TB_Telefono.Text,
                Correo = TB_Correo.Text,
                CoE = Salvar.En(TB_Contra.Text, Cl).ToString(),
                Avatar = new Bitmap(pictureBox2.Image)//new Bitmap(pictureBox2.Image)


            };
            PacienteService.addPaciente(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarImagen();




        }
        private void CargarImagen()
        {
            OpenFileDialog ofd = new();
            ofd.Filter = "Imagenes | *.png;*.jpg;*.jfif;*.jpeg";
            ofd.Title = "Abrir Imagen";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string Ruta = ofd.FileName;
                Bitmap btemp = new Bitmap(Ruta);
                pictureBox2.Image = btemp;
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void TB_DNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CargarImagen();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
