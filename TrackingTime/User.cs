using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrelloToTrackingTime.TrackingTime
{
    public class User
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("surname")]
        [JsonPropertyName("surname")]
        public string Surname { get; set; }

        [JsonProperty("avatar_url")]
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("token")]
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonProperty("third_party_data")]
        [JsonPropertyName("third_party_data")]
        public object ThirdPartyData { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int? Id { get; set; }

    }
}
