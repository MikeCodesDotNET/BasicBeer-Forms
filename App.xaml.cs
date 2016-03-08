using System;
using System.Collections.Generic;

using Xamarin.Forms;
using BasicBeerForms.Views;

namespace BasicBeerForms
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
           InitializeComponent();

            switch (Device.OS)
            {
                case TargetPlatform.Android:
                    MainPage = new Views.Android.RootPageAndroid();
                    break;
                case TargetPlatform.iOS:
                    MainPage = new Views.iOS.RootPageiOS();
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

