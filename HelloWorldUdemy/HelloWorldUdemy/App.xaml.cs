using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorldUdemy
{
	public partial class App : Application
	{
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";

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
            //MainPage = new NavigationPage(new InstagramExMainPage());
            //MainPage = new NavigationPage(new DemoFormsPage());
            //MainPage = new NavigationPage(new ContactBookExercise());
            //MainPage = new DemoDataAccess();
            MainPage = new DemoRESTPage();
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

        public string Title {
            get {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();

                return "";
            }
            set {
                Properties[TitleKey] = value;
            }
        }

        public bool NotificationsEnabled {
            get {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                    return (bool)Properties[NotificationsEnabledKey];

                return false;
            }
            set {
                Properties[NotificationsEnabledKey] = value;
            }
        }
	}
}
