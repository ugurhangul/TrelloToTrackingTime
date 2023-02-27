using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TrelloToTrackingTime.TrackingTime;

public class List
{
    [JsonProperty("is_archived")]
    [JsonPropertyName("is_archived")]
    public bool IsArchived { get; set; }

    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonProperty("notes")]
    [JsonPropertyName("notes")]
    public object Notes { get; set; }

    [JsonProperty("list_position")]
    [JsonPropertyName("list_position")]
    public object ListPosition { get; set; }

    [JsonProperty("tasks")]
    [JsonPropertyName("tasks")]
    public List<Card> Tasks { get; set; }



    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonProperty("created_at")]
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    [JsonPropertyName("updated_at")]
    public object UpdatedAt { get; set; }

}