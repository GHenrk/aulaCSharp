using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClasses
{
    public class Terrestre : Veiculo
    {
        private string placa;

        private string nmrChassi;

        private float mediaConsumo;

        public string Placa { get => placa; set => placa = value; }
        public string NmrChassi { get => nmrChassi; set => nmrChassi = value; }
        public float MediaConsumo { get => mediaConsumo; set => mediaConsumo = value; }

        public void verificarCombustivel()
        {
            
        }
    }
}