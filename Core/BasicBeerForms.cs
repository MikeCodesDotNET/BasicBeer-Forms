using System;

using Xamarin.Forms;

namespace BasicBeerForms
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage (new Views.SearchPage ()) {
				Title = "Search",
				BarBackgroundColor = Color.FromHex("15A9FF"),
				BarTextColor = Color.White
			};
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