using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Course008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Value = 100;
        }


        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }


        /// <summary>
        /// 元数据 FrameworkPropertyMetadata,是PropertyMetadata的子类，有一些细节实现 
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(MainWindow),

                new PropertyMetadata(default(double), new PropertyChangedCallback(OnPropertyChanged), new CoerceValueCallback(OnCoerceValue)),

                new ValidateValueCallback(OnValidateValue)
                );


        /// <summary>
        /// 验证回调，如果返回值为False，这个值不会被写入到依赖属性中，也就是不会触发PropertyChanged
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static bool OnValidateValue(object obj)
        {
            return true;
        }

        /// <summary>
        /// 属性值发生变更时触发
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        /// <summary>
        /// 强制回调
        /// </summary>
        /// <param name="d"></param>
        /// <param name="obj">当前属性的最新值</param>
        /// <returns>希望属性可以接受的值</returns>
        private static object OnCoerceValue(DependencyObject d, object obj)
        {
            // 当传入的值不符合要求，可以强制赋值一个数据，比如最大值为100，当输入的值大于100时，可以强制修改为100

            return obj;
        }

    }
}
