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
    public partial class Cars2 : Form
    {
        public Cars2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            MessageBox.Show("Incorrecto!!!");
            Form entrar = new Cars3();
            this.Hide();
            entrar.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form salir = new Form1();
            this.Hide();
            salir.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            MessageBox.Show("Incorrecto!!!");
            Form entrar = new Cars3();
            this.Hide();
            entrar.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Green;
            MessageBox.Show("Correcto!!!");
            Form entrar = new Cars3();
            this.Hide();
            entrar.ShowDialog();
            this.Close();
        }
    }
}
