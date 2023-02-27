using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrelloToTrackingTime.TrackingTime
{
    public class Card
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }


        [JsonProperty("project_id")]
        [JsonPropertyName("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("project")]
        [JsonPropertyName("project")]
        public string Project { get; set; }


        [JsonProperty("customer")]
        [JsonPropertyName("customer")]
        public object Customer { get; set; }

        [JsonProperty("customer_id")]
        [JsonPropertyName("customer_id")]
        public object CustomerId { get; set; }

        [JsonProperty("service")]
        [JsonPropertyName("service")]
        public object Service { get; set; }

        [JsonProperty("service_id")]
        [JsonPropertyName("service_id")]
        public object ServiceId { get; set; }

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

        [JsonProperty("start_date")]
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("loc_start_date")]
        [JsonPropertyName("loc_start_date")]
        public string LocStartDate { get; set; }

        [JsonProperty("end_date")]
        [JsonPropertyName("end_date")]
        public object EndDate { get; set; }

        [JsonProperty("loc_end_date")]
        [JsonPropertyName("loc_end_date")]
        public object LocEndDate { get; set; }

        [JsonProperty("due_date")]
        [JsonPropertyName("due_date")]
        public object DueDate { get; set; }

        [JsonProperty("loc_due_date")]
        [JsonPropertyName("loc_due_date")]
        public object LocDueDate { get; set; }

        [JsonProperty("list_position")]
        [JsonPropertyName("list_position")]
        public double ListPosition { get; set; }

        [JsonProperty("list_id")]
        [JsonPropertyName("list_id")]
        public int ListId { get; set; }

        [JsonProperty("list_name")]
        [JsonPropertyName("list_name")]
        public string ListName { get; set; }

        [JsonProperty("worked_hours")]
        [JsonPropertyName("worked_hours")]
        public double WorkedHours { get; set; }

        [JsonProperty("loc_worked_hours")]
        [JsonPropertyName("loc_worked_hours")]
        public string LocWorkedHours { get; set; }

        [JsonProperty("accumulated_time_display")]
        [JsonPropertyName("accumulated_time_display")]
        public string AccumulatedTimeDisplay { get; set; }

        [JsonProperty("tracking")]
        [JsonPropertyName("tracking")]
        public bool Tracking { get; set; }

        [JsonProperty("color")]
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonProperty("day_index")]
        [JsonPropertyName("day_index")]
        public int DayIndex { get; set; }

        [JsonProperty("index")]
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonProperty("skill")]
        [JsonPropertyName("skill")]
        public object Skill { get; set; }

        [JsonProperty("user")]
        [JsonPropertyName("user")]
        public User User { get; set; }

 
        [JsonProperty("service_item")]
        [JsonPropertyName("service_item")]
        public object ServiceItem { get; set; }

        [JsonProperty("tracking_event")]
        [JsonPropertyName("tracking_event")]
        public object TrackingEvent { get; set; }

        [JsonProperty("subtasks")]
        [JsonPropertyName("subtasks")]
        public List<object> Subtasks { get; set; }

        [JsonProperty("comments")]
        [JsonPropertyName("comments")]
        public List<object> Comments { get; set; }

        [JsonProperty("users")]
        [JsonPropertyName("users")]
        public List<User> Users { get; set; }

        [JsonProperty("files")]
        [JsonPropertyName("files")]
        public object Files { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("created_by")]
        [JsonPropertyName("created_by")]
        public User CreatedBy { get; set; }

        [JsonProperty("task_permalink")]
        [JsonPropertyName("task_permalink")]
        public object TaskPermalink { get; set; }

        [JsonProperty("third_party_data")]
        [JsonPropertyName("third_party_data")]
        public object ThirdPartyData { get; set; }

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
}
