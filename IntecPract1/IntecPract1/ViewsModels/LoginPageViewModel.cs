using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;
using IntecPract1.Models;
using IntecPract1.Views;

namespace IntecPract1.ViewsModels
{
    class LoginPageViewModel : User, INotifyPropertyChanged
    {
        public string ErrorMessage { get; set; }
        public ICommand LoginCommand { get; set; }

        public ICommand RegistryCommand { get; set; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(Login);
            RegistryCommand = new Command(Register);
        }
        public User User { get; set; } = new User();
       
        async void Register()
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new RegisterPage());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        async void Login()
        {
            if (string.IsNullOrEmpty(Username))
            {
                ErrorMessage = "Can't leave the username empty";
            }
            else if (string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Can't leave the Password empty";
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome", $" Have fun", "Ok");
            }
        }
        
    }
}
