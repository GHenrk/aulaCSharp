using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Produto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void propriedades(string nome, string endereco, string contato, DateTime data, double limite, string numCartao, string status)
        {
            txbNome1.Text = "Nome: " + nome;
            txbEndereco1.Text = "Endereço: " + endereco;
            txbContato1.Text = "Contato: "+ contato;
            DtNasc.Value = data;
            txbLimite1.Text = "Limite: "+limite.ToString();
            txbNumCartao1.Text = "Numero Cartão: " + numCartao;

            if (status == "Aprovado")
            {
                txbStatus.Text = status;
                txbStatus.ForeColor = Color.Green;
            } else
            {
                txbStatus.Text = status;
                txbStatus.ForeColor = Color.Red;
            }


        }

        private void DtNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
