using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bike_avrage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance:");
            float distance = float.Parse(Console.ReadLine());

            float avg;

            Console.WriteLine("enter a fuel:");
            float lit = float.Parse(Console.ReadLine());

            avg = distance / lit;
            Console.WriteLine("Avrage :" + avg);
            Console.ReadKey();

        }
    }
}
