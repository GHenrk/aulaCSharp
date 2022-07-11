namespace Exemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            // Close(); //Serve para fechar uma janela;
            Application.Exit(); //Serve para encerrar o programa;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.Show(); //Permite navegacao entre as telas
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            tres.ShowDialog(); //Não deixa trocar de tela
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chevetteHatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.Show(); //Permite navegacao entre as telas
        }

        private void chevetteSedanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            tres.ShowDialog(); //Não deixa trocar de tela
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void aplicativosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}