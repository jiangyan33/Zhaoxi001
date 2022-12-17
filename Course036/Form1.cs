using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"btnSync_Click Start{Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss fff")}");

            for (var i = 0; i < 5; i++)
            {
                DoSomethingLong("btnSync_Click" + i);
            }

            Console.WriteLine($"btnSync_Click End{Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss fff")}");
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"btnAsync_Click Start{Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss fff")}");

            var action = new Action<string>(DoSomethingLong);

            for (var i = 0; i < 5; i++)
            {
                action.BeginInvoke("btnSync_Click" + i, null, null); // 开启一个线程去完成任务
            }
            Console.WriteLine($"btnAsync_Click End{Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss fff")}");

        }

        private void DoSomethingLong(string name)
        {
            Console.WriteLine($"DoSomethingLong Start {name}{Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss fff")}");

            Thread.Sleep(2000);

            Console.WriteLine($"DoSomethingLong End {name}{Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss fff")}");
        }

        private void btnAsyncAd_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"btnAsyncAd_Click Start{Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss fff")}");

            //var action = new Action<string>(DoSomethingLong);

            //var asyncResult = action.BeginInvoke("btnAsyncAd_Click", null, null); // 开启一个线程去完成任务


            // // -1：一直等待，1000:限时等待  空参数：等待任务完成，会卡线程
            //var ret = asyncResult.AsyncWaitHandle.WaitOne(10000);

            //if (ret)
            //{
            //    Console.WriteLine("执行完成");
            //}
            //else
            //{
            //    Console.WriteLine("任务超时");
            //}

            Func<int> func = () =>
            {
                Thread.Sleep(2000);

                return DateTime.Now.Day;
            };

            // 开启一个线程去完成任务
            IAsyncResult result = func.BeginInvoke(ar =>
            {
                Thread.Sleep(2000);

                Console.WriteLine("线程ID：" + Thread.CurrentThread.ManagedThreadId.ToString("00"));

                Thread.Sleep(2000);

            }, null);

            // 卡住线程，每一个异步方法只能执行一次EndInvoke
            int day = func.EndInvoke(result);

            Console.WriteLine($"btnAsyncAd_Click End{Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss fff")}");

        }

        private void btnThread_Click(object sender, EventArgs e)
        {

        }
    }
}
