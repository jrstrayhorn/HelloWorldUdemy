using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorldUdemy
{
    public partial class DemoDataAccess : ContentPage
    {
       /*
        void OnChange(object sender, System.EventArgs e)
        {
            var app = Application.Current as App;
            app.Title = title.Text;
            app.NotificationsEnabled = notificationsEnabled.On;

            //Application.Current.SavePropertiesAsync()
        }
        */

        /*
         if have multiple pages you can save when page disappears
		protected override void OnDisappearing()
		{
			base.OnDisappearing();
		}
        */

		public DemoDataAccess()
        {
            InitializeComponent();

            BindingContext = Application.Current;
            //var app = Application.Current as App;
            //title.Text = app.Title;
            //notificationsEnabled.On = app.NotificationsEnabled;
        }
    }
}
