using Newtonsoft.Json;

namespace CoffeeFinder.Models
{
    public class VenueAddress
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lng")]
        public double Longitude { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1} {2}", Address, City, State);
        }
    }
}
