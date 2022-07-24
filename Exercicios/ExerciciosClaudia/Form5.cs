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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = (int)Convert.ToInt64(txbNum.Text);
                double fatorial = numero;

                if (numero > 0)
                {
                    for (int i = numero - 1; i > 0; i--)
                    {
                        fatorial = fatorial * i;

                    }
                    string resultado = $"{numero.ToString()}!";
                    resultado += $" = {fatorial.ToString()}";
                    lblResultado.Visible = true;
                    txbResultado.Visible = true;
                    txbResultado.Text = resultado;
                } else if (numero == 0)
                {
                    lblResultado.Visible = true;
                    txbResultado.Visible = true;
                    txbResultado.Text = $"{numero}! = {1.ToString()}";
                } else
                {
                    MessageBox.Show("Não existe calculo fatorial para números negativos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Por favor insira um valor inteiro válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNum.Clear();
            txbResultado.Clear();
            txbResultado.Visible = false;
            lblResultado.Visible = false;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
