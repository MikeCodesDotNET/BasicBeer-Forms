using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace BasicBeerForms.Droid.UITests
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			app = ConfigureApp
				.Android
				.StartApp();
		}

		[Test]
		public void NavigateThroughApp ()
		{
			// app.Repl();

			app.Screenshot("App launched");

			app.Tap(x => x.Id("search_src_text"));

			app.Screenshot("Tap on Search Bar");

			app.EnterText(x => x.Id("search_src_text"), "Duvel");

			app.Screenshot("Entered 'Duvel' into Search Bar");

			app.PressEnter();

			app.WaitForElement(x => x.Class("TextCellRenderer_TextCellView").Index(3), "Timed out waiting for at lease 3 results");

			app.Screenshot("Search results for 'Duvel'");

			app.Tap(x => x.Class("TextCellRenderer_TextCellView").Index(1));

			app.Screenshot("Tapped on second result");

			app.ClearText(x => x.Id("search_src_text"));

			app.Screenshot("Cleared Search Bar");

			app.EnterText(x => x.Id("search_src_text"), "Duvel");

			app.Screenshot("Entered 'Duvel' into Search Bar");

			app.PressEnter();

			app.WaitForElement(x => x.Class("TextCellRenderer_TextCellView").Index(3), "Timed out waiting for at lease 3 results");

			app.Screenshot("Search results for 'Duvel'");
		}
	}
}