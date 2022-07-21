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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lstCaracteres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string astr = "*";

            for (int i = 0; i <=10; i++)
            {
                lstCaracteres.Items.Add(astr);
                astr += "*";
                //astr = astr + "*"; 
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstCaracteres.Items.Clear();
        }
    }
}
