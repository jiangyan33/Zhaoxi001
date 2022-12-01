using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;

namespace Course071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }

        private static void Test1()
        {
            Console.WriteLine("Hello World!");

            #region 服务端
            //// 本地地址+端口
            //socket.Bind(new IPEndPoint(IPAddress.Any, 9090));

            //// 连接排队的数量，等待接受连接的最大数量
            //socket.Listen(5);

            //Console.WriteLine("服务监听已经启动");

            #endregion
            #region 客户端

            // 接收超时时间，超过一定的时候时会报错，需要设置TryCatch
            //socket.ReceiveTimeout = 5000;

            //socket.Connect(new IPEndPoint(IPAddress.Parse("192.168.8.119"), 8080));

            ////var bytes = Encoding.UTF8.GetBytes("zhaoxijiaoyu");

            ////socket.Send(bytes);

            //byte[] buffer = new byte[] { 0x97, 0x07, 0x01, 0x04, 0x00, 0x0F, 0x00, 0x01, 0x00, 0x01, 0x01, 0x00, 0x0D };


            //for (var i = 1; i < 5; i++)
            //{
            //    socket.Send(buffer);

            //    Thread.Sleep(1000);
            //}

            //try
            //{
            //    socket.Receive(buffer);

            //    Console.WriteLine(Encoding.UTF8.GetString(buffer));

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region 客户端断线重连

            // 这样设置的是TCP服务
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.ReceiveTimeout = 5000;
            try
            {
                socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8087));
            }
            catch
            {

            }


            //一直请求某一个命令，使用心跳处理（超时时间）


            // 保留最后一次操作是的状态，不是实时状态
            Console.WriteLine(socket.Connected);

            while (true)
            {

                // 上位机直连PCL,判断检查状态
                //var state = !(!socket.Connected || (socket.Poll(1, SelectMode.SelectRead) && socket.Poll(1, SelectMode.SelectError) && socket.Available == 0));

                // tcp直连 通过这种方式判断，中间经过路由器需要通过心跳包处理

                var state = true;

                try
                {

                    var bytes = new byte[] { 0x97, 0x07, 0x01, 0x04, 0x00, 0x0F, 0x00, 0x01, 0x00, 0x01, 0x01, 0x00, 0x0D };

                    var num = socket.Send(bytes);

                    state = true;
                }
                catch (Exception ex)
                {
                    state = false;
                }

                if (state)
                {
                    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "tcp连接正常" + state);

                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "检测到tcp服务断开，15s后触发重连" + state);

                    Thread.Sleep(15000);

                    try
                    {
                        //socket.Shutdown(SocketShutdown.Both);

                        socket.Dispose();

                        socket = null;

                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                        socket.ReceiveTimeout = 5000;

                        socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8087));

                        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "tcp重连成功");
                    }
                    catch (Exception ex)
                    {

                        //socket.Disconnect(true);

                        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "tcp重连失败");
                    }

                }
            }


            #endregion
            Console.ReadLine();

            socket.Shutdown(SocketShutdown.Both);

            socket.Dispose();
        }
    }
}