// Import necessary namespaces
using System;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Methods{
    public partial class HttpMethods{

        static readonly HttpClient client = new HttpClient();

        public async Task getAllRepositories()
        {
            try{
                // GitHub repo endpoint
                var url = "https://api.github.com/users/Sathasivamthirumoorthi/repos";
                // Call the GetRepositoriesAsync method to retrieve the list of repositories
                var myRepositories = await GetRepositoriesAsync(url);
                // Output the number of repositories found
                Console.WriteLine($"Found {myRepositories.Count} repositories:");
                // Loop through each projects in repository and output its name
                foreach (var projects in myRepositories)
                {
                    Console.WriteLine("***************************************************************************************");
                    Console.WriteLine($"- {projects.Name}");
                    Console.WriteLine();
                    Console.WriteLine($"- {projects.Description}");
                    Console.WriteLine("***************************************************************************************");
                    Console.WriteLine();

                }
            }
            catch(Exception ex){
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public async Task<List<Repository>> GetRepositoriesAsync(string url)
        {
            // Create a new HttpRequestMessage with the desired HTTP method and URL
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            // Add headers to the request to specify the desired response format and user agent
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClient");
            // Send the request using the HttpClient and wait for the response
            var response = await client.SendAsync(request);
            // Ensure that the response status code indicates success
            response.EnsureSuccessStatusCode();

            Console.WriteLine("response code ", response.EnsureSuccessStatusCode());
            
            // Read the response content as a string
            var responseString = await response.Content.ReadAsStringAsync();
            // Deserialize the JSON response string into a list of Repository objects using Newtonsoft.Json
            var repositories = JsonConvert.DeserializeObject<List<Repository>>(responseString);
            // var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(responseString);

            // Return the list of repositories
            return repositories;
        }

    }
    
}