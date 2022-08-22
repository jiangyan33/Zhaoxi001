using Course028.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Unity;

namespace Course028.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        [Dependency]
        public IDialogService DialogService { get; set; }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }

        public ICommand TestCommand { get => new DelegateCommand<string>(Test); }


        private void Test(string value)
        {
            var param = new DialogParameters();

            param.Add("data", value);

            DialogService.Show(nameof(DialogView), param, null);
        }
    }
}
