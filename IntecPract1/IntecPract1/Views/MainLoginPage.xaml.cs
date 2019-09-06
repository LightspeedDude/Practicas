using IntecPract1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Text.RegularExpressions;
using IntecPract1.ViewsModels;

namespace IntecPract1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainLoginPage : ContentPage
    {
        public MainLoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginPageViewModel();
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
        //    else
        //    {
        //        await DisplayAlert("Access Granted", $"Hello,  {Username.Text}", "Ok");
        //    }
        //}

        //void HandleTextChanged(object sender, TextChangedEventArgs e)
        //{
        //    const string pwRegex = @"^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$";
        //    bool IsValid = false;
        //    IsValid = (Regex.IsMatch(e.NewTextValue, pwRegex, RegexOptions.IgnoreCase));
        //    ((Entry)sender).TextColor = IsValid ? Color.Default : Color.Red;

        //    // LABEL CODE
        //    Label errorLabel = ((Entry)sender).FindByName<Label>("errorMessage");
        //    if (IsValid)
        //    {
        //        errorLabel.Text = "Passowrd Invalid or whatever!";
        //    }
        //    else
        //    {
        //        errorLabel.Text = "";
        //    }
        //}

        async void OnTap(object sender, EventArgs args)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new RegisterPage());
        }

    }
}
