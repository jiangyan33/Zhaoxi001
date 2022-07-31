using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Course007
{
    /// <summary>
    /// TemplateLesson.xaml 的交互逻辑
    /// </summary>
    public partial class TemplateLesson : Window
    {
        public TemplateLesson()
        {
            InitializeComponent();

            Debug.WriteLine("调试");
            Console.WriteLine("测试");

            // 运算符包装器
            var value = new DataTable().Compute("100*(100*2+2)/10", "").ToString();
        }



        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(TemplateLesson), new PropertyMetadata(0));


    }
}
