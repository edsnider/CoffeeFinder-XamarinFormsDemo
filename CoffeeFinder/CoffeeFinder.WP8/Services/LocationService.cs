using System;
using System.Threading.Tasks;
using CoffeeFinder.Models;
using CoffeeFinder.Services;
using CoffeeFinder.WP8.Services;

[assembly: Xamarin.Forms.Dependency(typeof(LocationService))]
namespace CoffeeFinder.WP8.Services
{
    public class LocationService : ILocationService
    {
        public async Task<GeoCoords> GetGeoCoordinatesAsync()
        {
            var geolocator = new Windows.Devices.Geolocation.Geolocator(); 
            var geoposition = await geolocator.GetGeopositionAsync(); 
 
            var coords = new GeoCoords 
            { 
                Latitude = geoposition.Coordinate.Latitude, 
                Longitude = geoposition.Coordinate.Longitude 
            }; 
 
            return coords; 
        }
    }
}
