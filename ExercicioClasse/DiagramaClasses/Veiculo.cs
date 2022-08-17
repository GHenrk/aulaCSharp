using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClasses
{
    public class Veiculo
    {

        private string modelo;


        private string marca;


        private string cor;


        private string proprietario;

        private string anoFab;


        private double preco;

        public string AnoFab { get => anoFab; set => anoFab = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Proprietario { get => proprietario; set => proprietario = value; }
        public double Preco { get => preco; set => preco = value; }

        public string consultaProp()
        {
            return this.Proprietario;
        }
    }
}