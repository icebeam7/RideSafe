using System;

using Xamarin.Forms;
using RideSafe.Business;

namespace RideSafe.Presentation
{
	public partial class ShowContacts : ContentPage
	{
		public ShowContacts ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            lstContacts.ItemsSource = App.DB.GetContacts();
        }

        private void Contact_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Contact data = e.SelectedItem as Contact;
                EditContacts page = new EditContacts();
                page.id = data.ID;
                Navigation.PushAsync(page);
            }
        }

        private void btnNew_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditContacts());
        }
    }
}
