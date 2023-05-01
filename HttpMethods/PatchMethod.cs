// Import necessary namespaces
using System;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Methods{
    public partial class HttpMethods{
        public async Task updateUserPost() {
        
        // Handle error
        try{


        var userPost = new Post("Satha Sivam", "thirumoorthi");

        // Serialize the Post object to a JSON string
        var json = JsonConvert.SerializeObject(userPost);

        // Create a new StringContent object with the JSON string and set the content type to application/json
        // StringContent is a class in C# that represents HTTP content as a string
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        // Set the URL for the POST request
        var url = "https://jsonplaceholder.typicode.com/posts/1";

        // Send the Patch request and await the response
        var response = await client.PatchAsync(url, data);

        // Read the response content as a string
        var patchResult = await response.Content.ReadAsStringAsync();

        // Print the response content to the console
        Console.WriteLine("***************************************************************************************");
        Console.WriteLine("Successfully updated the User Post");
        Console.WriteLine();
        Console.WriteLine(patchResult);
        Console.WriteLine("***************************************************************************************");


        }

        // catch the exception and show in console
        catch(Exception ex){
            
            Console.WriteLine("An error occurred: " + ex.Message);

        }

        }


    }
}