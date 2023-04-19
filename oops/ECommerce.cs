using System;
using System.Collections.Generic;


// Implement a class to represent a shopping cart in an e-commerce application. 
// Use abstraction to define abstract
//  methods for adding and removing items.
//  Implement concrete methods for adding, removing, and calculating the total price of the
//   items in the cart.


namespace MyNamespace{

    // Creating a class Item with properties of Name and price
    class Item{
        
        // Name of the product(item)
        private string name;
        
        // Price of the product(item)
        private int price;

        // Creating parameterlized contructed for Item 
        public Item(string name,int price){
            this.name = name;
            this.price = price;
        }

        // get the name of the product
        public string Name{
            get{return name;}
        }

        // get the price of the product
        public int Price{
            get{return price;}
        }


    }


    // Creating a Abstract class of ECommerce
    abstract class ECommerce{

        // Declare the list to store all products
        protected List<Item> items = new List<Item>();

        // Define add method (To add a product to a list)
        public abstract void add(Item item);
        // Define remove method (To remove a product from a list)
        public abstract void remove(Item item);

        // calculate the price of all products and store it to total 
        public int calculateTotalPrice(){
            
            int total = 0;

            foreach(Item item in items){
                total += item.Price;
            }
            // return total
            return total;
        }

    } 


    // Creating a child class 'Card' that inherit the ECommmerce (Base Class)
    class Cart : ECommerce{
        
        // Override the base class method of add (Implementation of add method)
        public override void add(Item item)
        {
            Console.WriteLine("Item Added");
            // Add the item to list
            items.Add(item);
        }

        // Override the base class method of remove (Implementation of remove method)
        public override void remove(Item item)
        {
            Console.WriteLine("item removed");
            // Remove the item from list
            items.Remove(item);
            
        }


    }

    
    // Creating a Test class to test the code
    // class TestECommerce{
    //     // Implementation of Main method 
    //     public static void Main(String[] args){
    //         // Creating an object cart
    //         Cart cart = new Cart();

    //         Console.Write("Number of item to add :");

    //         // Get the number of item that is to be added in list 
    //         int numberOfItems = Convert.ToInt32(Console.ReadLine());
    //         Console.WriteLine();

    //         // Adding item to the list
    //         for(int i = 0; i < numberOfItems;i++){
    //             Console.WriteLine("Name the Item to be added : ");
    //             // get the name of the product
    //             string product = Console.ReadLine();
    //             Console.WriteLine("Price of this product : ");
    //             // get the price of the product
    //             int price = Convert.ToInt32(Console.ReadLine());
    //             // creating a object Item and passing product and price
    //             Item item = new Item(product,price);
    //             // add item to the list using card.add()
    //             cart.add(item);
    //             Console.WriteLine();

    //         }
    //         // Console totel price of the products in the list
    //         Console.WriteLine(" Total price of the product you purchased : {0}", cart.calculateTotalPrice());

    //     }
    // }

}