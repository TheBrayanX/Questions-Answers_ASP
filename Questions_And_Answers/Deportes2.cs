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
    public partial class Deportes2 : Form
    {
        public Deportes2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Red;
            MessageBox.Show("Oh no! Seleccionaste mal la respuesta. ");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Green;
            MessageBox.Show("La respuesta es correcta. Felicidades! ");
            Deportes3 d2 = new Deportes3();
            this.Hide();
            d2.ShowDialog();
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Red;
            MessageBox.Show("Oh no! Seleccionaste mal la respuesta. ");
        }
    }
}
