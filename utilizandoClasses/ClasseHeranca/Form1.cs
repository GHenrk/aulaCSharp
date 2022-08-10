namespace ClasseHeranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int caso;

        private void Form1_Load(object sender, EventArgs e)
        {
            tornaInvisivel();
            txbFilhos.Text = 0.ToString();
        }

        public void tornaInvisivel()
        {
            //Aluno
            txbMedia.Visible = false;
            lblMedia.Visible = false;
            lblNota1.Visible = false;
            lblNota2.Visible = false;
            lblNota3.Visible = false;
            txbNota1.Visible = false;
            txbNota2.Visible = false;
            txbNota3.Visible = false;
            

            //Professor
            txbSalario.Visible = false;
            lblSalario.Visible = false;
            lblFilhos.Visible = false;
            txbFilhos.Visible = false;
            btnAdicionar.Visible = false;
            btnRemover.Visible = false;
        }

        private void rdBtnProfessor_CheckedChanged(object sender, EventArgs e)
        {
            tornaInvisivel();
            txbSalario.Visible = true;
            lblSalario.Visible = true;
            lblFilhos.Visible=true;
            txbFilhos.Visible = true;
            btnAdicionar.Visible = true;
            btnRemover.Visible = true;

            caso = 1;

        }

        private void rdBtnAluno_CheckedChanged(object sender, EventArgs e)
        {
            tornaInvisivel();
            txbMedia.Visible = true;
            lblMedia.Visible = true;
            lblNota1.Visible = true;
            lblNota2.Visible = true;
            lblNota3.Visible = true;
            txbNota1.Visible = true;
            txbNota2.Visible = true;
            txbNota3.Visible = true;
            caso = 2;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try {
                
                switch (caso)
                {
                    case 1: Professor nvProf = new Professor();
                        if (nvProf.validarCPF(txbCPF2.Text) == true)
                        {
                            lblCPF.Text = "CPF Válido";
                            lblCPF.ForeColor = Color.Green;
                        } else
                        {
                            MessageBox.Show("CPF Inválido, insira novamente!");
                            break;
                        }
                        nvProf.Nome = txbNome.Text;
                        nvProf.Matricula = int.Parse(txbMatricula.Text);
                        nvProf.Salario = double.Parse(txbSalario.Text);
                        nvProf.DataCadastro = DateTime.Now;
                        nvProf.Cpf = txbCPF2.Text;
                        nvProf.NumFilhos = int.Parse(txbFilhos.Text);
                        MessageBox.Show($"Professor(a): {nvProf.Nome} foi cadastrado com sucesso!!! \n Data de Cadastro: {nvProf.DataCadastro.ToString("dd MMMM yyyy")}" +
                            $"\n Mátricula: {nvProf.Matricula}" +
                            $"\n CPF: {nvProf.Cpf}" +
                            $"\n Numero Filhos: {nvProf.NumFilhos}");
                        break;
                    case 2:
                        Aluno nvAluno = new Aluno();
                        if (nvAluno.validarCPF(txbCPF2.Text) == true)
                        {
                            lblCPF.Text = "CPF Válido";
                            lblCPF.ForeColor = Color.Green;
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido, insira novamente!");
                            break;
                        }
                        nvAluno.Nome = txbNome.Text;
                        nvAluno.Matricula = int.Parse(txbMatricula.Text);
                        nvAluno.DataCadastro = DateTime.Now;
                        nvAluno.Nota1 = int.Parse(txbNota1.Text);
                        nvAluno.Nota2 = int.Parse(txbNota2.Text);
                        nvAluno.Nota3 = int.Parse(txbNota3.Text);
                        nvAluno.calcularMedia();
                        txbMedia.Text = nvAluno.Media.ToString("F");
                        MessageBox.Show($"Aluno(a): {nvAluno.Nome} foi cadastrado com sucesso!!! \n Data de Cadastro: {nvAluno.DataCadastro.ToString("dd MMMM yyyy")} \n " +
                            $"Mátricula: {nvAluno.Matricula}" +
                            $"");
                        break;
                }
            } catch
            {
                apresentaErro();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tornaInvisivel();
            txbNome.Clear();
            txbMatricula.Clear();
            txbMedia.Clear();
            txbSalario.Clear();
            txbFilhos.Text = 0.ToString();
            lblCPF.Text = " ";
            txbCPF2.Clear();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int filhos = int.Parse(txbFilhos.Text);
                filhos += 1;
                txbFilhos.Text = filhos.ToString();
            }
            catch
            {
                apresentaErro();
            }
            }

        private void btnRemover_Click(object sender, EventArgs e)
        {   try
            {
                int filhos = int.Parse(txbFilhos.Text);
                filhos -= 1;
                if (filhos <= 0)
                {
                    filhos = 0;
                }
                txbFilhos.Text = filhos.ToString();
            }
            catch
            {
                apresentaErro();
            }

         }

        public void apresentaErro()
        {

            MessageBox.Show("Algo deu errado no cadastro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
