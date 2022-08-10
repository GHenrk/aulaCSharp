using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseHeranca
{
    internal class Aluno:Professor  
    {
        private float nota1;
        private float nota2;
        private float nota3;
        private float media;

        public float Media { get => media; set => media = value; }
        public float Nota1 { get => nota1; set => nota1 = value; }
        public float Nota2 { get => nota2; set => nota2 = value; }
        public float Nota3 { get => nota3; set => nota3 = value; }


        public void calcularMedia()
        {
            float soma = this.nota1 + this.nota2 + this.nota3;
            this.media = soma / 3;
        }
    }
}
