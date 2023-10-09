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
    public partial class Tramites_S : Form
    {
        public Tramites_S()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel_InicioSesion.VerticalScroll.Value = e.NewValue;
            //this.VerticalScroll.Value = e.NewValue;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
