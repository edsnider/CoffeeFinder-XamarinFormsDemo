using System.Threading.Tasks;
using CoffeeFinder.Models;
using CoffeeFinder.Services.ResponseModels;

namespace CoffeeFinder.Services
{
    public interface IFoursquareService
    {
        Task<VenuesResponse> GetVenues(string query, GeoCoords coords);
    }
}
