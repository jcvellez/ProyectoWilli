using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Ef6CoreForPosgreSQL.Transversal.Services
{
    public class NotiService : INotiService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _client;
        public NotiService(IConfiguration configuration, IHttpClientFactory client2)
        {
            _configuration = configuration;
            _client = client2;
        }
        public async Task SendNotification(string NotId, string title, string message)
        {

            var NotiBody2 = "{"
                            + "\"app_id\": \"89d67827-af12-44f6-b65f-0f7628721a82\","
                           + "\"contents\": {\"en\": \"" + message + "\", \"es\": \"" + message + "\"},"
                            + "\"headings\": {\"en\": \"Medicus\", \"es\": \"Medicus\"},"
                            + "\"template_id\": \"92d3bdae-0f6c-4c0d-b5d2-82c9e3ad9421\","
                           + "\"include_player_ids\": [\"" + NotId + "\"]}";

            var client = _client.CreateClient("Noti");
            var response = await client.PostAsync("api/v1/notifications", new StringContent(NotiBody2, Encoding.Default, "application/json"));
            Console.WriteLine(response);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Cannot add a todo task");
            }

            await Task.CompletedTask;



        }

    }
}