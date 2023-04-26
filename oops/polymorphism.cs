using System;

namespace MyProblem1{
    class Shape{
        
        public virtual void area(){
            Console.WriteLine("Area of a shape");
        }
    }

    class Circle : Shape{
        public override void area(){
            Console.WriteLine("Area of a Circle");
        }
    }

    class Square : Shape{
        public override void area(){
            Console.WriteLine("Area of a Square");
        } 
    }

    class Triangle : Shape{
        public override void area(){
            Console.WriteLine("Area of a Triangle");
        } 
    }


    class TestShape{
        // public static void Main(String[] args){
        //     Shape circle = new Circle();
        //     Shape triangle = new Triangle();
        //     Shape shape = new Shape();
        //     shape.area();
        //     circle.area();
        //     triangle.area();
        // }
    }


}