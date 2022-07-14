using Course001.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Course001.ViewModels
{
    public class WindowModel
    {
        public string Title { get; set; } = "主窗口";

        public ButtonModel ButtonModel { get; set; } = new ButtonModel { Width = 100 };

        public TextBoxModel TextBoxModel { get; set; } = new TextBoxModel { Text = "Hello" };

        public ICommand BtnCommand { get; set; }


        public WindowModel()
        {
            BtnCommand = new CommandBase(BtnClick, null);
        }

        private void BtnClick(object obj)
        {
            ButtonModel.Width = ButtonModel.Width + 10;
        }
    }
}
