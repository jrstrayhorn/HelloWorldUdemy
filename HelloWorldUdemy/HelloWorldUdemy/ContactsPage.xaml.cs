using HelloWorldUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorldUdemy
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
		public ContactsPage ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Mosh", ImageUrl = "https://picsum.photos/100/100?image=34"},
                new Contact { Name = "John", ImageUrl =  "https://picsum.photos/100/100?image=57"}
            };
		}

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailsPage(contact));
            listView.SelectedItem = null;
        }
	}
}