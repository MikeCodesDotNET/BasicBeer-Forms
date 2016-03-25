using System;
using BreweryDB.Models;
using Xamarin.Forms;

namespace BasicBeerForms.ViewModels
{
    public class BeerDescriptionViewModel : BaseViewModel
    {

        public UriImageSource ImageSource { get; set;}
        public string Description { get; set;}


        public BeerDescriptionViewModel(Beer beer)
        {
            Title = beer.Name;
            Description = beer.Description;
            ImageSource = new UriImageSource();
            ImageSource.Uri = new Uri(beer?.Labels?.Large);
        }
    }
}


