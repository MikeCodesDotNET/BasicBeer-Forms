using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FormsToolkit.Droid;
using Android.Graphics.Drawables;

namespace BasicBeerForms.Droid
{
    [Activity(Label = "BasicBeerForms.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Toolkit.Init();
            LoadApplication(new App());

            if ((int)Android.OS.Build.VERSION.SdkInt >= 21) {
                ActionBar.SetIcon (
                    new ColorDrawable (Resources.GetColor (Android.Resource.Color.Transparent)));
            }        }
    }
}

