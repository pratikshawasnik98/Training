using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no_squar_cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number of lines you wnat to print :");
            int no_of_lines = int.Parse(Console.ReadLine());

            int square = num * num;
            int cube = num * num * num;
            for (int a = 1; a <= no_of_lines; a++)
            {
                Console.WriteLine(num +"Square is : " + square + " Cube is : " +cube);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
