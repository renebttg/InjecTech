using InjecTech.Domain.Core;
using InjecTech.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InjecTech.View
{
    /// <summary>
    /// Lógica interna para InjectSimView.xaml
    /// </summary>
    public partial class InjectSimView : Window
    {
        private readonly SensorRPM _sensorRPM = new SensorRPM();
        private readonly SensorTemperatura _sensorTemp = new SensorTemperatura();
        private readonly SensorTPS _sensorTPS = new SensorTPS();
        private readonly SensorOxigenio _sensorO2 = new SensorOxigenio();
        private readonly BicoInjetor _bico = new BicoInjetor();
        private readonly ECU _ecu;


        public InjectSimView()
        {
            InitializeComponent();
            _ecu = new ECU(_sensorRPM, _sensorTemp, _sensorTPS, _sensorO2, _bico);
        }

        private void BtnProcessar_Click(object sender, RoutedEventArgs e)
        {
            
            _sensorRPM.Valor = SliderRPM.Value;
            _sensorTemp.Valor = SliderTemp.Value;
            _sensorTPS.Valor = SliderTPS.Value;
            _sensorO2.Valor = SliderO2.Value;

            _ecu.processar();

            TxtStatus.Text = _ecu.Status();

            string mistura = _ecu.Mistura();
            TxtMistura.Text = "Mistura: " + mistura;

            switch (mistura)
            {
                case "Pobre":
                    TxtMistura.Foreground = Brushes.Red;
                    break;
                case "Rica":
                    TxtMistura.Foreground = Brushes.Goldenrod;
                    break;
                case "Estequiométrica":
                    TxtMistura.Foreground = Brushes.Green;
                    break;
                default:
                    TxtMistura.Foreground = Brushes.Black;
                    break;
            }
        }
    }
}
