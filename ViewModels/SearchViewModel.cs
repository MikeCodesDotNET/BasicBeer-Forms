using System;
using System.Collections.ObjectModel;
using BreweryDB.Models;
using Xamarin.Forms;
using System.Threading.Tasks;
using Connectivity.Plugin;

namespace BasicBeerForms.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        public SearchViewModel()
        {
        }

        ObservableCollection<Beer> beers = new ObservableCollection<Beer>();

        public ObservableCollection<Beer> Beers
        {
            get { return beers; }
            set { beers = value; OnPropertyChanged("Beers"); }
        }

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
                    var navigation = App.Current.MainPage as NavigationPage;
                    navigation.PushAsync(new Views.DescriptionPage());
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

            var isConnected = await CrossConnectivity.Current.IsReachable("google.com");

            if(!isConnected)
            {
                Acr.UserDialogs.UserDialogs.Instance.ShowError("No connection found. Please check your internetz");
                return;
            }

            if (IsBusy)
                return;

            IsBusy = true;
            Acr.UserDialogs.UserDialogs.Instance.ShowLoading("Fetching beers!");

            try
            {
                //TODO fill in your BreweryDB API Key here
                var client = new BreweryDB.BreweryDBClient("YOURE_KEY_GOES_HERE");
                var results = await client.SearchForBeer(searchTerm);

                Beers.Clear();

                if (results.Count > 0)
                {
                    foreach (var beer in results)
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
                Acr.UserDialogs.UserDialogs.Instance.HideLoading();
            }
        }

    }
}

