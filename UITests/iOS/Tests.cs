using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace BasicBeerForms.iOS.UITests
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			app = ConfigureApp
				.iOS
				.StartApp();
		}

		[Test]
		public void NavigateThroughApp ()
		{
			// app.Repl();

			app.Screenshot("App launched");

			app.Tap(x => x.Marked("Search for beers!"));

			app.Screenshot("Tap on Search Bar");

			app.EnterText(x => x.Class("UISearchBarTextField"), "Duvel");

			app.Screenshot("Entered 'Duvel' into Search Bar");

			app.PressEnter();

			app.WaitForElement(x => x.Class("UITableViewCellContentView").Index(3), "Timed out waiting for at lease 3 results");

			app.Screenshot("Search results for 'Duvel'");

			app.Tap(x => x.Class("UITableViewCellContentView").Index(1));

			app.Screenshot("Tapped on first result");

			app.ClearText(x => x.Marked("Search for beers!"));

			app.Screenshot("Cleared Search Bar");

			app.EnterText(x => x.Class("UISearchBarTextField"), "Duvel");

			app.Screenshot("Entered 'Duvel' into Search Bar");

			app.PressEnter();

			app.WaitForElement(x => x.Class("UITableViewCellContentView").Index(3), "Timed out waiting for at lease 3 results");

			app.Screenshot("Search results for 'Duvel'");
		}
	}
}