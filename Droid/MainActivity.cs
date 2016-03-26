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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

namespace BasicBeerForms.Droid
{
    [Activity(Label = "Beer Drinkin Lite", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            ToolbarResource = Resource.Layout.toolbar;
            TabLayoutResource = Resource.Layout.tabs;
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            Xamarin.Insights.Initialize(Xamarin.Insights.DebugModeKey, this);

            LoadApplication(new App());
        }
    }
}

