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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                float numero = float.Parse(txbNum.Text);
                if (numero > 0)
                {
                    lblPN.Text = "O Valor é positivo";
                }
                else if (numero < 0)
                {
                    lblPN.Text = "O Valor é negativo";
                }
                else
                {
                    lblPN.Text = "O Valor é zero";
                }

                if (numero%2 == 0)
                {
                    lblPar.Text = "Este número é par";
                } else
                {
                    lblPar.Text = "Este número é impar";
                }
            } catch
            {
                MessageBox.Show("Favo inserir um valor válido");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblPar.Text = " ";
            lblPN.Text = " ";
            txbNum.Clear();
        }
    }
}
