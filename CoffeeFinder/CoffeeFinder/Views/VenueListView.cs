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

            var listView = new ListView {ItemsSource = viewModel.Venues};

            var itemTemplate = new DataTemplate(typeof (TextCell));
            itemTemplate.SetBinding(TextCell.TextProperty, "Name");
            itemTemplate.SetBinding(TextCell.DetailProperty, "Address.City");
            listView.ItemTemplate = itemTemplate;

            Content = listView;
        }
    }
}
