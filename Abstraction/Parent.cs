using System;

namespace MyProblem{
    
    abstract class Parent{
        public abstract void message();

    }

    class child1 : Parent{
        public override void message(){
            Console.WriteLine("This is first subclass");
        }
    }

    class child2 : Parent{
        public override void message()
        {
            Console.WriteLine("This is second subclass");

        }
    }

}