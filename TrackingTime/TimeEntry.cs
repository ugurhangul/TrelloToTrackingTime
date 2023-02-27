using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TrelloToTrackingTime.TrackingTime;

public class TimeEntry
{
    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonProperty("start")]
    [JsonPropertyName("start")]
    public string Start { get; set; }

    [JsonProperty("loc_start")]
    [JsonPropertyName("loc_start")]
    public string LocStart { get; set; }

    [JsonProperty("end")]
    [JsonPropertyName("end")]
    public string End { get; set; }

    [JsonProperty("loc_end")]
    [JsonPropertyName("loc_end")]
    public string LocEnd { get; set; }

    [JsonProperty("duration")]
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonProperty("loc_duration")]
    [JsonPropertyName("loc_duration")]
    public string LocDuration { get; set; }

    [JsonProperty("formated_duration")]
    [JsonPropertyName("formated_duration")]
    public string FormatedDuration { get; set; }

    [JsonProperty("service")]
    [JsonPropertyName("service")]
    public object Service { get; set; }

    [JsonProperty("service_id")]
    [JsonPropertyName("service_id")]
    public object ServiceId { get; set; }

    [JsonProperty("customer")]
    [JsonPropertyName("customer")]
    public object Customer { get; set; }

    [JsonProperty("customer_id")]
    [JsonPropertyName("customer_id")]
    public object CustomerId { get; set; }

    [JsonProperty("project")]
    [JsonPropertyName("project")]
    public object Project { get; set; }

    [JsonProperty("project_id")]
    [JsonPropertyName("project_id")]
    public object ProjectId { get; set; }

    [JsonProperty("skill")]
    [JsonPropertyName("skill")]
    public object Skill { get; set; }

    [JsonProperty("skill_id")]
    [JsonPropertyName("skill_id")]
    public object SkillId { get; set; }

    [JsonProperty("task")]
    [JsonPropertyName("task")]
    public string Task { get; set; }

    [JsonProperty("task_id")]
    [JsonPropertyName("task_id")]
    public int TaskId { get; set; }

    [JsonProperty("task_list")]
    [JsonPropertyName("task_list")]
    public object TaskList { get; set; }

    [JsonProperty("due_date")]
    [JsonPropertyName("due_date")]
    public object DueDate { get; set; }

    [JsonProperty("estimated_time")]
    [JsonPropertyName("estimated_time")]
    public object EstimatedTime { get; set; }

    [JsonProperty("is_archived")]
    [JsonPropertyName("is_archived")]
    public bool IsArchived { get; set; }

    [JsonProperty("user")]
    [JsonPropertyName("user")]
    public string User { get; set; }

    [JsonProperty("user_id")]
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonProperty("timezone")]
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }

    [JsonProperty("notes")]
    [JsonPropertyName("notes")]
    public object Notes { get; set; }

    [JsonProperty("color")]
    [JsonPropertyName("color")]
    public object Color { get; set; }

    [JsonProperty("repeat")]
    [JsonPropertyName("repeat")]
    public object Repeat { get; set; }

    [JsonProperty("end_repeat")]
    [JsonPropertyName("end_repeat")]
    public object EndRepeat { get; set; }

    [JsonProperty("frequency")]
    [JsonPropertyName("frequency")]
    public object Frequency { get; set; }

    [JsonProperty("repeat_every")]
    [JsonPropertyName("repeat_every")]
    public object RepeatEvery { get; set; }

    [JsonProperty("hourly_rate")]
    [JsonPropertyName("hourly_rate")]
    public object HourlyRate { get; set; }

    [JsonProperty("is_billable")]
    [JsonPropertyName("is_billable")]
    public bool IsBillable { get; set; }

    [JsonProperty("is_billed")]
    [JsonPropertyName("is_billed")]
    public bool IsBilled { get; set; }

    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonProperty("created_at")]
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    [JsonPropertyName("updated_at")]
    public object UpdatedAt { get; set; }

    [JsonProperty("json")]
    [JsonPropertyName("json")]
    public object Json { get; set; }
}