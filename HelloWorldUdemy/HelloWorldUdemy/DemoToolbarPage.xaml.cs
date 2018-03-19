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
	public partial class DemoToolbarPage : ContentPage
	{
		public DemoToolbarPage ()
		{
			InitializeComponent ();
		}

        void Handle_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Activiated", "ToolbarItem Activiated", "OK");
        }
	}
}