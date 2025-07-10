using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecTech.Domain.Models
{
    public class SensorRPM : Sensor
    {
        public override void atualizar(double novoValor)
        {
            this.Valor = Math.Max(0, Math.Min(novoValor, 7000));
        }
    }
}
