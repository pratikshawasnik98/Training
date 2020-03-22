using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_area_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a radius");
            int r = Convert.ToInt32(Console.ReadLine());
            float res = 3.14f * r * r;
            Console.WriteLine("result = " + res);
            Console.ReadKey();
        }
    }
}
