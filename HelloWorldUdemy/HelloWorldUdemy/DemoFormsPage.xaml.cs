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
	public partial class DemoFormsPage : ContentPage
	{
		public DemoFormsPage ()
		{
			InitializeComponent ();
		}

        /*
        void Handle_Toggled(object sender, ToggledEventArgs e)
        {
            //label.IsVisible = e.Value;
        }
        */

        void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //e.NewValue
            //e.OldValue
        }
	}
}