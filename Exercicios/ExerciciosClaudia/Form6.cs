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
    public partial class Form6 : Form
    {

        //variaveisGlobais;
        int caso = 0;
        double cotacaoDolar = 5.55;
        double valor2;
        bool inversor = false;
        public Form6()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbConversao_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbConversao_ItemCheck(object sender, ItemCheckEventArgs e)
        {
         
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            rdbtn1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "R$";
            lbl2.Text = "U$";
            caso = 0;
            inversor = false;
            
        }

        private void rdbtn2_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "M";
            lbl2.Text = "CM";
            caso = 1;
            inversor = false;
        }

        private void rdbtn3_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Cº";
            lbl2.Text = "Fº";
            caso = 2;
            inversor = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string valorDigitado = txbValor1.Text;
                valorDigitado = valorDigitado.Replace(".", ",");
                float valor1 = float.Parse(valorDigitado);
                
                
                switch (caso)
                {
                    case 0:
                        if (inversor == true)
                        {
                            valor2 = valor1 / cotacaoDolar;
                        } else
                        {
                            valor2 = valor1 * cotacaoDolar;
                        }
                        break;
                    case 1:
                        if (inversor == true)
                        {
                            valor2 = valor1 / 100;
                        }
                        else
                        {
                            valor2 = valor1 * 100;
                        }
                        break;
                    case 2:
                        double F = valor1;
                        if (inversor == true)
                        {
                            F = (F - 32)/1.8;
                            valor2 = F ;

                        } else
                        {   
                            F = F * 1.8;
                            valor2 = F + 32;
                        }
                        break;
                }

                txbValor2.Text = valor2.ToString("F");
            }
            catch
            {
                MessageBox.Show("Algo deu errado. Por favor, tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbValor1.Clear();
            txbValor2.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            inversor = !inversor;
            txbValor1.Clear();
            txbValor2.Clear();
            string x = lbl1.Text;
            lbl1.Text = lbl2.Text;
            lbl2.Text = x;
        }
    }
}
