using System.Threading.Tasks;
using CoffeeFinder.Models;

namespace CoffeeFinder.Services
{
    public interface ILocationService
    {
        Task<GeoCoords> GetGeoCoordinatesAsync();
    }
}
