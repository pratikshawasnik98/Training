using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_even_1_to_given
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number till you want to get a square :");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= num)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Number :" + i);
                    int square = i * i;
                    Console.WriteLine(" Number square :" + square);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
