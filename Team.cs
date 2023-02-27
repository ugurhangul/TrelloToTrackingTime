using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class Team
{
    [JsonProperty("Name")]
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonProperty("Email")]
    [JsonPropertyName("Email")]
    public string Email { get; set; }

    [JsonProperty("TrackingTimeId")]
    [JsonPropertyName("TrackingTimeId")]
    public int TrackingTimeId { get; set; }
    [JsonProperty("TrelloId")]
    [JsonPropertyName("TrelloId")]
    public string TrelloId { get; set; }




}