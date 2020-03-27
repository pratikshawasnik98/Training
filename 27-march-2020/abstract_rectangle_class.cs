using System;

namespace abstract_rectangle_class
{
    abstract class Shape
    {
        public abstract void RectangleArea(float lenght,float breadth);
        public abstract void SquareArea(float side);
        public abstract void CircleArea(double radius);
    }
    class Area : Shape
    {
        public override void RectangleArea(float lenght, float breadth)
        {
            float areaOfRectangle = lenght * breadth;
            Console.WriteLine("Area of Rectangle :" + areaOfRectangle);
        }
        public override void SquareArea(float side)
        {
            float areaOfsquare = side * side;
            Console.WriteLine("Area of Square :" + areaOfsquare);
        }
        public override void CircleArea(double radius)
        {
            double areaOfCircle = 2 * 3.14 * (radius * radius);
            Console.WriteLine("Area of circle :" + areaOfCircle);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            area.RectangleArea(5, 6);
            area.SquareArea(4);
            area.CircleArea(6);
            Console.ReadKey();
        }
    }
}
