using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecTech.Domain.Models
{
    public class SensorTemperatura : Sensor
    {
        private const double TemperaturaMin = -40.0;   
        private const double TemperaturaMax = 130.0;

        public override void atualizar(double novoValor)
        {
            if (novoValor < TemperaturaMin)
                Valor = TemperaturaMin;
            else if (novoValor > TemperaturaMax)
                Valor = TemperaturaMax;
            else
                Valor = novoValor;
        }
    }
}
