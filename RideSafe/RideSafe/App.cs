using System;

using Xamarin.Forms;
using System.IO;
using RideSafe.Business;
using RideSafe.Presentation;

namespace RideSafe
{
	public class App : Application
	{
        public static Database DB;

		public App ()
		{
            string db = "ridesafe.db3";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), db);

            DB = new Database(path);

            MainPage = new NavigationPage(new StartScreen());
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
	}
}
