using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicBeerForms.Views
{
    public partial class WishListPage : ContentPage
    {
        public WishListPage()
        {
            InitializeComponent();

            if (Device.OS == TargetPlatform.iOS)
            {
                Icon = new FileImageSource { File = "tabbar_wishlist.png" };
            }
        }
    }
}

