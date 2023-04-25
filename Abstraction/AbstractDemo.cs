using System;

namespace MyProblem
{

    abstract class AbstractDemo{
        public AbstractDemo(){
            Console.WriteLine("This is abstract contructor");
        }

        public abstract void a_method();

        public void method(){
            Console.WriteLine("This is non-abstract method");
        }

    }


        class Subclass : AbstractDemo{
            public override void a_method(){
                Console.WriteLine("This is abstract method");
            }
        }
    // class TestAbstractDemo{
    //     public static void Main(string[] args){

    //         Subclass subclass = new Subclass();

    //         subclass.a_method();
    //         subclass.method();
    //     }
    // }
    
}