using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TrelloToTrackingTime.TrackingTime;

public class Billing
{
    [JsonProperty("is_billable")]
    [JsonPropertyName("is_billable")]
    public bool IsBillable { get; set; }

    [JsonProperty("hourly_rate")]
    [JsonPropertyName("hourly_rate")]
    public object HourlyRate { get; set; }

    [JsonProperty("loc_hourly_rate")]
    [JsonPropertyName("loc_hourly_rate")]
    public object LocHourlyRate { get; set; }

    [JsonProperty("hourly_cost")]
    [JsonPropertyName("hourly_cost")]
    public object HourlyCost { get; set; }

    [JsonProperty("loc_hourly_cost")]
    [JsonPropertyName("loc_hourly_cost")]
    public object LocHourlyCost { get; set; }

    [JsonProperty("fixed_rate")]
    [JsonPropertyName("fixed_rate")]
    public object FixedRate { get; set; }

    [JsonProperty("loc_fixed_rate")]
    [JsonPropertyName("loc_fixed_rate")]
    public object LocFixedRate { get; set; }

    [JsonProperty("billable_hours")]
    [JsonPropertyName("billable_hours")]
    public double BillableHours { get; set; }

    [JsonProperty("non_billable_hours")]
    [JsonPropertyName("non_billable_hours")]
    public double NonBillableHours { get; set; }

    [JsonProperty("loc_billable_hours")]
    [JsonPropertyName("loc_billable_hours")]
    public string LocBillableHours { get; set; }

    [JsonProperty("loc_non_billable_hours")]
    [JsonPropertyName("loc_non_billable_hours")]
    public string LocNonBillableHours { get; set; }
}