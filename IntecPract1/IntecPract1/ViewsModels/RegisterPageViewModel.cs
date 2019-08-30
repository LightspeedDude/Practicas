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
    class RegisterPageViewModel : User, INotifyPropertyChanged
    {
        public static MasterDetailPage MDP { get; set; }
        public string ErrorMessage { get; set; }
        public string CPassword { get; set; }

        public ICommand RegisterCommand { get; set; }

        public RegisterPageViewModel()
        {

            RegisterCommand = new Command(CRegistration);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void CRegistration()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(CPassword))
            {
                ErrorMessage = "Please fill all the requirements";
            }
            else
            {

                if (CPassword != Password)
                {
                    ErrorMessage = "Passwords don't match";
                }
                else
                {
                    MDP = new HomePage();

                    App.Current.MainPage = MDP;
                }
            }

        }

    }
}
