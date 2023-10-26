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
    public partial class Logos5 : Form
    {
        public Logos5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrecto!!!");
            DialogResult dialogResult = MessageBox.Show("Felicidades, terminaste el test. ¿Quieres hacer otro?", "TERMINADO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form m = new Form1();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correcto!!!");
            DialogResult dialogResult = MessageBox.Show("Felicidades, terminaste el test. ¿Quieres hacer otro?", "TERMINADO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form m = new Form1();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
