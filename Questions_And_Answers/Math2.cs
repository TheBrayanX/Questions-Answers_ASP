using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questions_And_Answers
{
    public partial class Math2 : Form
    {
        public Math2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correcto!!!");
            Form m = new Math3();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrecto!!!, La respuesta es 90°");
            Form m = new Math3();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrecto!!!, La respuesta es 90°");
            Form m = new Math3();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrecto!!!, La respuesta es 90°");
            Form m = new Math3();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
    }
}
