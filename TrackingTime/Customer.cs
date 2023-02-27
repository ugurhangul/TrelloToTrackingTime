using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TrelloToTrackingTime.TrackingTime;

public class Customer
{
    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int Id { get; set; }
}