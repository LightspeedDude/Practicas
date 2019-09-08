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
    class AddPageViewModel
    {
        Contact contact;
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        //AddPage C = new AddPage();
        public Entry Naming { get; set; }

        public Entry Cell { get; set; }
        public ICommand AddCommand { get; set; }

        public AddPageViewModel()
        {
            Contact myContact = new Contact();

            AddCommand = new Command(async (param) =>
            {
                myContact.Name = Naming.Text;
                myContact.Number = Cell.Text;

                Contacts.Add(myContact);

                myContact.Name = "Pablo";
                myContact.Number = "8099875678";
                Contacts.Add(myContact);

                MessagingCenter.Send(this, "AddItem", myContact);
                await App.Current.MainPage.Navigation.PushModalAsync(new ContactPage());
            });


        }

        }
}
