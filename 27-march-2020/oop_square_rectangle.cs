using System;

namespace oop_square_rectangle
{
    class Shape
    {
        public void SquareArea(float side)
        {
            float areaOfsquare = side * side;
            Console.WriteLine("Area of Square :" + areaOfsquare);
        }
        public void RectangleArea(float lenght, float breadth)
        {
            float areaOfRectangle = lenght * breadth;
            Console.WriteLine("Area of Rectangle :" + areaOfRectangle);
        }
        
        
    }
    
        class Program
    {
        static void Main(string[] args)
        {
            Shape area = new Shape();
            area.SquareArea(4);
            area.RectangleArea(5, 6);
            Console.ReadKey();
        }
    }
}
