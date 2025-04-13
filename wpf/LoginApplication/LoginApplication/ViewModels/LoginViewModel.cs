using LoginApplication.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LoginApplication.Commands;
using LoginApplication.Databases;
using System.Windows;

namespace LoginApplication.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string username;
        private string password;

        public string Username
        {
            get => username;
            set { username = value; OnPropertyChanged(nameof(Username)); }
        }

        public string Password
        {
            get => password;
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }

        public ICommand LoginCommand { get; }
        public ICommand OpenRegisterCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
            OpenRegisterCommand = new RelayCommand(OpenRegister);
        }

        private void Login()
        {
            if (Database.Users.Count == 0)
            {
                MessageBox.Show("No user is registered\nTry Register");
                return;
            }

            if (Database.Users.ContainsKey(Username) &&
                Database.Users[Username] == Password)
            {
                var welcomeWindow = new WelcomeWindow();
                welcomeWindow.Show();
            }
            else
            {
                var errorWindow = new ErrorWindow();
                errorWindow.Show();
            }

        }

        private void OpenRegister()
        {
            var registerWindow = new RegisterWindow();
            registerWindow.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
