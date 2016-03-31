using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BasicBeerForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Device.OS != TargetPlatform.Android)
                MainPage = new Views.RootPage();
            else
                MainPage = new Views.RootAndroid();
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

