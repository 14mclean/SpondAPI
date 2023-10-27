using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace SpondAPI.ResponseModels.Device
{
    class DeviceResponse : IResponse
    {
        [JsonIgnore]
        public string EndpointExtension { get { return string.Empty; } }
        [JsonIgnore]
        public string PluralExtension { get { return $"{SpondClient.standardAPIExtension}/device"; } }

        [JsonProperty("id")]
        public string ID;
        [JsonProperty("profileId")]
        public string ProfileID;
        [JsonProperty("pushToken")]
        public string PushToken;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("createdTime")]
        public long CreatedTime;
        [JsonProperty("userAgent")]
        public string UserAgent;
        [JsonProperty("production")]
        public bool IsProduction;
    }
}
