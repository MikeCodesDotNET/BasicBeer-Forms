using System;
using Xamarin.Forms;
using FormsToolkit;

namespace BasicBeerForms.Controls
{
    public class BeerDrinkinNavigationPage : NavigationPageNoLine
    {
        public BeerDrinkinNavigationPage(Page root) : base(root)
        {
            Init();
            Title = root.Title;
            Icon = root.Icon;
        }

        public BeerDrinkinNavigationPage()
        {
            Init();
        }

        void Init()
        {
            BarBackgroundColor = (Color)Application.Current.Resources["Primary"];
            BarTextColor = (Color)Application.Current.Resources["NavigationText"];
        }
    }
}


