using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorldUdemy
{
    public class ContactMethod
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoFormsPage : ContentPage
	{
		public DemoFormsPage ()
		{
			InitializeComponent ();

            /* Date Picker
            _contactMethods = GetContactMethods();

            foreach (var method in _contactMethods)
            {
                picker.Items.Add(method.Name);
            }
            */
        }

        /*
        void Handle_Toggled(object sender, ToggledEventArgs e)
        {
            //label.IsVisible = e.Value;
        }
        */

        /*
        void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //e.NewValue
            //e.OldValue
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            label.Text = "Completed"; //throw new NotImplementedException();
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e) {
            label.Text = e.NewTextValue;
            // e.OldTextValue
        }
        */

        /*
        private IList<ContactMethod> _contactMethods;

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id=1, Name="SMS"},
                new ContactMethod { Id=2, Name="Email"}
            };
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var name = picker.Items[picker.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);
            var id = contactMethod.Id;


            DisplayAlert("Selection", name + id.ToString(), "OK");
        }
        */

        void Handle_DateSelected(object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            //e.NewDate or e.OldDate    throw new NotImplementedException();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }
	}
}