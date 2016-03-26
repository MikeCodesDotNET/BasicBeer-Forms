using Xamarin.Forms;
using BasicBeerForms.Controls;

namespace BasicBeerForms.Views
{
    public class RootPage : TabbedPage
    {
        public RootPage()
        {
            Children.Add(new BeerDrinkinNavigationPage(new MyBeersPage {Title = "My Beers"}));
            Children.Add(new BeerDrinkinNavigationPage(new WishListPage {Title = "Wish List"}));
            Children.Add(new BeerDrinkinNavigationPage(new SearchPage() {Title = "Search"}));
            Children.Add(new BeerDrinkinNavigationPage(new ProfilePage() {Title = "Me"}));
        }
    }
}

