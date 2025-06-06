﻿using System.Windows.Input;
using System.Windows;
using LoginApplication.Commands;
using LoginApplication.Databases;

namespace LoginApplication.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        private string newUsername;
        private string newPassword;
        private string confirmPassword;

        public string NewUsername
        {
            get => newUsername;
            set { newUsername = value; OnPropertyChanged(nameof(NewUsername)); }
        }

        public string NewPassword
        {
            get => newPassword;
            set { newPassword = value; OnPropertyChanged(nameof(NewPassword)); }
        }

        public string ConfirmPassword
        {
            get => confirmPassword;
            set { confirmPassword = value; OnPropertyChanged(nameof(ConfirmPassword)); }
        }

        public ICommand RegisterCommand { get; }

        public RegisterViewModel()
        {
            RegisterCommand = new RelayCommand(Register);
        }

        private void Register()
        {
            if (!string.IsNullOrEmpty(NewUsername) &&
                !string.IsNullOrEmpty(NewPassword) &&
                NewPassword == ConfirmPassword)
            {
                Database.Users.Add(NewUsername, NewPassword);
                MessageBox.Show("User successfully registered!");
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again.");
            }
        }

    }

}
