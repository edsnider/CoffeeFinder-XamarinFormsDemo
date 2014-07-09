using System;
using System.Net.Http;
using System.Threading.Tasks;
using CoffeeFinder.Models;
using CoffeeFinder.Services.ResponseModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoffeeFinder.Services
{
    public class FoursquareService : IFoursquareService
    {
        #region Foursquare API client props
        private const string _CLIENT_ID = "";
        private const string _CLIENT_SECRET = "";
        #endregion

        public async Task<VenuesResponse> GetVenues(string query, GeoCoords coords)
        {
            var v = DateTime.Now.ToString("yyyyMMdd");

            var ll = string.Format("{0},{1}", coords.Latitude, coords.Longitude);

            var url = string.Format(@"https://api.foursquare.com/v2/venues/search?ll={0}&query={1}&client_id={2}&client_secret={3}&v={4}", ll, query, _CLIENT_ID, _CLIENT_SECRET, v);

            var client = new HttpClient();
            var response = await client.GetStringAsync(url);

            JObject o = JObject.Parse(response);

            return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<VenuesResponse>(o["response"].ToString()));

        }
    }
}
