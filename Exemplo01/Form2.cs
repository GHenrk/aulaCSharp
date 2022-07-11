using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ch_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.Show();
        }

        private void btn_cs_Click(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            tres.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_sairJanela_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
