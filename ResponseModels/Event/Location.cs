using Newtonsoft.Json;

namespace SpondAPI.ResponseModels.Event
{
    class Location
    {
        [JsonProperty("id")]
        public string ID;

        [JsonProperty("feature")]
        public string Feature;

        [JsonProperty("address")]
        public string Address;

        [JsonProperty("latitude")]
        public double Latitude;

        [JsonProperty("longitude")]
        public double Longitude;

        [JsonProperty("postalCode")]
        public string Postcode;

        [JsonProperty("country")]
        public string Country;

        [JsonProperty("administrativeAreaLevel1")]
        public string AdministrativeAreaLevel1;

        [JsonProperty("administrativeAreaLevel2")]
        public string AdministrativeAreaLevel2;
    }
}
