using Course028.DAL;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Threading.Tasks;
using Unity;

namespace Course028.ViewModels
{
    public class DialogViewModel : BindableBase, IDialogAware
    {

        [Dependency]
        public DataAccessDAL DataAccessDAL { get; set; }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }

        private string _title = "明细";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Value = parameters.GetValue<string>("data");
        }

        public void Refresh()
        {
            Task.Run(async () =>
            {

                await Task.Delay(3000);

                var result = DataAccessDAL.List();

                Title = result[1];
            });
        }
    }
}
