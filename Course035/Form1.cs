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

namespace Course035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            Console.WriteLine("线程One：" + $"{Thread.CurrentThread.ManagedThreadId.ToString("00")}");
            //{

            //    var task = new Task(() =>
            //    {
            //        Console.WriteLine("线程1：" + $"{Thread.CurrentThread.ManagedThreadId.ToString("00")}");
            //    });

            //    task.Start();
            //}

            //{

            //    Task.Run(() =>
            //    {
            //        Console.WriteLine("线程2：" + $"{Thread.CurrentThread.ManagedThreadId.ToString("00")}");
            //    });
            //}

            //{
            //    var taskFactory = new TaskFactory();

            //    taskFactory.StartNew(() =>
            //    {
            //        Console.WriteLine("线程3：" + $"{Thread.CurrentThread.ManagedThreadId.ToString("00")}");
            //    });

            //    //taskFactory.ContinueWhenAll()
            //}

            Console.WriteLine("Rochard老师开始讲课....");

            Teach("多线程");
            Teach("Redis");
            Teach("数据库设计");
            Teach("数据结构");

            Console.WriteLine("Rochard老师讲课结束了....");

            Console.WriteLine("开始项目实战开发....");


            var taskList = new List<Task>();

            var factory = Task.Factory;

            // 这个参数o就是"区区在下",后面传递的参数 
            taskList.Add(factory.StartNew((o) => Coding("区区在下", "框架搭建"), "区区在下"));
            taskList.Add(factory.StartNew((o) => Coding("踏路而行", "微信接口对接"), "踏路而行"));
            taskList.Add(factory.StartNew((o) => Coding("Fpking", "WebApi"), "Fpking"));
            taskList.Add(factory.StartNew((o) => Coding("平凡世界", "数据库设计"), "平凡世界"));

            // 当全部完成的时候触发 会卡线程
            //Task.WaitAll(taskList.ToArray());

            //Console.WriteLine("所有人都完成了程序，庆祝一下");

            // 当完成一个的时候触发 会卡线程
            //Task.WaitAny(taskList.ToArray());

            //Console.WriteLine("有人完成了，需要准备测试环境");

            // 回调，不会卡线程
            //factory.ContinueWhenAll(taskList.ToArray(), (task) =>
            //{
            //    // 当所有的都完成了
            //    Console.WriteLine("所有人都完成了程序，庆祝一下");
            //});

            factory.ContinueWhenAny(taskList.ToArray(), (task) =>
            {
                // 当其中一个完成了
                Console.WriteLine($"{task.AsyncState}完成了程序，庆祝一下");
            });

            Console.WriteLine("线程Two：" + $"{Thread.CurrentThread.ManagedThreadId.ToString("00")}");
        }

        private void Teach(string lesson)
        {
            Console.WriteLine($"开始了讲{lesson}。。。");

            long result = 0;

            for (var i = 0; i < 1_000_000_000; i++)
            {
                result += i;
            }
            Console.WriteLine($"讲完了{lesson}。。。");
        }

        private void Coding(string name, string projectName)
        {
            Console.WriteLine($"Coding Start || {name} {projectName}{Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss:fff")}");

            long result = 0;

            for (var i = 0; i < 1_000_000_000; i++)
            {
                result += i;
            }

            Thread.Sleep(3000);

            Console.WriteLine($"Coding End || {name} {projectName}{Thread.CurrentThread.ManagedThreadId.ToString("00")}{DateTime.Now.ToString("HH:mm:ss:fff")}");
        }

        private void btnTaskAdvanced_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"btnTaskAdvanced Start || {Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss:fff")}");

            //try
            //{
            //    var list = new List<Task>();

            //    for (var i = 0; i < 20; i++)
            //    {
            //        var k = "TaskAdvanced_Click_" + i;

            //        list.Add(Task.Run(() =>
            //        {
            //            if (k == "TaskAdvanced_Click_6")
            //            {
            //                throw new Exception("异常,因为TaskAdvanced_Click_6");
            //            }
            //            else if (k == "TaskAdvanced_Click_9")
            //            {
            //                throw new Exception("异常,因为TaskAdvanced_Click_9");
            //            }
            //            else if (k == "TaskAdvanced_Click_12")
            //            {
            //                throw new Exception("异常,因 为TaskAdvanced_Click_12");
            //            }
            //        }));
            //    }

            //    Task.WaitAll(list.ToArray());
            //}
            //catch (AggregateException aex)
            //{
            //    foreach(var item in aex.InnerExceptions)
            //    {
            //        Console.WriteLine("捕获到异常" + item.Message);
            //    }
            //}

            var cts = new CancellationTokenSource();

            for (var i = 0; i < 100; i++)
            {
                var str = i + "";

                Task.Run(() =>
                {
                    Console.WriteLine($"线程执行到了:{str},线程id:{Thread.CurrentThread.ManagedThreadId.ToString("00")}");

                    if (str == "6")
                    {
                        cts.Cancel();
                    }
                }, cts.Token);
            }

            Console.WriteLine($"btnTaskAdvanced End || {Thread.CurrentThread.ManagedThreadId.ToString("00")}```{DateTime.Now.ToString("HH:mm:ss:fff")}");

        }
    }
}
