﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace BasicBeerForms.UITests
{
	#if DEBUG
	[TestFixture(Platform.iOS)]
	#endif

	#if !DEBUG
	[TestFixture(Platform.Android)]
	#endif
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void AppLaunches ()
		{
			app.Screenshot("First screen.");
		}
	}
} 