using System;
using System.Collections.ObjectModel;
using System.Windows;
using MVVM_App.commands;
using MVVM_App.models;

namespace MVVM_App.viewModels
{
    public class MainViewModel : viewModelBase
    {
        public MVVM_App.models.User UserModel { get; set; }
        public RelayCommand ShowMessageCommand { get => new RelayCommand(CanShowMsg, ShowMsg); }
        public RelayCommand AddUserCommand { get => new RelayCommand(CanAddUser, AddUser); }
        public ObservableCollection<User> Items { get; set; } = new ObservableCollection<User>();

        
        public string Name {
            get => UserModel.Name;
            set { UserModel.Name = value; OnPropertyChanged(nameof(Name)); } 
        }
        
        public string Email { 
            get => UserModel.Email;
            set { UserModel.Email = value; OnPropertyChanged(nameof(Email)); } 
        }
        
        public DateTime Date
        {
            get => UserModel.Date;
            set { UserModel.Date = value; OnPropertyChanged(nameof(Date)); }
        }

        public bool CanShowMsg(object obj) { return true; }
        public void ShowMsg(object obj)
        {
            MessageBox.Show("Registered Successfully");
        }
        public bool CanAddUser(object obj) { return true; }
        public void AddUser(object obj)
        {
            Items.Add(new User { Name = Name, Email=Email });
            ShowMsg(null);
        }
        public MainViewModel() { UserModel = new MVVM_App.models.User(); }
    }
}
