using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicBeerForms.Views
{
    public partial class MyBeersPage : ContentPage
    {
        public MyBeersPage()
        {
            InitializeComponent();

            if (Device.OS == TargetPlatform.iOS)
            {
                Icon = new FileImageSource { File = "tabbar_mybeers.png" };
            }
        }
    }
}

