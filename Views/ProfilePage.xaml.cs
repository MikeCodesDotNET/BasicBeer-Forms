using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicBeerForms.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

            if (Device.OS == TargetPlatform.iOS)
            {
                Icon = new FileImageSource { File = "tabbar_profile.png" };
            }
        }
    }
}

