using Newtonsoft.Json;
using RestSharp;

namespace TrelloToTrackingTime.TrackingTime
{
    public class TrackingTime
    {

        private readonly RestClient _client;


        public TrackingTime(string username, string password)
        {
            var auth = $"{username}:{password}".ToBase64Encode();


            var options = new RestClientOptions("https://app.trackingtime.co/api/v4")
            {
                MaxTimeout = -1,
            };
            _client = new RestClient(options);
            _client.AddDefaultHeader("Authorization", $"Basic {auth}");

        }

        public async Task<TrackingTimeResponse<Project>> CreateProject(string projectName)
        {
            var request = new RestRequest("projects/add", Method.Post);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("name", projectName);
            var response = await _client.PostAsync<TrackingTimeResponse<Project>>(request);
            return response;

        }


        public async Task<TrackingTimeResponse<List>> CreateList(int projectId, string listName, int index)
        {
            var request = new RestRequest($"projects/{projectId}/task_lists/add", Method.Post);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("name", listName);
            request.AddParameter("index", index);
            request.AddParameter("project_id", projectId);
            var response = await _client.PostAsync<TrackingTimeResponse<List>>(request);
            return response;

        }


        public async Task<TrackingTimeResponse<Card>> CreateCard(int projectId, int listId, string taskName, string description, List<User> users, bool isArchived)
        {
            var request = new RestRequest($"tasks/share", Method.Post);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("name", taskName.Length > 499 ? taskName.Substring(0, 499) : taskName);
            request.AddParameter("project_id", projectId);
            request.AddParameter("list_id", listId);
            request.AddParameter("description", description);
            request.AddParameter("is_archived", isArchived);
            request.AddParameter("users", JsonConvert.SerializeObject(users, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            }));

            var response = await _client.PostAsync<TrackingTimeResponse<Card>>(request);

            if (isArchived)
            {
                _ = CloseCard(response.Data.Id);
            }



            return response;

        }

        public async Task<Task> CloseCard(int taskId)
        {

            var request = new RestRequest($"tasks/close/{taskId}");

            await _client.PostAsync(request);


            return Task.CompletedTask;

        }


        public async Task<Task> CreateTimeEntry(int durationInSeconds, int userId, DateTime start, DateTime end, int taskId)
        {
            var request = new RestRequest($"events/add", Method.Post);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("user_id", userId);
            request.AddParameter("duration", durationInSeconds);
            request.AddParameter("start", start.ToString("yyyy-MM-dd HH:MM:ss"));
            request.AddParameter("end", end.ToString("yyyy-MM-dd HH:MM:ss"));
            request.AddParameter("task_id", taskId);
            request.AddParameter("timezone", "GMT+03:00");

            await _client.PostAsync(request);

            return Task.CompletedTask;
        }


        public async Task<List<TimeEntry>> GetTaskTimeEntries(int taskId)
        {
            var request = new RestRequest("events", Method.Post);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("filter", "TASK");
            request.AddParameter("data", "[{\"id\":" + taskId + "}]");
            request.AddParameter("id", taskId);
            request.AddParameter("from", "2018-10-01");
            request.AddParameter("to", "2025-10-31");



            var entries = await _client.PostAsync<TrackingTimeResponse<List<TimeEntry>>>(request);

            return await Task.FromResult(entries.Data);
        }


        public async Task<List<Project>> GetAllProjects()
        {

            var request = new RestRequest($"projects");
            //request.AddQueryParameter("include_task_lists", true);
            //request.AddQueryParameter("include_tasks", true);



            return (await _client.PostAsync<TrackingTimeResponse<List<Project>>>(request)).Data;

        }


        public async Task<List<List>> GetProjectLists(int projectId)
        {

            var request = new RestRequest($"projects/{projectId}/task_lists");

            return (await _client.PostAsync<TrackingTimeResponse<List<List>>>(request)).Data;

        }


        public void GetListsAndTasks(ref Project project)
        {
            Console.WriteLine($"Fetching {project.Name} Tasks");
            var request = new RestRequest($"projects/{project.Id}?include_task_lists=true");
            request.AddParameter("filter", "ALL");
            project = _client.PostAsync<TrackingTimeResponse<Project>>(request).Result.Data;
        }
    }
}
