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
    public partial class Cars3 : Form
    {
        public Cars3()
        {
            InitializeComponent();
            panel4.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form salir = new Form1();
            this.Hide();
            salir.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
            MessageBox.Show("Incorrecto!!!");
            panel4.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;
            MessageBox.Show("Incorrecto!!!");
            panel4.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Green;
            MessageBox.Show("Correcto!!!");
            panel4.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form salir = new Form1();
            this.Hide();
            salir.ShowDialog();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
