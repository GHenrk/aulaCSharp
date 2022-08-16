using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClasses
{
    public class Veiculo
    {

        public string Modelo
        {
            get => default;
            set
            {
            }
        }

        public string Marca
        {
            get => default;
            set
            {
            }
        }

        public string Cor
        {
            get => default;
            set
            {
            }
        }

        public string Proprietario
        {
            get => default;
            set
            {
            }
        }

        public string AnoFab
        {
            get => default;
            set
            {
            }
        }

        public double Preco
        {
            get => default;
            set
            {
            }
        }



        public string consultaProp()
        {
            return this.Proprietario;
        }
    }
}