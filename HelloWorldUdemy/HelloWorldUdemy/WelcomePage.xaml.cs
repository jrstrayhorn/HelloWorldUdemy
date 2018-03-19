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
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
		}

        async void Handle_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new IntroductionPage());

            // Do open a modal with the page
            await Navigation.PushModalAsync(new IntroductionPage());
        }
	}
}