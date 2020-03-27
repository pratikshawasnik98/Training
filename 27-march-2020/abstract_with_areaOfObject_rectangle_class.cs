using System;

namespace abstract_with_areaOfObject_rectangle_class
{
    abstract class Shape
    {
        public float lenght, breadth, side;
        public double radius;
        public abstract void RectangleArea(float lenght, float breadth);
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
            Area[] area = new Area[5];
            for(int i=0;i<4;i++)
            {
                area[i] = new Area();
                Console.WriteLine("Enter a lenght and breadth of rectangle");
                area[i].lenght = float.Parse(Console.ReadLine());
                area[i].breadth = float.Parse(Console.ReadLine());
                area[i].RectangleArea(area[i].lenght, area[i].breadth);
            }
            for (int i = 0; i < 4; i++)
            {
                area[i] = new Area();
                Console.WriteLine("Enter a side of Square");
                area[i].side = float.Parse(Console.ReadLine());      
                area[i].SquareArea(area[i].side);
            }
            for (int i = 0; i < 5; i++)
            {
                area[i] = new Area();
                Console.WriteLine("Enter a radius of circle");
                area[i].radius = float.Parse(Console.ReadLine());
                area[i].CircleArea(area[i].radius);
            }
            
            Console.ReadKey();
        }
    }
}
