using HelloWorldUdemy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorldUdemy
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoBasicList : ContentPage
	{
		public DemoBasicList ()
		{
			InitializeComponent ();

            /* - Simple List
            var names = new List<string>
            {
                "Most",
                "John",
                "Bob"
            };

            listView.ItemsSource = names;
            */

            /* - Complex List
            listView.ItemsSource = new List<Contact>{
                new Contact { Name="Mosh", ImageUrl="https://picsum.photos/100/100?image=54"},
                new Contact { Name="Jerry", ImageUrl="https://picsum.photos/100/100?image=76", Status="Hey, let's talk!"}
            };
            */

            /* - Grouping List Items
            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("M", "M")
                {
                    new Contact { Name="Mosh", ImageUrl="https://picsum.photos/100/100?image=54"},
                new Contact { Name="Mike", ImageUrl="https://picsum.photos/100/100?image=76", Status="Hey, let's talk!"}
                },

                new ContactGroup("J", "J")
                {
                    new Contact { Name="J.R.", ImageUrl="https://picsum.photos/100/100?image=88"}
                }
            };
            */

            /* In order to remove items from list and have UI update need to create ObservableCollection
            _contacts = new ObservableCollection<Contact>{
                new Contact { Name="Mosh", ImageUrl="https://picsum.photos/100/100?image=54"},
                new Contact { Name="Jerry", ImageUrl="https://picsum.photos/100/100?image=76", Status="Hey, let's talk!"},
                new Contact { Name="Mosh", ImageUrl="https://picsum.photos/100/100?image=54"},
                new Contact { Name="Jerry", ImageUrl="https://picsum.photos/100/100?image=76", Status="Hey, let's talk!"}
            };

            listView.ItemsSource = _contacts;
            */

            listView.ItemsSource = GetContacts();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // Just comment out these lines if you don't want to handle the itemtapped event
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            /* How to get the SelectedItem
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");
            */
            listView.SelectedItem = null;  // this will disable the default selected behavior
        }

        void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        /*
        private ObservableCollection<Contact> _contacts;

        void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }
        */

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
             var contacts = new List<Contact>{
                new Contact { Name="Mosh", ImageUrl="https://picsum.photos/100/100?image=54"},
                new Contact { Name="Jerry", ImageUrl="https://picsum.photos/100/100?image=76", Status="Hey, let's talk!"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

            //return contacts.FindAll(c => c.Name.Contains(searchText));
            return contacts.Where(c => c.Name.StartsWith(searchText));
        }

        void Handle_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            //listView.IsRefreshing = false;
            listView.EndRefresh();
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}