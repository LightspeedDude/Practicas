using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntecPract1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnClicked(object ob, EventArgs ar)
        {
            if (string.IsNullOrEmpty(Username.Text))
            {
                await DisplayAlert("Error", "You have to fill in the Username", "Ok");
            }
            else if (string.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Error", "You have to fill in the Password", "Ok");
            }
            else
            {
                await DisplayAlert("Access Granted", $"Hello,  {Username.Text}", "Ok");
            }
        }

    }
}
