using System;
using System.Collections.ObjectModel;
using BreweryDB.Models;
using Xamarin.Forms;
using System.Threading.Tasks;
using BreweryDB.Interfaces;

namespace BasicBeerForms.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        public SearchViewModel()
        {
        }

        ObservableCollection<IBeer> beers = new ObservableCollection<IBeer>();
        public ObservableCollection<IBeer> Beers
        {
            get { return beers; }
            set { beers = value; OnPropertyChanged("Beers"); }
        }

        public Color BackgroundColor = Color.FromHex("F7F7F7");
        public Color ColorBlue = Color.FromHex("15A9FE");

        public Beer NewBeer { get; set;}

        private Beer selectedBeer;
        public Beer SelectedBeer
        {
            get { return selectedBeer; }
            set
            {
                selectedBeer = value;
                OnPropertyChanged("SelectedBeer");

                if(selectedBeer != null)
                {
                    var tabbedPage = Application.Current.MainPage as Views.RootPage;
                    var navigation = tabbedPage.Children[2].Navigation;
                    navigation.PushAsync(new Views.BeerDescription(selectedBeer), true);
                }
            }
        }

        string searchTerm = string.Empty;
        public string SearchTerm
        {
            get
            {
                return searchTerm;
            }
            set
            {
                searchTerm = value;
                OnPropertyChanged("SearchTerm");
            }
        }

        private Command searchBeersCommand;
        public Command SearchBeersCommand
        {
            get { return searchBeersCommand ?? (searchBeersCommand = new Command(async () => await ExecuteSearchBeersCommand())); }
        }

        private async Task ExecuteSearchBeersCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                //TODO fill in your BreweryDB API Key here
                var client = new BreweryDB.BreweryDbClient("b7da1c5827026053a276f0dbe2234962");
                var results = await client.Beers.Search(searchTerm);

                Beers.Clear();

                if (results.Data.Count > 0)
                {
                    foreach (var beer in results.Data)
                    {
                        Beers.Add(beer);            
                    }  
                    return;
                }
            }
            catch(Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.ShowError(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}

