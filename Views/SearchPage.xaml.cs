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
            BindingContext = new ViewModels.SearchViewModel();

            InitializeComponent();
        }	
	}
}

