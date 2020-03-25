using System;

namespace ClassShape
{
    class Shape
    {
        public void ShowShape()
        {
            Console.WriteLine("This is Shape");
        }
    }
    class Rectangle :Shape
    {
        public void ShowRectangle()
        {
            Console.WriteLine("This is Rectangular Shape");
        }
    }
    class Circle : Shape
    {
        public void ShowCircle()
        {
            Console.WriteLine("This is circular Shape");
        }
    }
    class Square : Rectangle
    {
        public void ShowSquare()
        {
            Console.WriteLine("Square is a Rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            
            square.ShowShape();
            square.ShowRectangle();

            Console.ReadKey();
        }
    }
}
