using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace catApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{

        public GreetPage ()
		{
			InitializeComponent ();
		}
        void handled_clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Hello world", "OK");
        }


    }
}