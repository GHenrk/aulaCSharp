namespace DiagramaClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tipo= 0;

        private void rdTerrestre_CheckedChanged(object sender, EventArgs e)
        {
            cbOpcoes.Items.Clear();
            cbOpcoes.Text = " ";
            cbOpcoes.Items.Add("Carro");
            cbOpcoes.Items.Add("Moto");
            tipo = 1;
        }

        private void rdAqua_CheckedChanged(object sender, EventArgs e)
        {
            cbOpcoes.Items.Clear();
            cbOpcoes.Text = " ";
            cbOpcoes.Items.Add("Barco");
            cbOpcoes.Items.Add("JetSki");
            tipo = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipoVeiculo = cbOpcoes.Text;
            if (cbOpcoes.Text == " ")
            {
                MessageBox.Show("Por favor, selecione o veículo");
            }
            else
            {
                //Cria o form;
                Form2 dois = new Form2();
                //PassaOsParametrosParaFuncao;
                dois.propriedades(tipo, tipoVeiculo);
                //MostraFormulario2;
                dois.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}