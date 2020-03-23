using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                goto even;
                Console.WriteLine("Odd");
            goto end;
            even:
                Console.WriteLine("even");
            end:;
                Console.ReadKey();
        }
    }
}
