using IntecPract1.Models;
using IntecPract1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IntecPract1.ViewsModels
{
    class EditPageViewModel
    {
        Contact contact;
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        //AddPage C = new AddPage();
        public Entry EditNaming { get; set; }

        public Entry EditCell { get; set; }
        public ICommand EditCommand { get; set; }

        public EditPageViewModel()
        {
            Contact myContact = new Contact();

            EditCommand = new Command(async (param) =>
            {
                //myContact.Name = Naming.Text;
                //myContact.Number = Cell.Text;

                 //var result = Contacts.CopyTo(myContact);

                MessagingCenter.Send(this, "EditItem", myContact);
                await App.Current.MainPage.Navigation.PushModalAsync(new ContactPage());
            });

            MessagingCenter.Subscribe<App, Contact>(this, "AddedItem", (obj, item) =>
            {
                EditNaming.Text = item.Name;
                EditCell.Text = item.Number;
            });

        }
    }
}
