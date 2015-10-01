using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicBeerForms.Views
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            BindingContext = new ViewModels.SearchViewModel();

            InitializeComponent();
        }
    }
}

