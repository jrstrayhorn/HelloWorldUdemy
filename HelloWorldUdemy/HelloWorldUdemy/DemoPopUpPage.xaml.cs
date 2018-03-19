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
	public partial class DemoPopUpPage : ContentPage
	{
		public DemoPopUpPage ()
		{
			InitializeComponent ();
		}


        async void Handle_Clicked(object sender, EventArgs e)
        {
            /*
            // how to display confirmation box
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            if (response)
                 await DisplayAlert("Done", "Your response will be saved!", "OK");

            // if we had code then we need to await the above line.
            */

            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");
            await DisplayAlert("Response", response, "OK");
        }
    }

}