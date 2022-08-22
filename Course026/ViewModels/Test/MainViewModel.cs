using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Course026.Views;
using Prism.Commands;
using Prism.Mvvm;

namespace Course026.ViewModels.Test
{
    public class MainViewModel : BindableBase
    {

        private int _value = 200;

        public int Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }

        public ICommand BtnCommand { get => new DelegateCommand(Btn); }

        private void Btn()
        {
            var control = new LoginView();

            control.DataContext = new LoginViewModel();

            control.ShowDialog();
        }

    }
}
