namespace ClasseAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Aluno nvAluno = new Aluno();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            try
            {

                string nome = txbNome.Text;
                string endereco = txbEndereco.Text;
                DateTime dataNascimento = DateTime.Parse(mkTxbDt.Text) ;
                //string dataFormatada = dataNascimento.ToString("dd MMMM yyyy");
                float nt1 = float.Parse(txbNota1.Text);
                float nt2 = float.Parse(txbNota2.Text);
                float nt3 = float.Parse(txbNota3.Text);

                nvAluno.Nome = nome;
                nvAluno.Endereco = endereco;
                nvAluno.DataNasc = dataNascimento;
                nvAluno.Nota1 = nt1;
                nvAluno.Nota2 = nt2;
                nvAluno.Nota3 = nt3;

               
                MessageBox.Show($"Aluno Cadastrado: {nvAluno.Nome} \n Data de Nascimento: {nvAluno.DataNasc.ToString("dd MMMM yyyy")}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Algo deu errado, por favor, verifique os dados inseridos!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                mostraElementos();
                nvAluno.calcularMedia();

                txbInfo.Text = $"{nvAluno.Nome}";
                txbSituacao.Text = $"{nvAluno.Situacao}";
                txbMedia.Text = $"Nota Final: {nvAluno.NotaFinal.ToString("F")}";
                if (nvAluno.Status == true)
                {
                    txbSituacao.ForeColor = Color.Green;
                }
                else
                {
                    txbSituacao.ForeColor = Color.Red;
                }
            } catch
            {
                MessageBox.Show("Algo deu errado, tente novamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbEndereco.Clear();
            txbNota1.Clear();
            txbNota2.Clear();
            txbNota3.Clear();
            txbSituacao.Clear();
            txbInfo.Clear();
            txbMedia.Clear();
            gpBoxInfo.Visible = false;
        }

        public void mostraElementos()
        {
            gpBoxInfo.Visible = true;
        }

      
    }
}