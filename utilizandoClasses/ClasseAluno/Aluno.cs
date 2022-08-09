using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAluno
{
    internal class Aluno
    {

        private string nome;
        private string endereco;
        DateTime dataNasc;
        private float nota1;
        private float nota2;
        private float nota3;
        private string situacao;
        private Boolean status;
        private float notaFinal;
        
        //MetodoConstutor
        public Aluno()
        {
            this.nome = " ";
            this.endereco = " ";
            this.dataNasc = DateTime.Today;
            this.nota1 = 0;
            this.nota2 = 0;
            this.nota3 = 0;
            this.situacao = " ";
            this.status = false;
            this.notaFinal = 0;
           
        }

        //Métodos set e gets;
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public float Nota1 { get => nota1; set => nota1 = value; }
        public float Nota2 { get => nota2; set => nota2 = value; }
        public float Nota3 { get => nota3; set => nota3 = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public bool Status { get => status; set => status = value; }
        public float NotaFinal { get => notaFinal; set => notaFinal = value; }

        //outrosMetodos
        public void calcularMedia()
        {
            float soma = this.nota1 + this.nota2 + this.nota3;
            int notas = 3;
            float media = soma / notas;
            this.notaFinal = media;
            if (media > 7)
            {
                this.situacao = "APROVADO!";
                this.status = true;
                
            }
            else
            {
                this.situacao = "REPROVADO";
                this.status = false;
            }
        } 




       


    }
}
