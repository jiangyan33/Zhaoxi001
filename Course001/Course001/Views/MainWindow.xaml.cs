using Course001.ViewModels;
using System.Windows;

namespace Course001.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Window顶级控件的上下文信息
            DataContext = new WindowModel();
        }
    }
}
