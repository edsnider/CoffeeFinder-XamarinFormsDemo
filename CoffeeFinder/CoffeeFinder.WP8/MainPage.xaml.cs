using Microsoft.Phone.Controls;
using Xamarin;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace CoffeeFinder.WP8
{
    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            Forms.Init();
            FormsMaps.Init();
            LoadApplication(new CoffeeFinder.App());
        }
    }
}
