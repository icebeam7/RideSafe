using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RideSafe.Presentation
{
	public partial class EditUserInfo : ContentPage
	{
		public EditUserInfo ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var data = App.DB.GetUserInfo();
            txtName.Text = data.Name;
            txtPhoneNumber.Text = data.PhoneNumber;
            txtSex.Text = data.Sex;
            txtWeight.Text = data.Weight.ToString("N2");
            txtAge.Text = data.Age.ToString();
            txtBloodType.Text = data.BloodType;
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string sex = txtSex.Text;
            double weight = double.Parse(txtWeight.Text);
            int age = int.Parse(txtAge.Text);
            string bloodType = txtBloodType.Text;

            App.DB.SaveUserInfo(name, phoneNumber, sex, weight, age, bloodType);
            Navigation.PopAsync();
        }
    }
}
