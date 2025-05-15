using System;
using System.Windows;
using System.Windows.Input;
using CommandBinding.Commands;
using CommandBinding.Models;

namespace CommandBinding.ViewModels
{
    public class ClientViewModel : VMBase
    {
        public ICommand MyCommand { get; set; }
        private Person Person { get; set; } = new Person();
        public int ID { get { return Person._iD; } set { Person._iD = value; OnPropertyChanged(nameof(ID)); } }
        public string Name { get { return Person._name; } set { Person._name = value; OnPropertyChanged(nameof(Name)); } }
        public bool IsPresent { get { return Person._isPresent; } set { Person._isPresent = value; OnPropertyChanged(nameof(IsPresent)); } }

        public ClientViewModel()
        {
            // Bind the command to the method
            MyCommand = new RelayCommand(ExecuteMyCommand, CanExecuteMyCommand);
        }
        private bool CanExecuteMyCommand(object parameter)
        {
            return true;
        }
        private void ExecuteMyCommand(object parameter)
        {
            object[] vars = parameter as object[];
            if (parameter is object[] data)
            {
                Person p = new Person();
                p._iD= (int) data[0];
                p._name = data[1] as string;
                p._isPresent=(bool) data[2];

                // Call your method with multiple parameters
                ProcessData(p._iD, p._name, p._isPresent);
            }
        }
        private void ProcessData(int id, string name, bool isPresent)
        {
            // Logic to handle the parameters           
            MessageBox.Show($"Id: {id}, Name: {name}, IsPresent: {isPresent}");
        }
    }
}
