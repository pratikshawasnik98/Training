using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_quadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a quadrant");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            if(x > 0 && y > 0)
            {
                Console.WriteLine("Enter a quadrant points is in 1st quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Enter a quadrant points is in 2sd quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Enter a quadrant points is in 3rd quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Enter a quadrant points is in 4th quadrant");
            }
            Console.ReadKey();
        }
    }
}
