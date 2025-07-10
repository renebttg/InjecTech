using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecTech.Domain.Models
{
    public class SensorOxigenio : Sensor
    {
        private const double LambdaMin = 0.7;  
        private const double LambdaMax = 1.3;  

        public override void atualizar(double novoValor)
        {
            if (novoValor < LambdaMin)
                Valor = LambdaMin;
            else if (novoValor > LambdaMax)
                Valor = LambdaMax;
            else
                Valor = novoValor;
        }
    }
}
