using System;

using Xamarin.Forms;
using System.Collections.Generic;
using BasicBeerForms.Controls;
using System.Threading.Tasks;
using BasicBeerForms.Views;

namespace BasicBeerForms.Views.Android
{
    public class RootPageAndroid : TabbedPage
    {
        public RootPageAndroid()
        {
            Children.Add(new BeerDrinkinNavigationPage(new MyBeersPage {Title = "My Beers"}));
            Children.Add(new BeerDrinkinNavigationPage(new WishListPage {Title = "Wish List"}));
            Children.Add(new BeerDrinkinNavigationPage(new SearchPage() {Title = "Search"}));
            Children.Add(new BeerDrinkinNavigationPage(new ProfilePage() {Title = "Me"}));
        }
    }
}


