using IntecPract1.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntecPract1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            this.BindingContext = new ContactViewModel();

            listv.ItemTapped += Listv_ItemTapped;
        }
        private void Listv_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            MessagingCenter.Send<ContactPage, string>(this, "Contact", "Hi");

        }
        async void OnClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new AddPage());
        }
        async void OnClicked2(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Choose an Option", "Call", "Edit", "Cancel", null);
            switch (action)
            {
                case "Call":
                    Device.OpenUri(new Uri(String.Format("tel:{0}", Number.Text)));
                    break;
                case "Edit":
                    await App.Current.MainPage.Navigation.PushModalAsync(new EditPage());
                    break;
            }
        }
    }
}