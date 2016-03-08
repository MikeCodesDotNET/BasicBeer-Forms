using System;
using Xamarin.Forms;
using BasicBeerForms.Controls;

namespace BasicBeerForms.Views.iOS
{
    public class RootPageiOS : TabbedPage
    {
        public RootPageiOS()
        {
            Children.Add(new BeerDrinkinNavigationPage(new MyBeersPage {Title = "My Beers", Icon = "tabbar_mybeers.png"}));
            Children.Add(new BeerDrinkinNavigationPage(new WishListPage {Title = "Wish List", Icon = "tabbar_wishlist.png"}));
            Children.Add(new BeerDrinkinNavigationPage(new SearchPage() {Title = "Search", Icon = "tabbar_search.png"}));
            Children.Add(new BeerDrinkinNavigationPage(new ProfilePage() {Title = "Me", Icon = "tabbar_profile.png"}));
        }
    }
}

