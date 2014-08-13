using System.Threading.Tasks;
using CoffeeFinder.Droid.Services;
using CoffeeFinder.Models;
using CoffeeFinder.Services;
using Xamarin.Forms;
using Xamarin.Geolocation;

[assembly: Xamarin.Forms.Dependency(typeof(LocationService))]
namespace CoffeeFinder.Droid.Services
{
    public class LocationService : ILocationService
    {
        public async Task<GeoCoords> GetGeoCoordinatesAsync()
        {
            var locator = new Geolocator(Forms.Context) { DesiredAccuracy = 30 };
            var position = await locator.GetPositionAsync(30000);

            var result = new GeoCoords
            {
                Latitude = position.Latitude,
                Longitude = position.Longitude
            };

            return result;
        }
    }
}