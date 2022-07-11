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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_cs_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.Show();
        }

        private void btn_ch_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.Show();

        }
    }
}
