using System;

using Xamarin.Forms;

namespace BasicBeerForms.Controls
{
    public class NavigationView : ContentPage
    {
        public void OnNavigationItemSelected(NavigationItemSelectedEventArgs e)
        {
            NavigationItemSelected?.Invoke(this, e);
        }

        public event NavigationItemSelectedEventHandler NavigationItemSelected;

        public class NavigationItemSelectedEventArgs : EventArgs
        {
            public int Index { get; set; }
        }

        public delegate void NavigationItemSelectedEventHandler(object sender, NavigationItemSelectedEventArgs e);
    }
}


