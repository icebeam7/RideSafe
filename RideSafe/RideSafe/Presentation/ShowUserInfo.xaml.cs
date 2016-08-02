using System;

using Xamarin.Forms;

namespace RideSafe.Presentation
{
	public partial class ShowUserInfo : ContentPage
	{
		public ShowUserInfo ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var data = App.DB.GetUserInfo();
            lblName.Text = data.Name;
            lblPhoneNumber.Text = data.PhoneNumber;
            lblSex.Text = data.Sex;
            lblWeight.Text = data.Weight.ToString("N2");
            lblAge.Text = data.Age.ToString();
            lblBloodType.Text = data.BloodType;
        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditUserInfo());
        }
    }
}
