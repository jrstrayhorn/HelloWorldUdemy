using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorldUdemy
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new HelloWorldUdemy.MainPage();
            //MainPage = new ImagePage();
            //MainPage = new DemoImageCircle();
            //MainPage = new DemoBasicList();
            //MainPage = new ListExercise();
            /*MainPage = new NavigationPage(new WelcomePage())
            {
                BarBackgroundColor = Color.Gray,
                BarTextColor = Color.White
            };*/
            //MainPage = new NavigationPage(new ContactsPage());
            //MainPage = new MyTabbedPage();
            //MainPage = new DemoPopUpPage();
            //MainPage = new NavigationPage(new DemoToolbarPage());
            MainPage = new NavigationPage(new InstagramExMainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
