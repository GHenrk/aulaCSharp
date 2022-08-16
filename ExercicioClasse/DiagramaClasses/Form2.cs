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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Carro> listaCarros = new List<Carro>();
        List<Moto> listaMotos = new List<Moto>();
        List<Barco> listaBarcoes = new List<Barco>();
        List<JetSki> listaJetSkis = new List<JetSki>();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        string tipoDeVeiculo;
        int caso;

        public void propriedades(int tipo, string tipoVeiculo)
        {   
            lblPrincipal.Text = $"Cadastro de {tipoVeiculo}";
             if (tipo == 1)
            {
                gpAqua.Visible = false;
                gpTerrestre.Visible = true;
                tipoDeVeiculo = tipoVeiculo;
            } else
            {
                gpAqua.Visible = true;
                gpTerrestre.Visible = false;
                tipoDeVeiculo = tipoVeiculo;
            }
            verificaVeiculo(tipoVeiculo);
        }

        public void verificaVeiculo ( string tipoVeiculo)
        {
            if (tipoVeiculo == "Carro")
            {
                caso = 1;
            } else if (tipoVeiculo == "Moto")
            {
                caso = 2;
            } else if (tipoVeiculo == "Barco")
            {
                caso = 3;
            } else if (tipoVeiculo == "JetSki")
            {
                caso = 4;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            switch (caso)
            {
                //Carro
                case 1: Carro nvCarro = new Carro();
                    nvCarro.AnoFab = txbAno.Text;
                    MessageBox.Show($"O Ano de fabricacao é {nvCarro.AnoFab}");

                       break;     
                //Moto
                case 2:

                    break;
                //Barco
                case 3:


                    break;
                //JetSky
                case 4:

                    break;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
