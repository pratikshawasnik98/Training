using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_distance_bwt_two_points
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 1st point numbers");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 2st point numbers");
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            int result = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
            Console.WriteLine("Result :" + result);
            Console.WriteLine("Distance between two points :" + Math.Sqrt(result));

            Console.ReadKey();
        }
    }
}
