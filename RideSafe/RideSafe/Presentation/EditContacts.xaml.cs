using System;

using Xamarin.Forms;
using RideSafe.Business;

namespace RideSafe.Presentation
{
	public partial class EditContacts : ContentPage
	{
        public string id = "";

		public EditContacts ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (id != "")
            {
                Contact data = App.DB.GetContact(id);
                txtName.Text = data.Name;
                txtPhoneNumber.Text = data.PhoneNumber;
                txtDescription.Text = data.Description;
            }
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string description = txtDescription.Text;

            App.DB.SaveContact(id, name, phoneNumber, description);
            Navigation.PopAsync();
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            if (id != "")
            {
                App.DB.DeleteContact(id);
                Navigation.PopAsync();
            }
        }
    }
}
