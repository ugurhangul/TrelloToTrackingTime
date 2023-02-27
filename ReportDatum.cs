using System;
using System.Collections.Generic;
using System.Globalization;
using TrelloToTrackingTime.TrackingTime;

namespace TrelloToTrackingTime;

public partial class ReportDatum
{
    public string Board { get; set; }

    public string List { get; set; }

    public string Card { get; set; }

    public string Member { get; set; }

    public DateTime? Date { get; set; }

    public string StartTime { get; set; }
    public string EndTime { get; set; }

    public DateTime Start => DateTime.Parse($"{Date.Value.ToShortDateString()} {StartTime}");
    public DateTime End => DateTime.Parse($"{Date.Value.ToShortDateString()} {EndTime}");


    public double? DurationHours { get; set; }

    public string Description { get; set; }
}
