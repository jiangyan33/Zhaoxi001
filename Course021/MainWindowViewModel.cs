using Course021.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Course021
{
    public class MainWindowViewModel
    {

        public ICommand MouseCommand { get; set; }
        public ICommand KeyCommand { get; set; }

        public ICommand ComboSelectionChangedCommand { get; set; }

        public MainWindowViewModel()
        {
            MouseCommand = new CommandBase(Mouse);
            KeyCommand = new CommandBase(Key);
            ComboSelectionChangedCommand = new CommandBase(ComboSelectionChanged);
        }

        private void Key(object obj)
        {

        }

        private void Mouse(object obj)
        {

        }

        private void ComboSelectionChanged(object obj)
        {

        }

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
