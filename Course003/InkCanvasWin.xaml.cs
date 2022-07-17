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
using System.Windows.Shapes;

namespace Course003
{
    /// <summary>
    /// InkCanvasWin.xaml 的交互逻辑
    /// </summary>
    public partial class InkCanvasWin : Window
    {
        public InkCanvasWin()
        {
            InitializeComponent();


            EditingMode.ItemsSource = Enum.GetValues(typeof(InkCanvasEditingMode));
        }

        private void EditingMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            inkCanvas.EditingMode = (InkCanvasEditingMode)EditingMode.SelectedItem;
        }
    }
}
