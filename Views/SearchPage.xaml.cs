using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicBeerForms.Views
{
	[XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();

            BindingContext = new ViewModels.SearchViewModel();

            if (Device.OS == TargetPlatform.iOS)
            {
                Icon = new FileImageSource { File = "tabbar_search.png" };
            }

        }	
	}
}

