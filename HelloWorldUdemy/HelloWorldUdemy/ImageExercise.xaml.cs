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
	public partial class ImageExercise : ContentPage
	{
        private int _currentImageId = 1;

        public ImageExercise ()
		{
			InitializeComponent ();

            _currentImageId = 101;

            LoadImage();
        }

        void LoadImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("https://picsum.photos/1920/1080?image={0}", _currentImageId)),
                CachingEnabled = false
            };
        }

        void Previous_Clicked(object sender, System.EventArgs e)
        {
            _currentImageId--;
            if (_currentImageId == 100)
                _currentImageId = 110;

            LoadImage();
        }

        void Next_Clicked(object sender, System.EventArgs e)
        {
            _currentImageId++;
            if (_currentImageId == 111)
                _currentImageId = 101;

            LoadImage();
        }


    }

}