using BasicBeerForms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicBeerForms.Views
{
    public class RootAndroid : TabbedPage
    {
        public RootAndroid()
        {
            Children.Add(new MyBeersPage {Title = "My Beers"});
            Children.Add(new WishListPage {Title = "Wish List"});
            Children.Add(new SearchPage() {Title = "Search"});
            Children.Add(new ProfilePage() {Title = "Me"});
        }
    }
}
