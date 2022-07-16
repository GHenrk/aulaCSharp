namespace Mini_Calculadora
{
    public partial class MiniCalc : Form
    {
        public MiniCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbNum1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txbNum2_TextChanged(object sender, EventArgs e)
        {
            if ((txbNum1.Text != string.Empty) && (txbNum2.Text != string.Empty)) {
                btnDividir.Enabled = true;
                btnMais.Enabled = true;
                btnMenos.Enabled = true;
                btnMultiplicar.Enabled = true;
            }
        }

        private void txbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            float num1, num2, resultado;
            num1 = float.Parse(txbNum1.Text);
            num2 = float.Parse(txbNum2.Text);
            resultado = num1 + num2;
            txbResultado.Text = resultado.ToString();
            if (resultado >= 0)
            {
                txbResultado.BackColor = Color.Green;
                txbResultado1.Text = "Resultado positivo";
            }
            else
            {
                txbResultado.BackColor = Color.Red;
                txbResultado1.Text = "Resultado negativo";
            }
            DateTime data = DateTime.Now;
            lblData.Text = "Este resultado foi gerado em:" + data.ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            float num1, num2, resultado;
            num1 = float.Parse(txbNum1.Text);
            num2 = float.Parse(txbNum2.Text);
            resultado = num1 - num2;
            txbResultado.Text = resultado.ToString();
            if (resultado >= 0)
            {
                txbResultado.BackColor = Color.Green;
                txbResultado1.Text = "Resultado positivo";
            }
            else
            {
                txbResultado.BackColor = Color.Red;
                txbResultado1.Text = "Resultado negativo";
            }
            DateTime data = DateTime.Now;
            lblData.Text = "Este resultado foi gerado em: " + data.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            float num1, num2, resultado;
            num1 = float.Parse(txbNum1.Text);
            num2 = float.Parse(txbNum2.Text);
            resultado = num1 * num2;
            if (resultado >= 0)
            {
                txbResultado.Text = resultado.ToString();
                txbResultado.BackColor = Color.Green;
                txbResultado1.Text = "Resultado positivo";
            } else
            {
                txbResultado.Text = resultado.ToString();
                txbResultado.BackColor = Color.Red;
                txbResultado1.Text = "Resultado negativo";
            }
            DateTime data = DateTime.Now;
            lblData.Text = "Este resultado foi gerado em: " + data.ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float num1, num2, resultado;
            num1 = float.Parse(txbNum1.Text);
            num2 = float.Parse(txbNum2.Text);
            resultado =num1/num2;
            txbResultado.Text = resultado.ToString();
            if (resultado >= 0)
            {
                txbResultado.BackColor = Color.Green;
                txbResultado1.Text = "Resultado positivo";
            }
            else
            {
                txbResultado.BackColor = Color.Red;
                txbResultado1.Text = "Resultado negativo";
            }
            DateTime data = DateTime.Now;
            lblData.Text = "Este resultado foi gerado em: " + data.ToString();
        }

        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbResultado.Text = " ";
            txbNum1.Text = " ";
            txbNum2.Text = " ";
            txbResultado.BackColor = Color.White;
            txbResultado1.Text = "";
            lblData.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MiniCalc_Load(object sender, EventArgs e)
        {

        }

        private void txbResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}