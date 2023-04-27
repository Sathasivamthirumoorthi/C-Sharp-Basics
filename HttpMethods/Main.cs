// Import necessary namespaces
using System;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Methods{

    public class TestHttpMethod{

         public static async Task Main(string[] args){

            Console.WriteLine("Choose any one from bellow http methods");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine();
            Console.WriteLine("1 GET : Get all repositories from account");
            Console.WriteLine("2 POST : Create new post");
            Console.WriteLine("3 PUT : Modify the enire post");
            Console.WriteLine("4 PATCH : Update post");
            Console.WriteLine("5 DELETE : Delete post");
            Console.WriteLine();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

            Console.WriteLine();

            int methodType;
            
            Console.Write("choose    : ");

            methodType = Convert.ToInt32(Console.ReadLine());


            HttpMethods John = new HttpMethods();

            switch(methodType){

                case 1: 
                    Console.WriteLine("You are choosen GET");
                    await John.getAllRepositories();
                    break;

                case 2: 
                    Console.WriteLine("You are choosen POST");
                    await John.createUserPost();
                    break;
                
                case 3: 
                    Console.WriteLine("You are choosen PUT");
                    await John.putUserPost();
                    break;
                
                case 4: 
                    Console.WriteLine("You are choosen PATCH");
                    await John.updateUserPost();
                    break;
                
                case 5: 
                    Console.WriteLine("You are choosen DELETE");
                    await John.deleteUserPost();
                    break;
                
                default:
                    Console.WriteLine("Please choose between 1 - 5");
                    break;
            }

        }




    }

}