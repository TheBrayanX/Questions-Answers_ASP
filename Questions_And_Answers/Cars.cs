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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form salir = new Form1();
            salir.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            MessageBox.Show("Incorrecto!!!");
            Form entrar = new Cars2();
            this.Hide();
            entrar.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            MessageBox.Show("Correcto!!!");
            Form entrar = new Cars2();
            this.Hide();
            entrar.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            MessageBox.Show("Incorrecto!!!");
            Form entrar = new Cars2();
            this.Hide();
            entrar.ShowDialog();
            this.Close();
        }
    }
}
