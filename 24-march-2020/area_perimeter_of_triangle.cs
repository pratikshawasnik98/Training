using System;

namespace area_perimeter_of_triangle
{
    class Triangle
    {
        public int side1 { get; set; }
        public int side2 {get;set;}

        public Triangle()
        {
            Console.WriteLine("Area of Trinagle :");
            
            Console.WriteLine("Enter a 1st side :");
            side1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a 2sd side :");
            side2 = int.Parse(Console.ReadLine());
            int areaOfTriangle = (side1 * side2)/2;

            Console.WriteLine("Area of Trinagle Result :"+areaOfTriangle);

            Console.WriteLine("Perimeter of Trinagle :");
            int PerimeterOfTriangle = 3+4+5;

            Console.WriteLine("Area of Trinagle Result :" + PerimeterOfTriangle);            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.ReadKey();
        }
    }
}
