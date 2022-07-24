namespace ExerciciosClaudia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            try
            {
                float txb1, txb2, txb3;
                txb1 = float.Parse(txbNum1.Text);
                txb2 = float.Parse(txbNum2.Text);
                txb3 = float.Parse(txbNum3.Text);
                var minhaLista = new List<float> { txb1, txb2, txb3 };
                minhaLista.Sort();
                txbMaior.Text = $"O N�mero maior � {minhaLista[minhaLista.Count - 1].ToString()}";
                txbMenor.Text = $"O N�mero menor � {minhaLista[0].ToString()}";
                txbMaior.ForeColor = Color.Green;
                txbMenor.ForeColor = Color.Red;

            }
            catch
            {
                MessageBox.Show("Por favor insira um n�mero v�lido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbMaior.Clear();
            txbMenor.Clear();
            txbNum1.Clear();
            txbNum2.Clear();
            txbNum3.Clear();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}