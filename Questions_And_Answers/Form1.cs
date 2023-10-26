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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form M = new Math();
            this.Hide();
            M.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form carros = new Cars();
            this.Hide();
            carros.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form l = new Logos();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Deportes d = new Deportes();
            this.Hide();
            d.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
