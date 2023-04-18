using System;


// Create a class called "Car" with properties like "make", "model", and "year" and methods like "start", "stop", and "accelerate".

namespace MyProblem{

    class Car{

        private string make;
        private string model; 

        private int year; 

        public string Make{
            get {return make;}
            set { make = value;}
        }

        public string Model{
            get {return model;}
            set { model = value;}
        }
        
        public int Year{
            get {return year;}
            set { year = value;}
        }

        public Car(){
            Year = 2000;
            Make = "";
            Model = "";
        }

        public Car(int year,string model,string make){
            Year = year;
            Model = model;
            Make = make;
        }

        public Car(Car car){
            Year = car.year;
            Model = car.model;
            Make = car.make;
        }

        public void start(){
            Console.WriteLine("Car started");
        }

        public void stop(){
            Console.WriteLine("Car stoped");
        }
        
        public void accelerate(){
            Console.WriteLine("Car accelerated");
        }
        
    }


    // class TestCar{
    //     public static void Main(String[] args){
    //         Car car = new Car();
    //         car.Year = 2001;
    //         Console.WriteLine(car.Year);
    //         car.accelerate();
    //     }
    // }
}

