using InjecTech.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecTech.Domain.Core
{
    public class ECU
    {
        private readonly SensorRPM _sensorRPM;
        private readonly SensorTemperatura _sensorTemp;
        private readonly SensorTPS _sensorTPS;
        private readonly SensorOxigenio _sensorO2;
        private readonly BicoInjetor _bico;



        public ECU(SensorRPM sensorRPM, SensorTemperatura sensorTemp, SensorTPS sensorTPS, SensorOxigenio o2, BicoInjetor bico)
        {
            _sensorRPM = sensorRPM;
            _sensorTemp = sensorTemp;
            _sensorTPS = sensorTPS;
            _sensorO2 = o2;
            _bico = bico;
        }

        public void processar()
        {
            double rpm = _sensorRPM.Valor;
            double temp = _sensorTemp.Valor;
            double tps = _sensorTPS.Valor;

            double tempoInjecao = (rpm / 1000) * (1 + (tps / 100.0)) * (temp > 80 ? 0.9 : 1.2);

            _bico.acionar(tempoInjecao);
        }

        public String Status()
        {
            return string.Format(
                "RPM: {0:0}\nTemp: {1:0.0}°C\nTPS: {2:0}%\nInjeção: {3:0.00}ms",
                 _sensorRPM.Valor,
                 _sensorTemp.Valor,
                 _sensorTPS.Valor,
                 _bico.tempoInjecao
            );
        }

        public string Mistura()
        {
            double lambda = _sensorO2.Valor;

            if (lambda < 0.98)
                return "Rica";
            else if (lambda > 1.02)
                return "Pobre";
            else
                return "Estequiométrica";
        }


        public double TempoInjecao()
        {
            return _bico.tempoInjecao;
        }
    }

}
