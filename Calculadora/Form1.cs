namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();

        }

        //VariaveisGlobais;
        float valor1, valor2, resposta;
        int caso;
        int click = 0;
        string operacao = " ";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //InversaoValor
        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(txbResultado.Text);
            resposta = valor1 * -1;
            txbResultado.Text = resposta.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {   string numero = txbResultado.Text;
            Boolean ponto;
           
            if (numero.Contains(","))
            {
                ponto = true;
            } else
            {
                ponto = false;
            }
          
            if (ponto != true)
            {
                txbResultado.Text += ',';
            }
        }



        private void button16_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '4';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_zero_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '0';
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '1';
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '2';
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '3';
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '5';
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '6';
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '7';
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '8';
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '9';
        }
        //Btn Menos
        private void btn_menos_Click(object sender, EventArgs e)
        {
            if (click == 1 && txbResultado.Text != string.Empty)
            {
                valor2 = float.Parse(txbResultado.Text);
                calculaNum(caso, valor1, valor2);
                caso = 2;
                txbSecundario.Text = resposta.ToString() + "-";
                valor1 = resposta;
                txbResultado.Clear();


            }
            else if (txbResultado.Text != string.Empty)
            {
                txbSecundario.Text = txbResultado.Text;
                valor1 = float.Parse(txbSecundario.Text);
                txbSecundario.Text += '-';
                txbResultado.Clear();
                caso = 2;
                click = 1;
            }
            else
            {
                apresentaErro();
            }
        }
        //Multiplicacao;
        private void btn_multi_Click(object sender, EventArgs e)
        {
            if (click == 1 && txbResultado.Text != string.Empty)
            {
                valor2 = float.Parse(txbResultado.Text);
                calculaNum(caso, valor1, valor2);
                txbSecundario.Text = resposta.ToString() + "*";
                caso = 3;
                valor1 = resposta;
                txbResultado.Clear();


            }
            else if (txbResultado.Text != string.Empty)
            {
                txbSecundario.Text = txbResultado.Text;
                valor1 = float.Parse(txbSecundario.Text);
                txbSecundario.Text += '*';
                txbResultado.Clear();
                caso = 3;
                click = 1;
            }
            else
            {
                apresentaErro();
            }
        }
        //Divisao
        private void btn_div_Click(object sender, EventArgs e)
        {
            if (click == 1 && txbResultado.Text != string.Empty)
            {
                valor2 = float.Parse(txbResultado.Text);
                calculaNum(caso, valor1, valor2);
                txbSecundario.Text = resposta.ToString() + "/";
                caso = 4;
                valor1 = resposta;
                txbResultado.Clear();


            }
            else if (txbResultado.Text != string.Empty)
            {
                txbSecundario.Text = txbResultado.Text;
                valor1 = float.Parse(txbSecundario.Text);
                txbSecundario.Text += '/';
                txbResultado.Clear();
                caso = 4;
                click = 1;
            }
            else
            {
                apresentaErro();
            }
        }

        //clear
        private void button18_Click(object sender, EventArgs e)
        {
            txbResultado.Clear();
            txbSecundario.Clear();
            valor1 = 0;
            valor2 = 0;
        }

        //btnApagar
        private void button17_Click(object sender, EventArgs e)
        {
            String numeroDigitado = txbResultado.Text;
            int comprimento = numeroDigitado.Length;
            if (comprimento > 0)
            {
                numeroDigitado = numeroDigitado.Remove(comprimento - 1);
                txbResultado.Text = numeroDigitado;
            }
            else
            {
                txbResultado.Text = string.Empty;
            }
        }
        //Soma
        private void button5_Click(object sender, EventArgs e)
        {
            if (click == 1 && txbResultado.Text != string.Empty)
            {
                valor2 = float.Parse(txbResultado.Text);
                calculaNum(caso, valor1, valor2);
                txbSecundario.Text = resposta.ToString() + "+";
                caso = 1;
                valor1 = resposta;
                txbResultado.Clear();


            } else if (txbResultado.Text != string.Empty)
            {
                txbSecundario.Text = txbResultado.Text;
                valor1 = float.Parse(txbSecundario.Text);
                txbSecundario.Text += '+';
                txbResultado.Clear();
                caso = 1;
                click = 1;
            } else
            {
                apresentaErro();
            }

        }

        //Igual
        private void btn_igual_Click(object sender, EventArgs e)
        {   
            if (caso != 0 && txbResultado.Text != string.Empty)
            {
                valor2 = float.Parse(txbResultado.Text);
                txbSecundario.Text += txbResultado.Text;
                calculaNum(caso, valor1, valor2);
                txbResultado.Text = resposta.ToString();
                click = 0;
            }
            else if (caso == 0)
            {
                txbResultado.Text = resposta.ToString();
            } else
            {
                apresentaErro();
            }

        }

        //ElevadoQuadrado;
        private void button23_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text != string.Empty)
            {
                txbSecundario.Text = txbResultado.Text;
                valor1 = float.Parse(txbSecundario.Text);
                txbSecundario.Text += '²';
                txbResultado.Clear();
                if (valor1 > 0)
                {
                    resposta = MathF.Pow(valor1, 2);
                    txbResultado.Text = resposta.ToString();
                    caso = 0;
                } 
                

            } else
            {
                apresentaErro();
            }
        }
    
        //NumeroInverso;
        private void button24_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text != string.Empty)
            {
                txbSecundario.Text = txbResultado.Text;
                valor1 = float.Parse(txbSecundario.Text);
                txbSecundario.Text = "1/" + valor1;
                txbResultado.Clear();
                resposta = 1 / valor1;
                txbResultado.Text = resposta.ToString();
                caso = 0;

            }
            else
            {
                apresentaErro();
            }
        }

        //RaizQuadrada
        private void button22_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text != string.Empty)
            {
                txbSecundario.Text = txbResultado.Text;
                valor1 = float.Parse(txbSecundario.Text);
                txbSecundario.Text = "√" + valor1;
                txbResultado.Clear();
                double result =  Math.Sqrt(Convert.ToDouble(valor1));
                resposta = (float) result;
                txbResultado.Text = resposta.ToString();
                caso = 0;
              

            }
            else
            {
                apresentaErro();
            }
        }

        //Porcentagem
        private void btn_porcentagem_Click(object sender, EventArgs e)
        {
            if (txbResultado.Text != string.Empty && click != 2)
            {
                float valorPercentual = float.Parse(txbResultado.Text) / 100;
                valor2 = valor1 * valorPercentual;
                txbResultado.Text = valor2.ToString();
                click = 2;

            }
            else
            {
                apresentaErro();
            }
        }

        //Buton CE
        private void btn_ce_Click(object sender, EventArgs e)
        {
            resposta = valor1;
            txbResultado.Text = resposta.ToString();
            txbSecundario.Clear();
            caso = 0;

        }

        public float calculaNum (int caso, float valor1, float valor2)
        {
            switch (caso) {
                case 1:
                    resposta = valor1 + valor2;
                    operacao = "+";
                    break;
                case 2:
                    resposta = valor1 - valor2;
                    //operacao = "-";
                    break;
                case 3:
                    resposta = valor1 * valor2;
                    //operacao = "*";
                    break;
                case 4:
                    resposta = valor1 / valor2;
                    //operacao = "/";
                    break;
              
            }
            return resposta;
                
            
        }

        public void apresentaErro ()
        {
            MessageBox.Show("NÃO FOI POSSÍVEL REALIZAR O CALCULO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}