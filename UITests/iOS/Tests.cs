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
		public void AppLaunches ()
		{
			app.Screenshot("First screen.");
		}
	}
}