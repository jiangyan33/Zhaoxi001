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

            var bytes1 = new byte[] { 0x67, 0x30, 0x2E, 0x74, 0x78, 0x74, 0x3D, 0x22, 0xC4, 0xE3, 0xBA, 0xC3, 0x22, 0xFF, 0xFF, 0xFF };

            //var msg = "g0.txt=\"你好\"";

            var ss = BytesToString(bytes1);

            var data = Encoding.ASCII.GetString(bytes1);

            //System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");
            //byte[] bytes = chs.GetBytes(msg);
            //return BytesToHexStr(bytes, seprator);

            //var aa = "0x0F";

            //byte aa = "0x0F";

            //var sss = Convert.ToInt32(aa);

            //var res = 15.ToString("X2");

            //var ss = byte.Parse("0x" + res);

            var rr = StringToBytes("你好");


            Console.WriteLine("Hello World!");

            #region 异步读写TCP

            //var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6666));

            //AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            //var msg = "Hello";

            //var data = Encoding.UTF8.GetBytes(msg);
            //// 这里会卡线程，Framework框架没有问题。netCore不行
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

        private static byte[] StringToBytes(string TheString)
        {
            Encoding fromEcoding = Encoding.GetEncoding("UTF-8");//返回utf-8的编码

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding toEcoding = Encoding.GetEncoding(0);

            byte[] fromBytes = fromEcoding.GetBytes(TheString);
            byte[] tobytes = Encoding.Convert(fromEcoding, toEcoding, fromBytes);//将字节数组从一种编码转换为另一种编码
            return tobytes;

        }
        //将GB2312编码转换成汉字
        private static string BytesToString(byte[] bytes)
        {
            string myString;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Encoding fromEcoding = Encoding.GetEncoding(0);

            Encoding toEcoding = Encoding.GetEncoding("UTF-8");
            byte[] toBytes = Encoding.Convert(fromEcoding, toEcoding, bytes);
            myString = toEcoding.GetString(toBytes);//将字节数组解码成字符串
            return myString;
        }
    }
}
