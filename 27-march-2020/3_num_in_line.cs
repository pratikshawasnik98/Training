using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_num_in_line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you wnat to print from 1 to .....");
            string num = Console.ReadLine();

            Console.WriteLine("Enter a number of lines you wnat to print from 1 to .....");
            int n = int.Parse(Console.ReadLine()) ;

            for (int a = 1; a <= n; a++)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
