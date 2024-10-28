using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayaT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoVista form1 = new AlumnoVista();

            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsignaturaVista form2 = new AsignaturaVista();

            form2.Show();
        }
    }
}
