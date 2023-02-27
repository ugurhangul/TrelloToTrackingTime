using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TrelloToTrackingTime.TrackingTime;

public class Project
{
    [JsonProperty("start_date")]
    [JsonPropertyName("start_date")]
    public object StartDate { get; set; }

    [JsonProperty("loc_start_date")]
    [JsonPropertyName("loc_start_date")]
    public object LocStartDate { get; set; }

    [JsonProperty("end_date")]
    [JsonPropertyName("end_date")]
    public object EndDate { get; set; }

    [JsonProperty("loc_end_date")]
    [JsonPropertyName("loc_end_date")]
    public object LocEndDate { get; set; }

    [JsonProperty("delivery_date")]
    [JsonPropertyName("delivery_date")]
    public object DeliveryDate { get; set; }

    [JsonProperty("loc_delivery_date")]
    [JsonPropertyName("loc_delivery_date")]
    public object LocDeliveryDate { get; set; }

    [JsonProperty("estimated_time")]
    [JsonPropertyName("estimated_time")]
    public double EstimatedTime { get; set; }

    [JsonProperty("loc_estimated_time")]
    [JsonPropertyName("loc_estimated_time")]
    public string LocEstimatedTime { get; set; }

    [JsonProperty("accumulated_time")]
    [JsonPropertyName("accumulated_time")]
    public int AccumulatedTime { get; set; }

    [JsonProperty("is_archived")]
    [JsonPropertyName("is_archived")]
    public bool IsArchived { get; set; }

    [JsonProperty("following")]
    [JsonPropertyName("following")]
    public bool Following { get; set; }

    [JsonProperty("notes")]
    [JsonPropertyName("notes")]
    public object Notes { get; set; }

    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonProperty("color")]
    [JsonPropertyName("color")]
    public object Color { get; set; }

    [JsonProperty("tasks")]
    [JsonPropertyName("tasks")]
    public List<Card> Tasks { get; set; }

    [JsonProperty("customer")]
    [JsonPropertyName("customer")]
    public Customer Customer { get; set; }

    [JsonProperty("service")]
    [JsonPropertyName("service")]
    public object Service { get; set; }

    [JsonProperty("billing")]
    [JsonPropertyName("billing")]
    public Billing Billing { get; set; }

    [JsonProperty("is_public")]
    [JsonPropertyName("is_public")]
    public bool IsPublic { get; set; }

    [JsonProperty("default_view")]
    [JsonPropertyName("default_view")]
    public object DefaultView { get; set; }

    [JsonProperty("worked_hours")]
    [JsonPropertyName("worked_hours")]
    public double WorkedHours { get; set; }

    [JsonProperty("loc_worked_hours")]
    [JsonPropertyName("loc_worked_hours")]
    public string LocWorkedHours { get; set; }

    [JsonProperty("worked_hours_today")]
    [JsonPropertyName("worked_hours_today")]
    public object WorkedHoursToday { get; set; }

    [JsonProperty("worked_hours_this_week")]
    [JsonPropertyName("worked_hours_this_week")]
    public object WorkedHoursThisWeek { get; set; }

    [JsonProperty("worked_hours_this_month")]
    [JsonPropertyName("worked_hours_this_month")]
    public object WorkedHoursThisMonth { get; set; }

    [JsonProperty("loc_worked_hours_today")]
    [JsonPropertyName("loc_worked_hours_today")]
    public object LocWorkedHoursToday { get; set; }

    [JsonProperty("loc_worked_hours_this_week")]
    [JsonPropertyName("loc_worked_hours_this_week")]
    public object LocWorkedHoursThisWeek { get; set; }

    [JsonProperty("loc_worked_hours_this_month")]
    [JsonPropertyName("loc_worked_hours_this_month")]
    public object LocWorkedHoursThisMonth { get; set; }

    [JsonProperty("active_tasks")]
    [JsonPropertyName("active_tasks")]
    public int ActiveTasks { get; set; }

    [JsonProperty("archived_tasks")]
    [JsonPropertyName("archived_tasks")]
    public int ArchivedTasks { get; set; }

    [JsonProperty("is_template")]
    [JsonPropertyName("is_template")]
    public bool IsTemplate { get; set; }

    [JsonProperty("users_hours")]
    [JsonPropertyName("users_hours")]
    public object UsersHours { get; set; }

    [JsonProperty("coworkers")]
    [JsonPropertyName("coworkers")]
    public object Coworkers { get; set; }

    [JsonProperty("files")]
    [JsonPropertyName("files")]
    public object Files { get; set; }

    [JsonProperty("account_index")]
    [JsonPropertyName("account_index")]
    public object AccountIndex { get; set; }

    [JsonProperty("user_preferences")]
    [JsonPropertyName("user_preferences")]
    public object UserPreferences { get; set; }

    [JsonProperty("doc_id")]
    [JsonPropertyName("doc_id")]
    public int DocId { get; set; }

    [JsonProperty("third_party_data")]
    [JsonPropertyName("third_party_data")]
    public object ThirdPartyData { get; set; }

    [JsonProperty("user_index")]
    [JsonPropertyName("user_index")]
    public object UserIndex { get; set; }

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


    [JsonProperty("task_lists")]
    [JsonPropertyName("task_lists")]
    public List<List> Lists { get; set; }



}