using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Course071
{
    public class ListenThread
    {
        public void run()
        {
            Console.Write("creating listen socket ...");
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenSocket.Bind(new IPEndPoint(IPAddress.Any, 65365));
            listenSocket.Listen(0);
            Console.Write("    done.\n");

            try
            {
                Console.Write("listening ...");
                ioSocket = listenSocket.Accept();
                Console.Write("    accepted.\n");

                Console.Write("creating I/O thread ...");
                // new Thread(new ThreadStart(this.networkIOThreadProc)).Start();
                Console.Write("    done.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Thread aborted.");
            }
            finally
            {
                Console.WriteLine("Thread resource released.");
            }
        }

        public void stop()
        {
            if (listenSocket != null)
            {
                listenSocket.Close();
            }
        }

        private Socket listenSocket = null;
        private Socket ioSocket = null;

    }
}
