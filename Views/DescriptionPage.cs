using System;

using Xamarin.Forms;
using BreweryDB.Models;

namespace BasicBeerForms.Views
{
    public class DescriptionPage : ContentPage
    {
        public Beer SelectedBeer { get; set;}

        public DescriptionPage()
        {
            Content = new StackLayout
            { 
                Children =
                {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


