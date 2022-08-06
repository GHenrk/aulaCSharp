using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente_Produto
{
    internal class Cliente
    {
        //Atributos da Classe;
        private string nome;
        private string endereco;
        private string contato;
        DateTime dataNasc;
        private double limiteCredito;
        private string numeroCartao;
        private string status;

        //metodoConstrutor; 
        public Cliente()
        {
            this.nome = " ";
            this.endereco = " ";
            this.contato = " ";
            this.limiteCredito = ' ';
            this.numeroCartao = " ";
            dataNasc = DateTime.Today;
        }

        //metodoSet's
        public void setNome(string paramNome)
        {
            this.nome = paramNome;
        }
        
        public void setEndereco(string paramEndereco)
        {
            this.endereco = paramEndereco;
        }
        
        public void setContato(string paramContato)
        {
            this.contato =paramContato;
        }
        
        public void setLimiteCredito(double paramLimiteCredito)
        {
            this.limiteCredito = paramLimiteCredito;
        }
        
        public void setNumeroCartao(string paramNumeroCartao)
        {
            this.numeroCartao = paramNumeroCartao;
        }

        public void setDataNasc(DateTime paramDataNasc)
        {
            this.dataNasc = paramDataNasc;
        }


        //metodosGet's
        public string getNome()
        {
            return this.nome;
        }
        public string getEndereco()
        {
            return this.endereco;
        }
        public string getContato()
        {
            return this.contato;
        }
        public double getLimiteCredito()
        {
            return this.limiteCredito;
        }
        public string getNumeroCartao()
        {
            return this.numeroCartao;
        }

        public string getStatus()
        {
            return this.status;
        }

        public DateTime getDataNasc()
        {
            return this.dataNasc;
        }

          //MetodoVerificaLimite

        public void verificaLimite()
        {
            if(this.limiteCredito < 1000)
            {
                this.status = "Bloqueado";
            } else {
                this.status = "Aprovado";
            }
        }
    }

 }
