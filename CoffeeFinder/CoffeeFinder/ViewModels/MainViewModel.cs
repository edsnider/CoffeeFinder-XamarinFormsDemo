using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CoffeeFinder.Models;
using CoffeeFinder.Services;
using Xamarin.Forms;

namespace CoffeeFinder.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IFoursquareService _foursquare;
        private readonly ILocationService _location;

        private ObservableCollection<Venue> _venues;
        public ObservableCollection<Venue> Venues
        {
            get { return _venues; }
            set
            {
                _venues = value;
                OnPropertyChanged();
            }
        }

        private GeoCoords _currentLocation;
        public GeoCoords CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Venues = new ObservableCollection<Venue>();

            // TODO: constructor injection
            _foursquare = new FoursquareService();
            _location = DependencyService.Get<ILocationService>();
        }

        private Command _refreshCommand;
        public Command RefreshCommand
        {
            get { return _refreshCommand ?? (_refreshCommand = new Command(async () => await ExecuteRefreshCommand())); }
        }

        private async Task ExecuteRefreshCommand()
        {
            if (IsBusy) return;

            //CurrentLocation  = new GeoCoords { Latitude = 38.954577, Longitude = -77.346357 }; // Reston VA
            CurrentLocation = await _location.GetGeoCoordinatesAsync();
            MessagingCenter.Send(this, "LocationSet");

            await LoadVenues();
        }

        private async Task LoadVenues()
        {
            if (IsBusy) return;
            IsBusy = true;

            Venues.Clear();

            try
            {
                var response = await _foursquare.GetVenues("coffee", CurrentLocation);

                foreach (var v in response.Venues)
                    Venues.Add(v);

                // Publish message that Venues collection has been fully loaded
                MessagingCenter.Send(this, "VenuesLoaded");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
