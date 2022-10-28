using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Course072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region 异步读写TCP

            //var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6666));

            //AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            //var msg = "Hello";

            //var data = Encoding.UTF8.GetBytes(msg);
            //// 这里会卡线程
            //var state = socket.BeginSend(data, 0, data.Length, SocketFlags.None,
            //    new AsyncCallback(ret =>
            //    {
            //        // 发送完成之后出发回调
            //        try
            //        {
            //            socket.EndSend(ret);

            //            var bytes = new byte[1024];

            //            while (true)
            //            {
            //                // 接收
            //                var s = socket.BeginReceive(bytes, 0, bytes.Length, SocketFlags.None, (ret) =>
            //                  {
            //                      socket.EndReceive(ret);

            //                      autoResetEvent.Set();
            //                  }, null);

            //                // 用作超时处理,5s处理不完就会超时 这里有问题
            //                var t = s.AsyncWaitHandle.WaitOne(5000);

            //                if (!t) Console.WriteLine("接收超时");
            //                else
            //                    break;
            //            }

            //            autoResetEvent.WaitOne();

            //            Console.WriteLine("接收成功" + Encoding.UTF8.GetString(bytes));

            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }

            //    }), null);

            //Console.ReadLine();

            //socket.Shutdown(SocketShutdown.Both);

            //socket.Dispose();

            #endregion

            #region Sokcet UDP

            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            // 指定端口号
            socket.Bind(new IPEndPoint(IPAddress.Any, 9009));

            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);

            // 消息会往指定的ip+port中发送。
            //socket.SendTo(new byte[] { 01, 02 }, new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6666));
            // 面向广播，当前局域网内部所有的6666端口,  127.0.0.1 不好用，用内网地址或者0.0.0.0
            socket.SendTo(new byte[] { 01, 02 }, new IPEndPoint(IPAddress.Parse("255.255.255.255"), 6666));

            var bytes = new byte[1024];

            EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);

            socket.ReceiveFrom(bytes, ref endPoint);

            Console.WriteLine(bytes[0]);
            #endregion
            Console.ReadLine();

            socket.Shutdown(SocketShutdown.Both);

            socket.Dispose();
        }
    }
}
