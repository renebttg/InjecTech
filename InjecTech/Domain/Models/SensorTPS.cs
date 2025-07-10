using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecTech.Domain.Models
{
    public class SensorTPS : Sensor
    {
        private const double TPSMin = 0.0;    
        private const double TPSMax = 100.0;

        public override void atualizar(double novoValor)
        {
            if (novoValor < TPSMin)
                Valor = TPSMin;
            else if (novoValor > TPSMax)
                Valor = TPSMax;
            else
                Valor = novoValor;
        }
    }
}
