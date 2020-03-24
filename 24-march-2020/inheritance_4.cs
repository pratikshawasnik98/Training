using System;

namespace inheritance_4
{
    class Rectangle
    {
        public float Length { get; set; }
        public float Breath { get; set; }

        public Rectangle()
        {
            Console.WriteLine("Default ");
        }
        public Rectangle(float length, float breath)
        {
            Length = length;
            Breath = breath;
        }
        public void areaRectangle()
        {
            float area_rectangle = Length * Breath;
            Console.WriteLine("\nArea of Rectangle :" + area_rectangle);
        }
        public void perimeterRectangle()
        {
            float perimeter_rectangle = Length + Breath;
            Console.WriteLine("Perimeter of Rectangle :" + perimeter_rectangle);
        }
    }
    class Square : Rectangle
    {
        public float Side { get; set; }
        //public float Side2 { get; set; }

        public Square(float side)
        {
            Side = side;
        }
        public void areaSquare()
        {
            float areasquare = Side * Side;
            Console.WriteLine("\nArea of Square :" + areasquare);
        }
        public void perimeterSquare()
        {
            float perimetersquare = 4 * Side;
            Console.WriteLine("Perimeter of Square :" + perimetersquare);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3,5);
            rectangle.areaRectangle();
            rectangle.perimeterRectangle();
            Console.WriteLine();
            Square square = new Square(3);
            square.areaSquare();
            square.perimeterSquare();

            Console.ReadKey();
        }
    }
}
