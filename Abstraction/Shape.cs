//     Create an abstract class Shape with abstract method public abstract Double calculate Perimeter()
using System;

namespace MyProblem{
    abstract class Shape{
        
        public static float pi = 3.14F;
        public abstract double calculatePerimeter();
    }

    class Circle : Shape{
        private float radius;

        public Circle(float radius){
            this.radius = radius;
        }
        
        public override double calculatePerimeter(){
            double perimeter;
            perimeter = 2 * this.radius * Shape.pi;
            return perimeter;
        }

    }


    class Rectangle : Shape{
        private float length;
        private float breadth;

        public Rectangle(float length, float breadth){
            this.breadth = breadth;
            this.length = length;
        }
        
        public override double calculatePerimeter(){
            double perimeter;
            perimeter = 2 * ( this.breadth + this.length);
            return perimeter;
        }
    }



    class Square : Shape{
        private float side;

        public Square(float side){
            this.side = side;
        }

        public override double calculatePerimeter(){

            return 4 * this.side;

        }
    }



    // class TestShape{
    //     public static void Main(string[] args){
    //         Console.WriteLine("List of Shapes");
    //         Console.WriteLine("1 . Circle");
    //         Console.WriteLine("2 . Rectangle");
    //         Console.WriteLine("3 . Square");
    //         int shape;
    //         Console.WriteLine("Enter your choice");
    //         shape = Convert.ToInt32(Console.ReadLine());
    //         Console.WriteLine();
    //         switch(shape){
    //             case 1:
    //                 float radius;
    //                 Console.WriteLine("Enter the radius of the circle : ");
    //                 radius = float.Parse(Console.ReadLine());
    //                 Console.WriteLine();
    //                 Circle circle = new Circle(radius);
    //                 Console.WriteLine("Perimeter of a circle : {0} ", circle.calculatePerimeter());
    //                 break;
    //             case 2:
    //                 float length;
    //                 float breadth;
    //                 Console.WriteLine("Enter the length of the rectangle : ");
    //                 length = float.Parse(Console.ReadLine());
    //                 Console.WriteLine("Enter the c of the rectangle : ");
    //                 breadth = float.Parse(Console.ReadLine());
    //                 Console.WriteLine();
    //                 Rectangle rectangle = new Rectangle(length,breadth);
    //                 Console.WriteLine("Perimeter of a rectangle : {0}" , rectangle.calculatePerimeter());                    
    //                 break;
    //             case 3:
    //                 float side;
    //                 Console.WriteLine("Enter the side of the square : ");
    //                 side = float.Parse(Console.ReadLine());
    //                 Console.WriteLine();
    //                 Square square = new Square(side);
    //                 Console.WriteLine("Perimeter of a square : {0}" , square.calculatePerimeter());                    
    //                 break;
    //         }
    //     }
    // }
}