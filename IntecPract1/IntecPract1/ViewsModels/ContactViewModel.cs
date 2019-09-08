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
    class ContactViewModel : ContentPage
    {
        Contact contact;

        public Contact SelectedContact
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
            }
        }

        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();

        public ICommand DeleteElementCommand { get; set; }
        public object ContextActions { get; }
        public static ObservableCollection<string> items { get; set; }

        public ContactViewModel()
        {
            Contact myContact = new Contact();

            DeleteElementCommand = new Command(async (param) =>
            {
                var result = Contacts.Remove(SelectedContact);

            });

            MessagingCenter.Subscribe<AddPage, ContactPage>(this, "AddItem", (obj, item) =>
            {
                var newItem = item as ContactPage;


                //Contact temp = new Contact() { Name = newItem.Naming, Number = newItem.Cell };

                myContact.Name = item.Name;
                myContact.Number = item.Number;

                Contacts.Add(myContact);

                //listv.ItemsSource = null;
                //listv.ItemsSource = Contact;

            });

            //myContact.Name = "Juan";
            //myContact.Number = 8096574545;

            //Contact.Add(myContact);

        }

    }
}
