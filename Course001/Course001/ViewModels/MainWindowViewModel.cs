using Course001.Base;
using Course001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Course001.ViewModels
{
    public class MainWindowViewModel
    {
        public string Title { get; set; } = "主窗口";

        public ButtonModel ButtonModel { get; set; } = new ButtonModel { Width = 100 };

        public TextBoxModel TextBoxModel1 { get; set; } = new TextBoxModel { Text = "Hello" };

        public TextBoxModel TextBoxModel2 { get; set; } = new TextBoxModel { Text = "Hello" };


        public ICommand BtnCommand { get; set; }


        public MainWindowViewModel()
        {
            BtnCommand = new CommandBase(BtnClick, null);
        }

        private void BtnClick(object obj)
        {
            ButtonModel.Text = TextBoxModel1.Text + TextBoxModel2.Text;
        }
    }
}
