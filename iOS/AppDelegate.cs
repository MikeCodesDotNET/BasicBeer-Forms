using Foundation;
using UIKit;

namespace BasicBeerForms.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{

			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App ());

			initGlobalAppearance();
					
			#if DEBUG
			Xamarin.Calabash.Start();
			#endif

			return base.FinishedLaunching(app, options);
		}


		static void initGlobalAppearance ()
		{
			UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes {
				Font = UIFont.FromName("Avenir-Medium", 17f),
				TextColor = UIColor.White
			});
			UIBarButtonItem.Appearance.SetTitleTextAttributes(new UITextAttributes {
				Font = UIFont.FromName("Avenir-Medium", 17f),
				TextColor = UIColor.White
			}, UIControlState.Normal);
		}
	}
}