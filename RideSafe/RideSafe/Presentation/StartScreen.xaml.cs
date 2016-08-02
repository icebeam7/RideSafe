using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RideSafe.Presentation
{
	public partial class StartScreen : ContentPage
	{
		public StartScreen ()
		{
			InitializeComponent ();
		}

        private void btnUserInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShowUserInfo());
        }

        private void btnContacts_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShowContacts());
        }
    }
}
