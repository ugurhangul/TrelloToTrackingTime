// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using TrelloDotNet.Model;
using TrelloDotNet;
using TrelloToTrackingTime;
using TrelloToTrackingTime.TrackingTime;
using Card = TrelloToTrackingTime.TrackingTime.Card;
using List = TrelloToTrackingTime.TrackingTime.List;


var trackingTime = new TrackingTime(Environment.GetEnvironmentVariable("TRACKINGTIME_USERNAME"), Environment.GetEnvironmentVariable("TRACKINGTIME_PASSWORD"));

Console.WriteLine("Fetching Projects");
var projects = await trackingTime.GetAllProjects();



Console.WriteLine("Fetching Users");
var lel = File.ReadAllText("Team.json");

var team = JsonConvert.DeserializeObject<List<Team>>(lel);
var planyway = new TestContext().ReportData.ToList();


var trelloClient = new TrelloClient(Environment.GetEnvironmentVariable("TRELLO_API_KEY"), Environment.GetEnvironmentVariable("TRELLO_TOKEN"));
Console.WriteLine("Fetching Trello Boards");
var boards = await trelloClient.GetAsync<List<Board>>("/members/5f33edd734dc8f7355e4afee/boards");

foreach (var board in boards)
{


    var lists = await trelloClient.GetListsOnBoardAsync(board.Id);
    var cards = await trelloClient.GetCardsOnBoardFilteredAsync(board.Id, CardsFilter.All);


    var project = projects.Any(c => c.Name == board.Name) ? projects.FirstOrDefault(c => c.Name == board.Name) : (await trackingTime.CreateProject(board.Name)).Data;

    trackingTime.GetListsAndTasks(ref project);

    foreach (var list in lists)
    {
      

        List trackList;

        if (project!.Lists != null && project!.Lists.Any())
        {
            trackList = project.Lists.Any(c => c.Name == list.Name) ? project.Lists.FirstOrDefault(c => c.Name == list.Name) : (await trackingTime.CreateList(project.Id, list.Name, lists.IndexOf(list))).Data;
        }
        else
        {
            trackList = (await trackingTime.CreateList(project.Id, list.Name, lists.IndexOf(list))).Data;

        }




        foreach (var card in cards.Where(c => c.ListId == list.Id))
        {
            var members = card.MemberIds.Select(member => new User { Id = team.FirstOrDefault(c => c.TrelloId == member)?.TrackingTimeId }).ToList();

            Card trackCard;

            if (trackList!.Tasks != null && trackList!.Tasks.Any())
            {
                trackCard = trackList.Tasks.Any(c => c.Name == card.Name) ? trackList.Tasks.FirstOrDefault(c => c.Name == card.Name) : (await trackingTime.CreateCard(project.Id, trackList!.Id, card.Name, card.Description, members, card.Closed)).Data;
            }
            else
            {
                trackCard = (await trackingTime.CreateCard(project.Id, trackList!.Id, card.Name, card.Description, members, card.Closed)).Data;
            }

            Console.WriteLine($"Board: {boards.Count}/{boards.IndexOf(board) + 1} {board.Name} | List: {list.Name} | Card: {cards.Count}/{cards.IndexOf(card) + 1} {card.Name}");

            if (trackCard is { IsArchived: false })
            {
                var timeEntries = planyway.Where(c => c.Board == board.Name && c.Card == card.Name).ToList();
                var trackingTimeEvents = (await trackingTime.GetTaskTimeEntries(trackCard.Id));
                if (timeEntries.Count < trackingTimeEvents.Count)
                {
                    foreach (var timeEntry in timeEntries)
                    {

                        var timeMember = team.FirstOrDefault(c => c.Name == timeEntry.Member)!.TrackingTimeId;
                        var duration = (int)((timeEntry.DurationHours * 60) * 60)!;
                        if (trackingTimeEvents.Any(c => c.UserId == timeMember && c.Duration == duration)) continue;


#pragma warning disable CS4014
                        await trackingTime.CreateTimeEntry(duration, timeMember, timeEntry.Start, timeEntry.End, trackCard!.Id);
#pragma warning restore CS4014

                    }
                }
            }
        }
    }

}

