using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questions_And_Answers
{
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correcto!!!");
            Form m = new Math2();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrecto!!!, La respuesta es -3");
            Form m = new Math2();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrecto!!!, La respuesta es -3");
            Form m = new Math2();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrecto!!!, La respuesta es -3");
            Form m = new Math2();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
    }
}
