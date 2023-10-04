using PilotChecklist_v1.Business;
using PilotChecklist_v1.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Xamarin.Forms;

namespace PilotChecklist_v1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        LoginValidation loginValidation = new LoginValidation();

        private string username;
        private string password;

        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (ValidateLogin())
            {
                App.Current.MainPage = new AppShell();
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Login Failed", "Invalid username or password", "OK");
            }
        }

        private bool ValidateLogin()
        {
            string username = Username;
            string password = Password;
            return (loginValidation.Login(username, password));
        }
    }
}
