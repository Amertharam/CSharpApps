using LoginApplication.Views;
using System.Windows.Input;
using LoginApplication.Commands;
using LoginApplication.Databases;
using System.Windows;
using LoginApplication.Models;

namespace LoginApplication.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        //private string username;
        //private string password;
        private UserModel _userModel;
        public UserModel UserModel 
        {
            get { return _userModel; }
            set { _userModel = value; }
        }

        public string Username
        {
            get => UserModel.Username;
            set { UserModel.Username = value; OnPropertyChanged(nameof(Username)); }
        }

        public string Password
        {
            get => UserModel.Password;
            set { UserModel.Password = value; OnPropertyChanged(nameof(Password)); }
        }

        public ICommand LoginCommand { get; }
        public ICommand OpenRegisterCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
            OpenRegisterCommand = new RelayCommand(OpenRegister);
            UserModel = new UserModel();
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

    }

}
