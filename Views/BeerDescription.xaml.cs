using System;
using System.Collections.Generic;
using BreweryDB.Models;
using Xamarin.Forms;

namespace BasicBeerForms.Views
{
    public partial class BeerDescription : ContentPage
    {
        public BeerDescription(Beer beer)
        {
            InitializeComponent();

            BindingContext = new ViewModels.BeerDescriptionViewModel(beer);
        }
    }
}

