using Microsoft.Phone.Controls;
using Xamarin;
using Xamarin.Forms;

namespace CoffeeFinder.WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            FormsMaps.Init();
            Content = CoffeeFinder.App.GetMainPage().ConvertPageToUIElement(this);
        }
    }
}