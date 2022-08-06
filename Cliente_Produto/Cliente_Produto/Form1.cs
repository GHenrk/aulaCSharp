namespace Cliente_Produto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente novoCliente = new Cliente();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txbNome.Text.ToString();
                string endereco = txbEndereco.Text.ToString();
                string contato = txbContato.Text.ToString();
                DateTime data = dtNasc.Value;
                double limite = double.Parse(txbLimite.Text);
                string numCartao = txbNumCartao.Text;

                novoCliente.setNome(nome);
                novoCliente.setEndereco(endereco);
                novoCliente.setContato(contato);
                novoCliente.setDataNasc(data);
                novoCliente.setLimiteCredito(limite);
                novoCliente.setNumeroCartao(numCartao);

                //Mostra Aviso
                MessageBox.Show("Cliente cadastrado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //VerificaLimite
                novoCliente.verificaLimite();

                //MostraAvisoLimite
               // MessageBox.Show("STATUS: " + novoCliente.getStatus(), "ATENÇÃO", MessageBoxButtons.OK);

                //recebe os dados;
                nome = novoCliente.getNome();
                endereco = novoCliente.getEndereco();
                contato = novoCliente.getContato();
                data = novoCliente.getDataNasc();
                limite = novoCliente.getLimiteCredito();
                numCartao = novoCliente.getNumeroCartao();
                string status = novoCliente.getStatus();
                
                //ConstroiForm2;
                Form2 dois = new Form2();
                //PassaOsParametrosParaFuncao;
                dois.propriedades(nome, endereco, contato, data, limite, numCartao, status);
                //MostraFormulario2;
                dois.Show();
               

            }
            catch
            {
                MessageBox.Show("Algo deu errado, por favor tente novamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
            
        }
    }
}