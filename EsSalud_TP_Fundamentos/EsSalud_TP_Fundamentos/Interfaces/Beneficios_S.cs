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
using System.Drawing;

namespace EsSalud_TP_Fundamentos.Interfaces
{
    public partial class Beneficios_S : Form
    {

        private Stack<Beneficio> pilaDeBeneficios = new();
        public Beneficios_S(string DNI)
        {
            InitializeComponent();
            pilaDeBeneficios = BeneficiosService.getBeneficiosPorDNI(DNI);
            MostrarBeneficios();

        }

        private void Beneficios_S_Load(object sender, EventArgs e)
        {
            //MostrarBeneficios();
            MessageBox.Show($"Usted tiene {pilaDeBeneficios.Count} beneficios");
        }

        private void MostrarBeneficios()
        {

            flowLayoutPanel1.Controls.Clear();
            int Inicial = 1;

            foreach (Beneficio b in pilaDeBeneficios)
            {
                Label l = new();
                l.AutoSize = true;
                l.Text = $"{Inicial}. Nombre: {b.Nombre}     Cantidad: {b.Cantidad}";
                l.ForeColor = Color.DarkBlue;
                //l.Location = new Point(0,Inicial);

                //Inicial += 20;
                l.Margin = new Padding(0, 0, 0, 20);
                flowLayoutPanel1.Controls.Add(l);
                Inicial++;
            }

        }

    }
}
