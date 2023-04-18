using System;


// Create a class hierarchy to represent different types of animals.
//  Use abstraction to define abstract methods for feeding and making sounds
//  . Implement concrete classes for specific animals like dog, cat, and bird.

namespace MyProblem{

    abstract class Animals{

        public abstract void AnimalSound();
        public void eat(){
            Console.WriteLine("I will eat");
        }
        
    }


    class Dog : Animals{
        public override void AnimalSound(){
            Console.WriteLine("bark");
        }
    }


    class Cat : Animals{
        public override void AnimalSound()
        {
            Console.WriteLine("meow");

        }
    }

    class Bird : Animals{
        public override void AnimalSound()
        {
            Console.WriteLine("sounds");

        }
    }

    // class TestAbstraction{
    //     public static void Main(string[] args){
    //         Cat cat = new Cat();
    //         cat.AnimalSound();
    //     }
    // }

}