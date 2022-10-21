using System;
using System.IO.Ports;

namespace Course070
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

            serialPort.DataReceived += SerialPort_DataReceived;

            // 清空输入输出缓冲区
            serialPort.DiscardInBuffer();

            serialPort.DiscardOutBuffer();

            serialPort.Open();

            var bytes = new byte[4] { 10, 11, 12, 13 };

            serialPort.Write(bytes, 0, 3);

            Console.Read();

            serialPort.Close();


        }

        private static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = sender as SerialPort;

            var data = new byte[serialPort.BytesToRead];

            serialPort.Read(data, 0, data.Length);

            // 一个一个字节的读取,读取不到会一直卡在这里

            //serialPort.ReadByte();

            Console.WriteLine(string.Join(" ", data));

            Console.WriteLine();

        }
    }
}
