// Import necessary namespaces
using System;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Methods{
    public partial class HttpMethods{

        public async Task deleteUserPost() {
        
        // Handle error
        try{

        // Set the URL for the POST request
        var url = "https://jsonplaceholder.typicode.com/posts/1";

        // Send the Delete request and await the response
        var response = await client.DeleteAsync(url);

        // Read the response content as a string
        var DeleteResult = await response.Content.ReadAsStringAsync();

        // Print the response content to the console
        Console.WriteLine("***************************************************************************************");

        Console.WriteLine("Post Deleted successfully");

        Console.WriteLine();

        Console.WriteLine(DeleteResult);

        Console.WriteLine("***************************************************************************************");


        }

        // catch the exception and show in console
        catch(Exception ex){
            
            Console.WriteLine("An error occurred: " + ex.Message);

        }

        }   
    

    }
}