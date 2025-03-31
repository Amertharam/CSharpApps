using System;
using System.Windows.Input;

namespace MVVM_App.commands
{
    public class RelayCommand : ICommand
    {
        Func<object, bool> _canExecute;
        Action<object> _execute;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
           return  _canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public RelayCommand(Func<object, bool> canExecute, Action<object> execute )
        {
            this._canExecute = canExecute;
            this._execute = execute;
        }
    }
}
