using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseHeranca
{
    internal class Professor:Pessoa
    {
        private double salario;
        private int numFilhos;

        public double Salario { get => salario; set => salario = value; }
        public int NumFilhos { get => numFilhos; set => numFilhos = value; }


       
    }
}
