using CoffeeFinder.ViewModels;
using Xamarin.Forms;

namespace CoffeeFinder.Views
{
    public class MainView : TabbedPage
    {
        private MainViewModel _vm
        {
            get { return BindingContext as MainViewModel; }
        }

        public MainView()
        {
            BindingContext = new MainViewModel();

            var refresh = new ToolbarItem
            {
				Text = "refresh",
                Icon = "refresh.png",
                Command = _vm.RefreshCommand,
                Priority = 0
            };

            ToolbarItems.Add(refresh);

            Title = "Coffee Finder";

            // Add tabs to page
            var list = new VenueListView(_vm) { Title = "List", Icon = "list.png" };
            var map = new VenueMapView(_vm) { Title = "Map", Icon = "map.png"};

            Children.Add(list);
            Children.Add(map);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_vm == null || _vm.IsBusy || _vm.Venues.Count > 0)
                return;
            
            _vm.RefreshCommand.Execute(null);
        }
    }
}
