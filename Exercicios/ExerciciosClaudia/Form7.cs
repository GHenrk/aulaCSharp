using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosClaudia
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form3 sequenciometro = new Form3();
            sequenciometro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 caracteres = new Form4();
            caracteres.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fatorial = new Form5();
            fatorial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 conversao = new Form6();
            conversao.ShowDialog();
        }
    }
}
