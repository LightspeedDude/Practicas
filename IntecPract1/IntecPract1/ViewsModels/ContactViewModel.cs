using IntecPract1.Models;
using IntecPract1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IntecPract1.ViewsModels
{
    class ContactViewModel : ContactPage, INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand DeleteElementCommand { get; set; }
        public object ContextActions { get; }
        public static ObservableCollection<string> items { get; set; }

        public ICommand AddContact { get; set; }
        public ICommand More { get; set; }

        public ContactViewModel()
        {
            Contact myContact = new Contact();

            DeleteElementCommand = new Command((param) =>
            {
                var result = Contacts.Remove(SelectedContact);

            });

            AddContact = new Command(async (param) =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new AddPage());
            });

            myContact.Name = "Juan";
            myContact.Number = "8098432123";
            Contacts.Add(myContact);

            More = new Command(async (param) =>
            {
                var action = await DisplayActionSheet("Choose an Option", "Call", "Edit", "Cancel", null);
                switch (action)
                {
                    case "Call":
                        Device.OpenUri(new Uri(String.Format("tel:{0}", SelectedContact.Number)));
                        break;
                    case "Edit":
                        await App.Current.MainPage.Navigation.PushModalAsync(new EditPage());
                        break;
                }
            });



            MessagingCenter.Subscribe<AddPageViewModel, Contact>(this, "AddItem", (obj, item) =>
            {
                myContact.Name = item.Name;
                myContact.Number = item.Number;
                Contacts.Add(myContact);
                MessagingCenter.Unsubscribe<AddPageViewModel, Contact>(this, "AddItem");
            });

            MessagingCenter.Send(this, "AddedItem", SelectedContact);

            MessagingCenter.Subscribe<EditPageViewModel, Contact>(this, "EditItem", (obj, item) =>
            {
                SelectedContact.Name = item.Name;
                SelectedContact.Number = item.Number;
                Contacts.Add(SelectedContact);
                MessagingCenter.Unsubscribe<EditPageViewModel, Contact>(this, "EditItem");
            });

        }

    }
}
