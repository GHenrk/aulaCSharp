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
        List<Carro> listaCarros1;
        List<Moto> listaMotos1;
        List<Barco> listaBarcoes1;
        List<JetSki> listaJetSkis1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Carro> listaCarros, List<Moto> listaMotos, List<Barco> listaBarcoes, List<JetSki> listaJetSkis)
        {
            listaCarros1 = listaCarros;
            listaMotos1 = listaMotos;
            listaBarcoes1 = listaBarcoes;
            listaJetSkis1 = listaJetSkis;
            
        }
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
                case 1:
                    {
                        Carro nvCarro = new Carro();
                        nvCarro.AnoFab = txbAno.Text;
                        nvCarro.Cor = txbCor.Text;
                        nvCarro.Marca = txbMarca.Text;
                        nvCarro.Modelo = txbModelo.Text;
                        nvCarro.Preco = Convert.ToDouble(txbPreco
                            .Text);
                        nvCarro.Proprietario = txbProp.Text;
                        nvCarro.NmrChassi = txbChassi.Text;
                        nvCarro.Placa = txbPlaca.Text;
                        nvCarro.MediaConsumo = float.Parse(txbConsumo.Text);
                        MessageBox.Show($"Veículo de {nvCarro.Proprietario} cadastrado com SUCESSO!!! \n " +
                            $"Modelo: {nvCarro.Modelo} \n Ano Fabricação: {nvCarro.AnoFab}", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listaCarros1.Add(nvCarro);
                        break;
                    }
                //Moto
                case 2:
                    Moto nvMoto = new Moto();
                    nvMoto.AnoFab = txbAno.Text;
                    nvMoto.Cor = txbCor.Text;
                    nvMoto.Marca = txbMarca.Text;
                    nvMoto.Modelo = txbModelo.Text;
                    nvMoto.Preco = Convert.ToDouble(txbPreco
                        .Text);
                    nvMoto.Proprietario = txbProp.Text;
                    nvMoto.NmrChassi = txbChassi.Text;
                    nvMoto.Placa = txbPlaca.Text;
                    nvMoto.MediaConsumo = float.Parse(txbConsumo.Text);
                    MessageBox.Show($"Veículo de {nvMoto.Proprietario} cadastrado com SUCESSO!!! \n " +
                        $"Modelo: {nvMoto.Modelo} \n Ano Fabricação: {nvMoto.AnoFab}", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaMotos1.Add(nvMoto);
                    break;
                //Barcotons.OK,
                case 3:
                    Barco nvBarco = new Barco();
                    nvBarco.AnoFab = txbAno.Text;
                    nvBarco.Cor = txbCor.Text;
                    nvBarco.Marca = txbMarca.Text;
                    nvBarco.Modelo = txbModelo.Text;
                    nvBarco.Preco = Convert.ToDouble(txbPreco
                        .Text);
                    nvBarco.Proprietario = txbProp.Text;
                    nvBarco.NmrInscricao = txbInscricao.Text;
                    MessageBox.Show($"Veículo de {nvBarco.Proprietario} cadastrado com SUCESSO!!! \n " +
                        $"Modelo: {nvBarco.Modelo} \n Ano Fabricação: {nvBarco.AnoFab}", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaBarcoes1.Add(nvBarco);
                    break;
                //JetSky
                case 4:
                    JetSki nvJet = new JetSki();
                    nvJet.AnoFab = txbAno.Text;
                    nvJet.Cor = txbCor.Text;
                    nvJet.Marca = txbMarca.Text;
                    nvJet.Modelo = txbModelo.Text;
                    nvJet.Preco = Convert.ToDouble(txbPreco
                        .Text);
                    nvJet.Proprietario = txbProp.Text;
                    nvJet.NmrInscricao = txbInscricao.Text;
                    MessageBox.Show($"Veículo de {nvJet.Proprietario} cadastrado com SUCESSO!!! \n " +
                        $"Modelo: {nvJet.Modelo} \n Ano Fabricação: {nvJet.AnoFab}", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaJetSkis1.Add(nvJet);
                    break;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           
            Form1 um =  new Form1();
            um.listas(listaCarros1, listaMotos1, listaBarcoes1, listaJetSkis1);
            this.Close();
        }

        private void txbAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpAqua_Enter(object sender, EventArgs e)
        {

        }
    }
}
