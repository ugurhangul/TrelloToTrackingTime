using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrelloToTrackingTime
{
    public class PlanywayEntry
    {
        [JsonProperty("Type")]
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonProperty("Board/Calendar")]
        [JsonPropertyName("Board/Calendar")]
        public string BoardCalendar { get; set; }

        [JsonProperty("List")]
        [JsonPropertyName("List")]
        public string List { get; set; }

        [JsonProperty("Title")]
        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonProperty("Labels")]
        [JsonPropertyName("Labels")]
        public string Labels { get; set; }

        [JsonProperty("Status")]
        [JsonPropertyName("Status")]
        public string Status { get; set; }

        [JsonProperty("StartDate")]
        [JsonPropertyName("StartDate")]
        public string StartDate { get; set; }

        [JsonProperty("StartTime")]
        [JsonPropertyName("StartTime")]
        public string StartTime { get; set; }

        public DateTime Start => DateTime.Parse($"{StartDate} {StartTime}", new DateTimeFormatInfo
        {
            DateSeparator = "/",
            TimeSeparator = ":",
        });



        [JsonProperty("EndDate")]
        [JsonPropertyName("EndDate")]
        public string EndDate { get; set; }

        [JsonProperty("EndTime")]
        [JsonPropertyName("EndTime")]
        public string EndTime { get; set; }


        public DateTime End => DateTime.Parse($"{EndDate} {EndTime}", new DateTimeFormatInfo
        {
            DateSeparator = "/",
            TimeSeparator = ":",
        });


        [JsonProperty("DurationHours")]
        [JsonPropertyName("DurationHours")]
        public double DurationHours { get; set; }

        [JsonProperty("TrackedTimeHours")]
        [JsonPropertyName("TrackedTimeHours")]
        public double TrackedTimeHours { get; set; }

        [JsonProperty("Description")]
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonProperty("Members")]
        [JsonPropertyName("Members")]
        public string Members { get; set; }

        [JsonProperty("ParentCard")]
        [JsonPropertyName("ParentCard")]
        public string ParentCard { get; set; }
    }

}
