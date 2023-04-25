using System;

namespace MyAbstract{

    abstract class Shape{
        public abstract void rectangleArea(int length,int breath);
        public abstract void circleArea(int radius);
        public abstract void squareArea(int side);
    }


    class Area : Shape{
        public override void rectangleArea(int length, int breath)
        {
            Console.WriteLine("Area of a rectangle {0} : ",length * breath);

        }

        public override void circleArea(int radius)
        {
            double area = 3.14 * (radius * radius);
            Console.WriteLine("Area of a circle {0} : ",area);
        }

        public override void squareArea(int side)
        {
            Console.WriteLine("Area of a square {0} :",4 * side);

        }
    }
}