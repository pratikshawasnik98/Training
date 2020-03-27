using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_no_in_a_no_of_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
             int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number of lines you wnat to print :");
            int no_of_lines = int.Parse(Console.ReadLine());
            
            for (int a = 1; a <= no_of_lines; a++)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
