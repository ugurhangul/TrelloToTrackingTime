using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TrelloToTrackingTime.TrackingTime;

public class TrackingTimeResponse<T>
{
    [JsonProperty("response")]
    [JsonPropertyName("response")]
    public Response Response { get; set; }

    [JsonProperty("data")]
    [JsonPropertyName("data")]
    public T Data { get; set; }
}


public class Response
{
    [JsonProperty("status")]
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonProperty("version")]
    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonProperty("message")]
    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonProperty("note")]
    [JsonPropertyName("note")]
    public object Note { get; set; }

    [JsonProperty("note_type")]
    [JsonPropertyName("note_type")]
    public object NoteType { get; set; }
}