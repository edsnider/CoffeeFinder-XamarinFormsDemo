using CoffeeFinder.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CoffeeFinder.Views
{
    public class VenueMapView : ContentPage
    {
        private MainViewModel _vm
        {
            get { return BindingContext as MainViewModel; }
        }

        public VenueMapView(MainViewModel viewModel)
        {
            BindingContext = viewModel;

            var stack = new StackLayout();

            var map = new Map { IsShowingUser = true };
            
            // Subscribe to message from MainViewModel and move map to current location when it's set
            MessagingCenter.Subscribe<MainViewModel>(this, "LocationSet", s =>
            {
                var currentLocation = _vm.CurrentLocation;
                map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(currentLocation.Latitude, currentLocation.Longitude),
                                                                          Distance.FromMiles(0.3)));
            });

            // Subscribe to message from the MainViewModel and add pins to the map once the Venues collection is loaded
            MessagingCenter.Subscribe<MainViewModel>(this, "VenuesLoaded", s =>
            {
                map.Pins.Clear();
                foreach (var v in _vm.Venues)
                    map.Pins.Add(new Pin
                    {
                        Type = PinType.Place,
                        Position = new Position(v.Address.Latitude, v.Address.Longitude),
                        Address = v.Address.ToString(),
                        Label = v.Name
                    });
            });

            stack.Children.Add(map);

            Content = stack;
        }
    }
}
