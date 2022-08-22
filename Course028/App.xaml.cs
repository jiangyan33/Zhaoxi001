using Course028.DAL;
using Course028.Views;
using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Course028
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<DataAccessDAL>();

            containerRegistry.RegisterForNavigation(typeof(DialogView), nameof(DialogView));

            containerRegistry.RegisterDialog<DialogView>();

            containerRegistry.RegisterDialogWindow<DialogWindow>();

            // 反射来了， ViewModelLocationProvider.Register(viewType.ToString(), typeof(TViewModel));
            //            containerRegistry.RegisterForNavigation(viewType, name);

            // 现在还差一个传参数的问题。

            // 通过向上查找的方式，获取数据，然后传给构造方法

            // 再来一个模块化开发，将不同的模块处理成一个类库

            // 不用注入的方式，手动赋值DataContent也是可以实现的

            // 这里用region管理
        }
    }
}
