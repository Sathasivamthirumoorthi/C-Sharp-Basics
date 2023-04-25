using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PublicApiAsyncDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();
            var url = "https://jsonplaceholder.typicode.com/todos/1";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = await response.Content.ReadAsStreamAsync();
                var data = await JsonSerializer.DeserializeAsync<Todo>(contentStream);

                Console.WriteLine($"Todo ID: {data.Id}");
                Console.WriteLine($"Title: {data.Title}");
                Console.WriteLine($"Completed: {data.Completed}");
            }
            else
            {
                Console.WriteLine($"API returned error {response.StatusCode}");
            }
        }
    }

    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}