using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecTech.Domain.Models
{
    public class BicoInjetor : Atuador
    {
        public double tempoInjecao {  get; set; }

        public override void acionar(double tempo)
        {
            this.tempoInjecao = tempo;
        }
    }
}
