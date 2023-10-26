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
    public partial class Logos3 : Form
    {
        public Logos3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correcto!!!");
            Form l = new Logos4();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrecto!!!");
            Form l = new Logos4();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }
    }
}
