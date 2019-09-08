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
        ContactView contact;

        public ContactView SelectedContact
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

        public ObservableCollection<ContactView> Contact { get; set; } = new ObservableCollection<ContactView>();

        public ICommand DeleteElementCommand { get; set; }
        public object ContextActions { get; }
        public static ObservableCollection<string> items { get; set; }

        public object Naming { get; set; }

        public object Cell { get; set; }
        public ICommand AddCommand { get; set; }

        public ContactViewModel()
        {
            ContactView myContact = new ContactView();

            AddCommand = new Command(async (param) =>
            {
                myContact.Name = Naming.ToString;
                myContact.Number = Cell.ToString;

                var result = Contact.Add(myContact);

            });


            DeleteElementCommand = new Command(async (param) =>
            {
                var result = Contact.Remove(SelectedContact);

            });

            MessagingCenter.Subscribe<AddPage, ContactPage>(this, "AddItem", (obj, item) =>
            {

                var newItem = item as ContactPage;
                ContactView temp = new ContactView() { Name = newItem.nm, Number = newItem.nb };

                Contact.Add(temp);

                listv.ItemsSource = null;
                listv.ItemsSource = Contact;

            });

            //myContact.Name = "Juan";
            //myContact.Number = 8096574545;

            //Contact.Add(myContact);

        }

    }
}
