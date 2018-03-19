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
	public partial class QuotesPage : ContentPage
	{
        private string[] quotes = { "Just Do It!", "Hello World", "Finally Working" };
        private int quoteIndex;

        public QuotesPage ()
		{
            
			InitializeComponent ();

            quoteIndex = 0;
            setQuote();
        }

        private void setQuote()
        {
            quote.Text = quotes[quoteIndex];
            if (quoteIndex != 2)
            {
                quoteIndex++;
            } else
            {
                quoteIndex = 0;
            }
        }

        private void Handle_Click (object source, EventArgs e)
        {
            setQuote();
        }

    }
}