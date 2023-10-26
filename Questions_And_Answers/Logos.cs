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
    public partial class Logos : Form
    {
        public Logos()
        {
            InitializeComponent();
        }

        private void Logos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correcto!!!");
            Form l = new Logos2();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrecto!!!");
            Form l = new Logos2();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }
    }
}
