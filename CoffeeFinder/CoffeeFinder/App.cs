using CoffeeFinder.Views;
using Xamarin.Forms;

namespace CoffeeFinder
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new MainView());
        }
    }
}
