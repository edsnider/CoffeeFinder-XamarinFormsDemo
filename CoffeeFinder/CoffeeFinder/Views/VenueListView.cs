using CoffeeFinder.Models;
using CoffeeFinder.ViewModels;
using Xamarin.Forms;

namespace CoffeeFinder.Views
{
    public class VenueListView : ContentPage
    {
        public VenueListView(MainViewModel viewModel)
        {
            BindingContext = viewModel;

            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(0, 10)
            };

            var progress = new ActivityIndicator
            {
                IsEnabled = true,
                Color = Color.White
            };

            progress.SetBinding(IsVisibleProperty, "IsBusy");
            progress.SetBinding(ActivityIndicator.IsRunningProperty, "IsBusy");

            stack.Children.Add(progress);

            var listView = new ListView {ItemsSource = viewModel.Venues};

            var itemTemplate = new DataTemplate(typeof (TextCell));
            itemTemplate.SetBinding(TextCell.TextProperty, "Name");
            itemTemplate.SetBinding(TextCell.DetailProperty, "Address.City");
            listView.ItemTemplate = itemTemplate;

            stack.Children.Add(listView);

            Content = stack;
        }
    }
}
