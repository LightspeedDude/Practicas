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
    public partial class AddPage 
    {
        ContactPage C = new ContactPage();
        public AddPage()
        {
            InitializeComponent();
            this.BindingContext = new ContactViewModel();

        }
        //async void OnSaveClick(object sender, EventArgs e)
        //{
        //    C.nm = Nm.Text;
        //    C.nb = Nb.Text;

        //    MessagingCenter.Send(this, "AddItem", C);
        //    await App.Current.MainPage.Navigation.PushModalAsync(new ContactPage());
        //}

    }
}
