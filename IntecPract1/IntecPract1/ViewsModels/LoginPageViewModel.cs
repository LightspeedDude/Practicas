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

        public LoginPageViewModel()
        {
            LoginCommand = new Command(Login);
        }
        public User User { get; set; } = new User();
      

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
                await App.Current.MainPage.DisplayAlert("Welcome", Username +", Have fun", "Ok");
                await App.Current.MainPage.Navigation.PushModalAsync(new ContactPage());
            }
        }
        
    }
}
