namespace Projeto_ByClaudia
{
    public partial class PrimeiroExemplo : Form
    {
        public PrimeiroExemplo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome;
                nome = txbNome.Text;
                MessageBox.Show("Olá " + nome + ", Estamos verificando seu acesso!", "Boas-vindas", MessageBoxButtons.OK, MessageBoxIcon.Information ) ;
                int num;
                num = Convert.ToInt32(txbNumero.Text);
                int anoAtual = 2022;
                int idade = anoAtual - num;
                if (idade > 18)
                {
                    lbl_Idade.Visible = true;
                    txbIdade.Visible = true;
                    txbIdade.Text = idade.ToString();
                    lbl_Acesso.Visible = true;
                    txbAcesso.Visible = true;
                    txbAcesso.Text = "Acesso Autorizado";
                    txbAcesso.BackColor = Color.Green;
                }
                else
                {
                    lbl_Idade.Visible = true;
                    txbIdade.Visible = true;
                    txbIdade.Text = idade.ToString();
                    lbl_Acesso.Visible = true;
                    txbAcesso.Visible = true;
                    txbAcesso.Text = "Acesso Negado";
                    txbAcesso.BackColor = Color.Red;
                }
            
                
            }
            catch
            {
                MessageBox.Show("Informe um valor válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                num = Convert.ToInt32(txbNumero.Text);
                if (num <= 0)
                {
                    MessageBox.Show("Informou um número inválido");
                }
                else
                {
                    MessageBox.Show("Informou Positivo, o Número é " + num);
                }
            } 
            catch
            {
                MessageBox.Show("Informe um valor válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   try
            {
                string nome;
                nome = txbNome.Text;
                int num;
                num = Convert.ToInt32(txbNumero.Text);
                int anoAtual = 2022;
                int idade = anoAtual - num;
                MessageBox.Show(nome + " possui " + idade + " anos ");
            }
            catch
            {
                MessageBox.Show("Informe um valor válido","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
         }

        private void button2_Click(object sender, EventArgs e)
        {
            txbNome.Text=" ";
            txbNumero.Text=" ";
            txbIdade.Text = " ";
            txbIdade.Visible =false;
            lbl_Idade.Visible = false;
            btn_limpar.Enabled = false;
            txbAcesso.Visible = false;
            lbl_Acesso.Visible=false;
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            btn_limpar.Enabled=true;
        }

        private void txbNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
