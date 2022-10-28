using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Course073
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region TCPListener

            //var tcpListener = new TcpListener(IPAddress.Parse("0.0.0.0"), 9090);

            //tcpListener.Start();

            //var client = tcpListener.AcceptSocket();

            //client.Send(Encoding.UTF8.GetBytes("Hello"), SocketFlags.None);

            //tcpListener.Server.Send(Encoding.UTF8.GetBytes("Hello"), SocketFlags.None);

            //tcpListener.Server.Shutdown(SocketShutdown.Both);

            //tcpListener.Server.Dispose();


            #endregion


            #region TCPClient

            // 有同步异步方法

            //var tcpClient = new TcpClient();

            //tcpClient.ReceiveTimeout = 5000;

            //tcpClient.Connect("127.0.0.1", 9090);

            //var stream = tcpClient.GetStream();

            //stream.Write(Encoding.UTF8.GetBytes("Hello"));

            //var bytes = new byte[4];

            //stream.Read(bytes);

            //Console.WriteLine(Encoding.UTF8.GetString(bytes));

            //tcpClient.Close();

            #endregion


            #region UdpClient

            var udpClient = new UdpClient();

            udpClient.Send(Encoding.UTF8.GetBytes("Hello"), 5, "192.168.0.168", 6666);

            #endregion


            Console.ReadLine();
        }
    }
}
