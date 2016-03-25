using System;
using System.Collections.ObjectModel;

namespace BasicBeerForms.MockData
{
    public class MyBeersDataSource
    {
        public static ObservableCollection<BreweryDB.Models.Beer> Beers = new ObservableCollection<BreweryDB.Models.Beer>();
    }
}

