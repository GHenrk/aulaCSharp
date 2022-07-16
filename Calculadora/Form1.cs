namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            
        }

        //VariaveisGlobais;
        float valor1, resposta;
        int caso;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '.';
        }

       

        private void button16_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '4';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
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

        private void btn_menos_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '-';
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '*';
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            txbResultado.Text += '/';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txbResultado.Text = " ";
            txbSecundario.Text = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txbSecundario.Text = txbResultado.Text;
            valor1 = float.Parse(txbSecundario.Text);
            txbSecundario.Text += '+';
            txbResultado.Text = " ";
            caso = 1;

        }


        private void btn_igual_Click(object sender, EventArgs e)
        {
            calculaNum(caso);
        }

        public void calculaNum (int caso)
        {
            switch (caso) {
                case 1:
                    txbSecundario.Text += txbResultado.Text;
                    resposta = valor1 + float.Parse(txbResultado.Text);
                    txbResultado.Text = resposta.ToString();
                    break;
            }
        }
    }
}