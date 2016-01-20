using Xamarin.UITest;

namespace BasicBeerForms.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp (Platform platform)
		{
			// http://developer.xamarin.com/guides/testcloud/uitest/adding-uitest/
			if (platform == Platform.Android) {
				return ConfigureApp
					.Android
					.StartApp();
			}

			return ConfigureApp
				.iOS
				.StartApp();
		}
	}
}