using System;

namespace area_Perimeter_With_paramterConstructor
{
    class Triangle
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }

        public Triangle(int a,int b,int c)
        {
            side1 = a;
            side2 = b;
            side3 = c;
            Console.WriteLine("Area of Trinagle :");

            int areaOfTriangle = (side1*side2) / 2;

            Console.WriteLine("Area of Trinagle Result :" + areaOfTriangle);

            Console.WriteLine("\nPerimeter of Trinagle :");
            int PerimeterOfTriangle = side1+side2+side3;

            Console.WriteLine("Perimeter of Trinagle Result :" + PerimeterOfTriangle);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3,4,5);
            Console.ReadKey();
        }
    }
}
