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
    public partial class Deportes : Form
    {
        public Deportes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Red;
            MessageBox.Show("Oh no! Seleccionaste mal la respuesta.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Red;
            MessageBox.Show("Oh no! Seleccionaste mal la respuesta.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Green;
            MessageBox.Show("La respuesta es correcta. Felicidades! ");
            Deportes2 d1 = new Deportes2();
            this.Hide();
            d1.ShowDialog();
            this.Close();
        }
    }
}
