using System;
using System.Collections.Generic;
using Xamarin.Forms;
using IntecPract1.ViewsModels;

namespace IntecPract1.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterPageViewModel();
        }
        //async void OnClicked(object ob, EventArgs ar)
        //{
        //    if (string.IsNullOrEmpty(Username.Text))
        //    {
        //        await DisplayAlert("Error", "You have to fill in the Username", "Ok");
        //    }
        //    else if (string.IsNullOrEmpty(Password.Text))
        //    {
        //        await DisplayAlert("Error", "You have to fill in the Password", "Ok");
        //    }
        //    else if (string.IsNullOrEmpty(Email.Text))
        //    {
        //        await DisplayAlert("Error", "You have to fill in the Email", "Ok");
        //    }
        //    else if (Password.Text != CPassword.Text)
        //    {
        //        await DisplayAlert("Error", "The Password doesn't match the Confirmation", "Ok");
        //    }

        //    else
        //    {
        //        await DisplayAlert("Access Granted", $"Welcome,  {Username.Text}", "Ok");
        //    }
        //}
    }
}