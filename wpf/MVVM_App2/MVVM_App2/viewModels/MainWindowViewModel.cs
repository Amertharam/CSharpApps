using System;
using System.Windows.Input;
using System.Windows;
using MVVM_App2.models;
using System.Collections.ObjectModel;

namespace MVVM_App2.viewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(){ }

        private VMEvent _addToListViewCommand;
        public VMEvent AddToListViewCommamd
        {
            get { return _addToListViewCommand = new VMEvent(AddToListView); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        private string _age;
        public string Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged(nameof(Name)); }
        }

        public ObservableCollection<User> Items { get; set; } = new ObservableCollection<User>();

        private void AddToListView()
        {
            Items.Add(new User { Name = Name, Age = Age });
            MessageBox.Show("User : " + Name + " Registrated Successfully");
        }
    }
    public class VMEvent : ICommand
    {
        Action _action;
        public event EventHandler CanExecuteChanged;
        public VMEvent(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
