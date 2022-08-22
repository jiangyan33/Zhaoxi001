using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Mvvm;
using System.Threading.Tasks;

namespace Course026.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private int _value = 300;

        public int Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }

    }
}
