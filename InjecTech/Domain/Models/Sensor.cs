using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecTech.Domain.Models
{
    public abstract class Sensor
    {
        public double Valor {  get; set; }

        public abstract void atualizar(double novoValor);


    }
}
