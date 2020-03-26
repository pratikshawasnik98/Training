using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of days:");
            int num = int.Parse(Console.ReadLine());

            int year = num / 365;
            Console.WriteLine("Year : " + year);

            int months = num / 30;
            Console.WriteLine("moths : " + months);

            int week = num / 7;
            Console.WriteLine("Weeks : " + week);

            int day = num % 365;
            Console.WriteLine("Days : " + day);

            Console.ReadKey();
        }
    }
}
