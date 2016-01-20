using System;

using Xamarin.Forms;
using BreweryDB.Models;
using BasicBeerForms.CustomRenderers;

namespace BasicBeerForms.Views
{
    public class DescriptionPage : ContentPage
    {
        public Beer SelectedBeer { get; set;}

        public DescriptionPage(Beer selectedBeer)
        {
            //Set our selected beer
            SelectedBeer = selectedBeer;

            var photo = new ImageCircle
            {
                WidthRequest = this.Width,
                HeightRequest = 200,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center
            };

            photo.Source = ImageSource.FromUri(new Uri(SelectedBeer.Labels.Large));

            Content = new StackLayout
            { 
                Children =
                {
                    photo,
                    new Label
                    {
                        Text = selectedBeer.Description,
                        XAlign = TextAlignment.Center
                    }
                }
            };
        }
    }
}


