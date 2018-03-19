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
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
		}

        async void Handle_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopAsync();

            // to handle back button in modal
            await Navigation.PopModalAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            //return base.OnBackButtonPressed();
            return true; // will disable the back button functionality on Android or Win
        }
    }
}