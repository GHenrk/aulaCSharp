namespace DiagramaClasses
{
    public partial class Form1 : Form
    {

        int tipo = 0;
        public List<Carro> listaCarros = new List<Carro>();
        public List<Moto> listaMotos = new List<Moto>();
        public List<Barco> listaBarcoes = new List<Barco>();
        public List<JetSki> listaJetSkis = new List<JetSki>();
        public Form1()
        {
            InitializeComponent();
        }
        

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

        public void listas(List<Carro> paramCarro, List<Moto> paramMoto, List<Barco> paramBarco, List<JetSki> paramJet)
        {
            listaCarros = paramCarro;
            listaMotos = paramMoto;
            listaBarcoes = paramBarco;
            listaJetSkis = paramJet;
        }

        private void btnVisualize_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listaCarros[0].Proprietario);
            Form3 tres = new Form3();
            tres.recebeListas(listaCarros, listaMotos, listaBarcoes, listaJetSkis);
            
            tres.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}