using System.Threading.Tasks;
using CoffeeFinder.iOS.Services;
using CoffeeFinder.Models;
using CoffeeFinder.Services;
using Xamarin.Geolocation;

[assembly: Xamarin.Forms.Dependency(typeof(LocationService))]
namespace CoffeeFinder.iOS.Services
{
    public class LocationService : ILocationService
    {
        public async Task<GeoCoords> GetGeoCoordinatesAsync()
        {
            var locator = new Geolocator() {DesiredAccuracy = 30};
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