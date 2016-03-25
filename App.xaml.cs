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

            switch (Device.OS)
            {
                case TargetPlatform.Android:
                    MainPage = new Views.RootPage();
                    break;
                case TargetPlatform.iOS:
                    MainPage = new Views.RootPage();
                    break;
                default:
                    throw new NotImplementedException();
            }
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

