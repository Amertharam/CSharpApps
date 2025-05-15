using System;
using System.Windows.Input;

namespace CommandBinding.Commands
{
    public class RelayCommand : ICommand
    {
        public Action<object> _execute;
        public Func<object, bool> _canExecute;
        public event EventHandler CanExecuteChanged;
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            if (parameter == null)
            {
                return true;
            }
            return _canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
