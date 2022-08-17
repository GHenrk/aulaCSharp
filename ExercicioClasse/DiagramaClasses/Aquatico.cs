using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClasses
{
    public class Aquatico : Veiculo
    {
        private string nmrInscricao;

        public string NmrInscricao { get => nmrInscricao; set => nmrInscricao = value; }
    }
}