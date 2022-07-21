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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSequencia_Click(object sender, EventArgs e)
        {
            try
            {
                int valorInicial = Convert.ToInt32(txbInicial.Text);
                int valorFinal = Convert.ToInt32(txbFinal.Text);
                         

                if (valorInicial > valorFinal) 
                {
                 
                    for (int i = valorInicial; i >= valorFinal; i--)
                    {
                        lstSequencia.Items.Add(i.ToString());
                        if (i % 2 == 0) {
                            lstPares.Items.Add(i.ToString());
                        }
                        if (i%7 == 0)
                        {
                            lstMultiplos.Items.Add(i.ToString());
                        }
                        if (i< 0)
                        {
                            lstNegativos.Items.Add(i.ToString());
                        } 
                        if (lstNegativos.Items.Count == 0)
                        {
                            lstNegativos.Items.Add("Não existem negativos");
                        }
                    }
                }
                else
                {
                    for (int i = valorInicial; i<=valorFinal; i++)
                    {

                        lstSequencia.Items.Add(i.ToString());
                        if (i % 2 == 0)
                        {
                            lstPares.Items.Add(i.ToString());
                        }
                        if (i % 7 == 0)
                        {
                            lstMultiplos.Items.Add(i.ToString());
                        }
                        if (i < 0)
                        {
                            lstNegativos.Items.Add(i.ToString());
                        }
                        if (lstNegativos.Items.Count == 0)
                        {
                            lstNegativos.Items.Add("Não existem negativos");
                        }

                    }
                }

            } catch {
                MessageBox.Show("Por favor insira um numero inteiro válido");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbFinal.Clear();
            txbInicial.Clear();
            lstSequencia.Items.Clear();
            lstNegativos.Items.Clear();
            lstMultiplos.Items.Clear();
            lstPares.Items.Clear();
        }
    }
}
