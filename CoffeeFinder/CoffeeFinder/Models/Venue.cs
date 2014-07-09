using Newtonsoft.Json;

namespace CoffeeFinder.Models
{
    public class Venue
    {
        public string Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("location")]
        public VenueAddress Address { get; set; }
    }
}
