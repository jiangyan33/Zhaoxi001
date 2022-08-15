using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Course014
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            this.Startup += App_Startup;

            this.Exit += App_Exit;

            this.SessionEnding += App_SessionEnding;

            // UI线程异常，无法捕获多线程异常
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;

            // 专门捕获所有线程中的异常(可以捕获UI线程异常)
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            // 专门捕获Task异常，触发GC的时候才会触发
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
        }

        private void TaskScheduler_UnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
        {
            Debug.WriteLine("TaskScheduler_UnobservedTaskException.....");
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Debug.WriteLine("CurrentDomain_UnhandledException.....");
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            Debug.WriteLine("App_DispatcherUnhandledException.....");
        }

        private void App_SessionEnding(object sender, SessionEndingCancelEventArgs e)
        {
            // 关闭操作系统触发
            Debug.WriteLine("App_SessionEnding.....");
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
            Debug.WriteLine("App_Exit.....");
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            Debug.WriteLine("App_Startup.....");
        }
    }
}
