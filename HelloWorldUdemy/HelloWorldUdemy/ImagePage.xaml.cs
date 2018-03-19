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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();
            /*
            //var imageSource = (UriImageSource) ImageSource.FromUri

            var imageSource = new UriImageSource { Uri = new Uri("https://wallpaperscraft.com/image/luis_nani_footballer_manchester_united_ball_sport_26264_1920x1080.jpg") };
            imageSource.CachingEnabled = false; // if you want to turn off cache
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            image.Source = imageSource;
            */

            /* Adding an image from an embedded resource in .NET Standard project
             * This is a non platform specific image
            image.Source = ImageSource.FromResource("HelloWorldUdemy.Images.background.jpg");
            */

            /* When you need to change how to get to file, due to folder structure
            string fileName;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    fileName = "clock.png";
                    break;

                case Device.Android:
                    fileName = "clock.png";
                    break;

                case Device.UWP:
                    fileName = "Images/clock.png";
                    break;

                default:
                    throw new Exception("Unknown Platform");
            }

            btn.Image = (FileImageSource) ImageSource.FromFile(fileName);
            */
		}
	}
}