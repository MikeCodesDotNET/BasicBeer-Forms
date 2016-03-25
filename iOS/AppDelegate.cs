using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using FormsToolkit.iOS;


namespace BasicBeerForms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Toolkit.Init();

            LoadApplication(new App());

            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes { Font = UIFont.FromName("Avenir-Medium", 17f), TextColor = UIColor.White });
            UIBarButtonItem.Appearance.SetTitleTextAttributes(new UITextAttributes { Font = UIFont.FromName("Avenir-Medium", 17f), TextColor = UIColor.White }, UIControlState.Normal);

            return base.FinishedLaunching(app, options);
        }

    }
}
