using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Course069
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            var serialPort = new SerialPort("COM1",9500, Parity.None,8, StopBits.One);

            serialPort.Open();

            serialPort.Write("Hello");

            serialPort.Close();
        }

    }
}
