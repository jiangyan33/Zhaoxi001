using System;
using System.Windows.Input;

namespace Course001.Base
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return DoCanExecute?.Invoke(parameter) == true;
        }

        public void Execute(object parameter)
        {
            DoExecute?.Invoke(parameter);
        }

        private Action<object> DoExecute { get; set; }

        private Func<object, bool> DoCanExecute { get; set; }

        public CommandBase(Action<object> action, Func<object, bool> func)
        {
            DoExecute = action;

            DoCanExecute = func;
        }

        public CommandBase()
        {

        }

    }
}
