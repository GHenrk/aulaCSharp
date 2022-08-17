using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramaClasses
{
    public partial class Form3 : Form
    {

        //CriaListas;
        public List<Carro> listaCarros;
        public List<Moto> listaMotos;
        public List<Barco> listaBarcoes;
        public List<JetSki> listaJetSkis;
        
        public Form3()
        {
            InitializeComponent();

        }
       

        public void recebeListas(List<Carro> paramCarro, List<Moto> paramMoto, List<Barco> paramBarco, List<JetSki> paramJet)
        {
                
                listaCarros = paramCarro;
                listaMotos = paramMoto;
                listaBarcoes = paramBarco;
                listaJetSkis = paramJet;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCarro_Click(object sender, EventArgs e)
        {   
           
            for (var i = 0; i<listaCarros.Count; i++)
            {
                string marca = listaCarros[i].Marca;
                string modelo = listaCarros[i].Modelo;
                string proprietario = listaCarros[i].Proprietario;
                double valor = listaCarros[i].Preco;
                string anoFab = listaCarros[i].AnoFab;
                MessageBox.Show(marca, proprietario);
                dtGrid.Rows.Add(marca, modelo, proprietario, valor.ToString(), anoFab);
            }
                
            
        }
    }
}
