// Import necessary namespaces
using System;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;



namespace Methods{
   public class RestMethods {

    // Create a new instance of HttpClient, which can be reused across multiple requests
    static readonly HttpClient client = new HttpClient();

    public async Task get()
    {
        try{
        var url = "https://api.github.com/users/Sathasivamthirumoorthi/repos";
        // Call the GetRepositoriesAsync method to retrieve the list of repositories
        var repositories = await GetRepositoriesAsync(url);
        Console.WriteLine(repositories);
        Console.WriteLine();

        // Output the number of repositories found
        Console.WriteLine($"Found {repositories.Count} repositories:");
        // Loop through each repository and output its name
        foreach (var repo in repositories)
        {
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine($"- {repo.name}");
            Console.WriteLine();
            Console.WriteLine($"- {repo.Description}");
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


     public async Task delete() {
        
        // Handle error
        try{

        // Set the URL for the POST request
        var url = "https://jsonplaceholder.typicode.com/posts/1";

        // Send the Delete request and await the response
        var response = await client.DeleteAsync(url);

        // Read the response content as a string
        var result = await response.Content.ReadAsStringAsync();

        // Print the response content to the console
        Console.WriteLine("***************************************************************************************");
        Console.WriteLine(result);
        Console.WriteLine("***************************************************************************************");


        }

        // catch the exception and show in console
        catch(Exception ex){
            
            Console.WriteLine("An error occurred: " + ex.Message);

        }

        }   
    

    
    public async Task post() {
        
        // Handle error
        try{
        
        // Create a new instance of the HttpClient class
        var client = new HttpClient();

        // Create a new instance of the Person class
        var person = new Person("ccc", "aaa");

        // Serialize the Person object to a JSON string
        var json = JsonConvert.SerializeObject(person);

        // Create a new StringContent object with the JSON string and set the content type to application/json
        // StringContent is a class in C# that represents HTTP content as a string
        var data    = new StringContent(json, Encoding.UTF8, "application/json");

        // Set the URL for the POST request
        var url = "https://jsonplaceholder.typicode.com/posts";

        // Send the POST request and await the response
        var response = await client.PostAsync(url, data);

        // Read the response content as a string
        var result = await response.Content.ReadAsStringAsync();

        // Print the response content to the console
        Console.WriteLine("***************************************************************************************");
        Console.WriteLine(result);
        Console.WriteLine("***************************************************************************************");


        }

        // catch the exception and show in console
        catch(Exception ex){
            
            Console.WriteLine("An error occurred: " + ex.Message);

        }

    }
    


    public async Task put() {
        
        // Handle error
        try{
        

        // Create a new instance of the Person class
        var person = new Person("ccc", "sss");

        // Serialize the Person object to a JSON string
        var json = JsonConvert.SerializeObject(person);

        // Create a new StringContent object with the JSON string and set the content type to application/json
        // StringContent is a class in C# that represents HTTP content as a string
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        // Set the URL for the POST request
        var url = "https://jsonplaceholder.typicode.com/posts/1";

        // Send the PUT request and await the response
        var response = await client.PutAsync(url, data);

        // Read the response content as a string
        var result = await response.Content.ReadAsStringAsync();

        // Print the response content to the console
        Console.WriteLine("***************************************************************************************");
        Console.WriteLine(result);
        Console.WriteLine("***************************************************************************************");


        }

        // catch the exception and show in console
        catch(Exception ex){
            
            Console.WriteLine("An error occurred: " + ex.Message);

        }

        }


        public async Task patch() {
        
        // Handle error
        try{


        // Create a new instance of the Person class
        var person = new Person("ccc", "sss");

        // Serialize the Person object to a JSON string
        var json = JsonConvert.SerializeObject(person);

        // Create a new StringContent object with the JSON string and set the content type to application/json
        // StringContent is a class in C# that represents HTTP content as a string
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        // Set the URL for the POST request
        var url = "https://jsonplaceholder.typicode.com/posts/1";

        // Send the Patch request and await the response
        var response = await client.PatchAsync(url, data);

        // Read the response content as a string
        var result = await response.Content.ReadAsStringAsync();

        // Print the response content to the console
        Console.WriteLine("***************************************************************************************");
        Console.WriteLine(result);
        Console.WriteLine("***************************************************************************************");


        }

        // catch the exception and show in console
        catch(Exception ex){
            
            Console.WriteLine("An error occurred: " + ex.Message);

        }

        }

       

    }

    public record class Repository(
    [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("description")] string Description
    );


    class TestMethods{
         public static async Task Main(string[] args){

            Console.WriteLine("Choose any one");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("1 GET");
            Console.WriteLine("2 POST");
            Console.WriteLine("3 PUT");
            Console.WriteLine("4 PATCH");
            Console.WriteLine("5 DELETE");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

            Console.WriteLine();

            int methodType;
            
            Console.WriteLine("choose");

            methodType = Convert.ToInt32(Console.ReadLine());

            RestMethods methods = new RestMethods();

            switch(methodType){

                case 1: 
                    Console.WriteLine("You are choosen GET");
                    await methods.get();
                    break;

                case 2: 
                    Console.WriteLine("You are choosen POST");
                    await methods.post();
                    break;
                
                case 3: 
                    Console.WriteLine("You are choosen PUT");
                    await methods.put();
                    break;
                
                case 4: 
                    Console.WriteLine("You are choosen PATCH");
                    await methods.patch();
                    break;
                
                case 5: 
                    Console.WriteLine("You are choosen DELETE");
                    await methods.delete();
                    break;
                
                default:
                    Console.WriteLine("Please choose between 1 - 5");
                    break;


            }





        




        }

    }

 

}